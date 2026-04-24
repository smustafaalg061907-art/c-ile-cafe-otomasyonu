using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MusterilerControl : UserControl
    {
        public MusterilerControl()
        {
            InitializeComponent();
        }

        private void MusterilerControl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            // Veritabanı sorgusu oluştur (En son ekleneni en üste getir)
            string sorgu = "SELECT Id, AdSoyad, Telefon, Email, Adres, Aciklama, KayitTarihi FROM Musteriler ORDER BY Id DESC";
            DataTable dt = DAL.DatabaseHelper.GetData(sorgu);
            
            dataGridView.DataSource = dt;

            // Görünüm Ayarları
            dataGridView.Columns["Id"].Visible = false;
            
            dataGridView.Columns["AdSoyad"].HeaderText = "Adı Soyadı";
            dataGridView.Columns["AdSoyad"].Width = 200;

            dataGridView.Columns["Telefon"].HeaderText = "Telefon Numarası";
            dataGridView.Columns["Telefon"].Width = 150;

            dataGridView.Columns["Email"].HeaderText = "E-Posta Adresi";
            dataGridView.Columns["Email"].Width = 200;

            dataGridView.Columns["Adres"].HeaderText = "Adres Bilgisi";
            dataGridView.Columns["Adres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Columns["Aciklama"].HeaderText = "Açıklama";
            dataGridView.Columns["Aciklama"].Width = 200;
            
            dataGridView.Columns["KayitTarihi"].HeaderText = "Kayıt Tarihi";
            dataGridView.Columns["KayitTarihi"].Width = 150;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriKayitForm frm = new MusteriKayitForm();
            frm.IsEditMode = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // SQL Parametreli Ekleme Sorgusu
                string sorgu = "INSERT INTO Musteriler (AdSoyad, Telefon, Email, Adres, Aciklama) VALUES (@AdSoyad, @Telefon, @Email, @Adres, @Aciklama)";
                System.Data.SqlClient.SqlParameter[] p = {
                    new System.Data.SqlClient.SqlParameter("@AdSoyad", frm.MusteriAdSoyad),
                    new System.Data.SqlClient.SqlParameter("@Telefon", string.IsNullOrEmpty(frm.Telefon) ? (object)DBNull.Value : frm.Telefon),
                    new System.Data.SqlClient.SqlParameter("@Email", string.IsNullOrEmpty(frm.Email) ? (object)DBNull.Value : frm.Email),
                    new System.Data.SqlClient.SqlParameter("@Adres", string.IsNullOrEmpty(frm.Adres) ? (object)DBNull.Value : frm.Adres),
                    new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(frm.Aciklama) ? (object)DBNull.Value : frm.Aciklama)
                };
                
                int basari = DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                if(basari > 0)
                {
                    MessageBox.Show("Müşteri veritabanına başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele(); // Listeyi yenile
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView.CurrentRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                
                MusteriKayitForm frm = new MusteriKayitForm();
                frm.IsEditMode = true;
                frm.MusteriAdSoyad = row.Cells["AdSoyad"].Value.ToString();
                frm.Telefon = row.Cells["Telefon"].Value?.ToString();
                frm.Email = row.Cells["Email"].Value?.ToString();
                frm.Adres = row.Cells["Adres"].Value?.ToString();
                frm.Aciklama = row.Cells["Aciklama"].Value?.ToString();
                
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Seçili satırdaki verileri doğrudan SQL'de Güncelle
                    string sorgu = "UPDATE Musteriler SET AdSoyad=@AdSoyad, Telefon=@Telefon, Email=@Email, Adres=@Adres, Aciklama=@Aciklama WHERE Id=@Id";
                    System.Data.SqlClient.SqlParameter[] p = {
                        new System.Data.SqlClient.SqlParameter("@AdSoyad", frm.MusteriAdSoyad),
                        new System.Data.SqlClient.SqlParameter("@Telefon", string.IsNullOrEmpty(frm.Telefon) ? (object)DBNull.Value : frm.Telefon),
                        new System.Data.SqlClient.SqlParameter("@Email", string.IsNullOrEmpty(frm.Email) ? (object)DBNull.Value : frm.Email),
                        new System.Data.SqlClient.SqlParameter("@Adres", string.IsNullOrEmpty(frm.Adres) ? (object)DBNull.Value : frm.Adres),
                        new System.Data.SqlClient.SqlParameter("@Aciklama", string.IsNullOrEmpty(frm.Aciklama) ? (object)DBNull.Value : frm.Aciklama),
                        new System.Data.SqlClient.SqlParameter("@Id", id)
                    };
                    DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                    
                    MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz müşteriyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                string adSoyad = dataGridView.CurrentRow.Cells["AdSoyad"].Value.ToString();
                DialogResult dr = MessageBox.Show($"{adSoyad} isimli müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sorgu = "DELETE FROM Musteriler WHERE Id = @Id";
                    System.Data.SqlClient.SqlParameter[] p = { new System.Data.SqlClient.SqlParameter("@Id", id) };
                    DAL.DatabaseHelper.ExecuteCommand(sorgu, p);
                    
                    MessageBox.Show("Müşteri sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                if (tab.Parent is DevExpress.XtraTab.XtraTabControl tabControl)
                {
                    tabControl.TabPages.Remove(tab);
                }
            }
        }
    }
}
