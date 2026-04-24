using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MenulerForm : Form
    {
        private DataTable _menuTablosu;

        public MenulerForm()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            string sorgu = "SELECT Id, KategoriAdi AS [Menü Adı], Aciklama AS [Açıklama] FROM Menuler";
            _menuTablosu = DAL.DatabaseHelper.GetData(sorgu);
            dataGridView.DataSource = _menuTablosu;
            
            // Kolon ayarları
            if (dataGridView.Columns.Count >= 3)
            {
                dataGridView.Columns["Id"].Visible = false;  // Id Gizle
                dataGridView.Columns["Menü Adı"].Width = 200;
                dataGridView.Columns["Açıklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Başlık ayarları
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının Grid'e boş bir satır atmasını sağlar, sonra Kaydet butonuna basılınca DB'ye gider.
            DataRow yeniSatir = _menuTablosu.NewRow();
            _menuTablosu.Rows.Add(yeniSatir);

            int sonSatir = dataGridView.Rows.Count - 1;
            if(sonSatir >= 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[sonSatir].Selected = true;
                dataGridView.CurrentCell = dataGridView.Rows[sonSatir].Cells["Menü Adı"];
                dataGridView.BeginEdit(true);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                string ad = dataGridView.CurrentRow.Cells["Menü Adı"].Value?.ToString();
                if (MessageBox.Show($"'{ad}' kategorisini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow row = ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
                    if (row["Id"] != DBNull.Value)
                    {
                        int id = Convert.ToInt32(row["Id"]);
                        
                        // Önce bu kategoriye ait ürün var mı kontrol et
                        string chkQuery = "SELECT COUNT(*) FROM Urunler WHERE KategoriId = @Id";
                        int urunSayisi = DAL.DatabaseHelper.ExecuteScalar(chkQuery, new System.Data.SqlClient.SqlParameter("@Id", id));

                        if (urunSayisi > 0)
                        {
                            MessageBox.Show($"Bu kategoriye ait {urunSayisi} adet ürün bulunmaktadır.\n\nKategoriyi silebilmek için önce bu ürünleri silmeli veya başka bir kategoriye aktarmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Silme işlemini iptal et
                        }

                        string q = "DELETE FROM Menuler WHERE Id = @Id";
                        System.Data.SqlClient.SqlParameter[] p = { new System.Data.SqlClient.SqlParameter("@Id", id) };
                        DAL.DatabaseHelper.ExecuteCommand(q, p);
                    }
                    dataGridView.Rows.Remove(dataGridView.CurrentRow);
                    MessageBox.Show("Kategori veritabanından kalıcı olarak silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();

            foreach (DataRow row in _menuTablosu.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;
                
                string ad = row["Menü Adı"]?.ToString();
                string aciklama = row["Açıklama"]?.ToString();

                if (string.IsNullOrWhiteSpace(ad)) continue;

                if (row.RowState == DataRowState.Added || row["Id"] == DBNull.Value)
                {
                    string q = "INSERT INTO Menuler (KategoriAdi, Aciklama) VALUES (@Ad, @Aciklama)";
                    System.Data.SqlClient.SqlParameter[] p = {
                        new System.Data.SqlClient.SqlParameter("@Ad", ad),
                        new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(aciklama) ? (object)DBNull.Value : aciklama)
                    };
                    DAL.DatabaseHelper.ExecuteCommand(q, p);
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    string q = "UPDATE Menuler SET KategoriAdi=@Ad, Aciklama=@Aciklama WHERE Id=@Id";
                    System.Data.SqlClient.SqlParameter[] p = {
                        new System.Data.SqlClient.SqlParameter("@Ad", ad),
                        new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(aciklama) ? (object)DBNull.Value : aciklama),
                        new System.Data.SqlClient.SqlParameter("@Id", Convert.ToInt32(row["Id"]))
                    };
                    DAL.DatabaseHelper.ExecuteCommand(q, p);
                }
            }

            MessageBox.Show("Menü değişiklikleri veritabanına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele(); // Yeniden listele ki IDENTITY kimlikleri (ID'ler) tabloya atansın
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
