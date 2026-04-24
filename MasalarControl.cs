using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MasalarControl : UserControl
    {
        private DataTable _masaTablosu;

        public MasalarControl()
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
                        Id, 
                        MasaAdi AS [Masa], 
                        Aciklama, 
                        Durum AS [Durumu], 
                        CAST(0 AS BIT) AS [Rezerve Mi], 
                        '' AS [Eklenme Tarihi], 
                        '' AS [Son Islem Tarihi], 
                        '' AS [Kullanici], 
                        '' AS [Islem]
                    FROM Masalar
                    ORDER BY Id ASC";
                
                _masaTablosu = DAL.DatabaseHelper.GetData(sorgu);
                dataGridView.DataSource = _masaTablosu;

                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView.ColumnHeadersHeight = 50;
                dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                if (dataGridView.Columns.Count >= 9)
                {
                    dataGridView.Columns["Id"].Width = 50;
                    dataGridView.Columns["Masa"].Width = 100;
                    dataGridView.Columns["Aciklama"].Width = 250;
                    dataGridView.Columns["Durumu"].Width = 90;
                    dataGridView.Columns["Rezerve Mi"].Width = 110;
                    dataGridView.Columns["Eklenme Tarihi"].Visible = false; // Şimdilik Gizli
                    dataGridView.Columns["Son Islem Tarihi"].Visible = false; // Şimdilik Gizli
                    dataGridView.Columns["Kullanici"].Visible = false; // Şimdilik Gizli
                    dataGridView.Columns["Islem"].Visible = false; // Şimdilik Gizli
                }

                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch { }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var frm = new MasaKayitForm();
            frm.ShowDialog();
            
            if (frm.Kaydedildi)
            {
                string sorgu = "INSERT INTO Masalar (MasaAdi, Aciklama, Durum) VALUES (@Ad, @Aciklama, 0)";
                System.Data.SqlClient.SqlParameter[] p = {
                    new System.Data.SqlClient.SqlParameter("@Ad", frm.MasaAdi),
                    new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(frm.Aciklama) ? (object)DBNull.Value : frm.Aciklama)
                };
                DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                MessageBox.Show("Masa veritabanına eklendi.", "Bilgi");
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                string ad = dataGridView.CurrentRow.Cells["Masa"].Value?.ToString();
                string aciklama = dataGridView.CurrentRow.Cells["Aciklama"].Value?.ToString();

                var frm = new MasaKayitForm(ad, aciklama);
                frm.ShowDialog();
                if (frm.Kaydedildi)
                {
                    string sorgu = "UPDATE Masalar SET MasaAdi=@Ad, Aciklama=@Aciklama WHERE Id=@Id";
                    System.Data.SqlClient.SqlParameter[] p = {
                        new System.Data.SqlClient.SqlParameter("@Ad", frm.MasaAdi),
                        new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(frm.Aciklama) ? (object)DBNull.Value : frm.Aciklama),
                        new System.Data.SqlClient.SqlParameter("@Id", id)
                    };
                    DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                    MessageBox.Show("Masa güncellendi.", "Bilgi");
                    Listele();
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                bool mevcut = Convert.ToBoolean(dataGridView.CurrentRow.Cells["Durumu"].Value);
                
                string sorgu = "UPDATE Masalar SET Durum=@Durum WHERE Id=@Id";
                System.Data.SqlClient.SqlParameter[] p = {
                    new System.Data.SqlClient.SqlParameter("@Durum", !mevcut),
                    new System.Data.SqlClient.SqlParameter("@Id", id)
                };
                DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                Listele();
            }
        }

        private void btnRezervDegistir_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                var drv = dataGridView.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    bool mevcut = Convert.ToBoolean(drv["Rezerve Mi"]);
                    drv["Rezerve Mi"] = !mevcut;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                if (MessageBox.Show("Seçili masayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                    DAL.DatabaseHelper.ExecuteCommand("DELETE FROM Masalar WHERE Id=@Id", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", id) });
                    Listele();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Bu bir UserControl olduğu için ana formdaki TabPage üzerinden kapatılır.
            var tabControl = this.Parent?.Parent as DevExpress.XtraTab.XtraTabControl;
            if (tabControl != null && this.Parent is DevExpress.XtraTab.XtraTabPage tabPage)
            {
                tabControl.TabPages.Remove(tabPage);
            }
        }
    }
}
