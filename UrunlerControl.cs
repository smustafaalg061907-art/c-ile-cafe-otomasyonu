using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class UrunlerControl : UserControl
    {
        private DataTable _urunTablosu;

        public UrunlerControl()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            try
            {
                string sorgu = @"
                    SELECT 
                        u.Id, 
                        m.KategoriAdi AS [Menü], 
                        'URUN-' + CAST(u.Id AS VARCHAR) AS [Ürün Kodu], 
                        u.UrunAdi AS [Ürün Adı], 
                        u.BirimFiyati AS [Birim Fiyat1], 
                        0.00 AS [Birim Fiyat2], 
                        0.00 AS [Birim Fiyat3], 
                        u.Aciklama AS [Açıklama], 
                        '' AS [Tarih], 
                        u.Durum AS [Hızlı Satış],
                        u.KategoriId
                    FROM Urunler u
                    LEFT JOIN Menuler m ON u.KategoriId = m.Id
                    ORDER BY u.Id DESC";
                
                _urunTablosu = DAL.DatabaseHelper.GetData(sorgu);
                dataGridView.DataSource = _urunTablosu;
                
                dataGridView.RowHeadersVisible  = false;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewColumn col in dataGridView.Columns)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;

                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView.ColumnHeadersHeight = 50;
                dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                if (dataGridView.Columns.Count >= 10)
                {
                    dataGridView.Columns["Id"].Width = 45;
                    dataGridView.Columns["Menü"].Width = 130;
                    dataGridView.Columns["Ürün Kodu"].Width = 100;
                    dataGridView.Columns["Ürün Adı"].Width = 180;
                    dataGridView.Columns["Birim Fiyat1"].Width = 110;
                    dataGridView.Columns["Birim Fiyat2"].Visible = false; // Kullanılmıyor
                    dataGridView.Columns["Birim Fiyat3"].Visible = false; // Kullanılmıyor
                    dataGridView.Columns["Açıklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["Tarih"].Visible = false;
                    dataGridView.Columns["Hızlı Satış"].Width = 100;
                    dataGridView.Columns["KategoriId"].Visible = false;
                }
            }
            catch { }
        }

        // ---- İşlem butonları ----
        private void btnYeni_Click(object sender, EventArgs e)
        {
            DataRow yeniUrun = _urunTablosu.NewRow();
            var frm = new UrunKayitForm(yeniUrun);
            frm.ShowDialog();
            
            if (frm.Kaydedildi)
            {
                // SQL'e Kaydet
                string sorgu = "INSERT INTO Urunler (KategoriId, UrunAdi, BirimFiyati, Aciklama) VALUES ((SELECT TOP 1 Id FROM Menuler WHERE KategoriAdi=@Menu), @Ad, @Fiyat, @Aciklama)";
                System.Data.SqlClient.SqlParameter[] p = {
                    new System.Data.SqlClient.SqlParameter("@Menu", yeniUrun["Menü"].ToString()),
                    new System.Data.SqlClient.SqlParameter("@Ad", yeniUrun["Ürün Adı"].ToString()),
                    new System.Data.SqlClient.SqlParameter("@Fiyat", Convert.ToDecimal(yeniUrun["Birim Fiyat1"])),
                    new System.Data.SqlClient.SqlParameter("@Aciklama", yeniUrun["Açıklama"]?.ToString() ?? (object)DBNull.Value)
                };
                
                DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                MessageBox.Show("Ürün veritabanına eklendi.", "Bilgi");
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dataGridView.CurrentRow.DataBoundItem as DataRowView;
            if (rowView != null)
            {
                var frm = new UrunKayitForm(rowView.Row);
                frm.ShowDialog();
                if (frm.Kaydedildi)
                {
                    string sorgu = "UPDATE Urunler SET KategoriId=(SELECT TOP 1 Id FROM Menuler WHERE KategoriAdi=@Menu), UrunAdi=@Ad, BirimFiyati=@Fiyat, Aciklama=@Aciklama WHERE Id=@Id";
                    System.Data.SqlClient.SqlParameter[] p = {
                        new System.Data.SqlClient.SqlParameter("@Menu", rowView.Row["Menü"].ToString()),
                        new System.Data.SqlClient.SqlParameter("@Ad", rowView.Row["Ürün Adı"].ToString()),
                        new System.Data.SqlClient.SqlParameter("@Fiyat", Convert.ToDecimal(rowView.Row["Birim Fiyat1"])),
                        new System.Data.SqlClient.SqlParameter("@Aciklama", rowView.Row["Açıklama"]?.ToString() ?? (object)DBNull.Value),
                        new System.Data.SqlClient.SqlParameter("@Id", Convert.ToInt32(rowView.Row["Id"]))
                    };
                    DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                    MessageBox.Show("Ürün güncellendi.", "Bilgi");
                    Listele();
                }
            }
        }
        private void btnYenileListele_Click(object sender, EventArgs e) { Listele(); }
        private void btnMasaHareketleri_Click(object sender, EventArgs e) { /* ileride */ }
        private void btnKaydet_Click(object sender, EventArgs e)        { Listele(); }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                if (MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAL.DatabaseHelper.ExecuteCommand("DELETE FROM Urunler WHERE Id=@Id", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", id) });
                    MessageBox.Show("Ürün silindi.", "Bilgi");
                    Listele();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
                tab.TabControl.TabPages.Remove(tab);
        }
    }
}
