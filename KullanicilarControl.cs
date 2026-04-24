using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class KullanicilarControl : UserControl
    {
        private DataTable _kullaniciTablosu;

        public KullanicilarControl()
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
                        AdSoyad AS [Ad Soyad], 
                        Telefon, 
                        Adres, 
                        Email, 
                        Gorevi AS [Görevi], 
                        KullaniciAdi AS [Kullanıcı Adı], 
                        Soru,
                        Cevap,
                        Aciklama AS [Açıklama],
                        CONVERT(VARCHAR, EklenmeTarihi, 104) AS [Kayıt Tarihi], 
                        AktifMi AS [Aktif Mi], 
                        CAST(1 AS BIT) AS [Admin Mi?] 
                    FROM Kullanicilar 
                    ORDER BY Id ASC";
                    
                _kullaniciTablosu = DAL.DatabaseHelper.GetData(sorgu);
                dataGridView.DataSource = _kullaniciTablosu;

                if (dataGridView.Columns.Count >= 10)
                {
                    dataGridView.Columns["Id"].Width = 40;
                    dataGridView.Columns["Ad Soyad"].Width = 150;
                    dataGridView.Columns["Telefon"].Width = 100;
                    dataGridView.Columns["Adres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["Görevi"].Width = 120;
                    dataGridView.Columns["Kullanıcı Adı"].Width = 100;
                    dataGridView.Columns["Soru"].Visible = false;      // Detay alanları gizleyelim
                    dataGridView.Columns["Cevap"].Visible = false;     // Detay alanları gizleyelim
                    dataGridView.Columns["Açıklama"].Visible = false;  // Detay alanları gizleyelim
                    dataGridView.Columns["Kayıt Tarihi"].Width = 100;
                    dataGridView.Columns["Aktif Mi"].Width = 70;
                    dataGridView.Columns["Admin Mi?"].Width = 70;
                }
            }
            catch { }
        }

        // =========================================================
        // BUTON OLAYLARI
        // =========================================================
        private void btnYeni_Click(object sender, EventArgs e)
        {
            var frm = new KullaniciKayitForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen öncelikle bir kullanıcı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var secili = dataGridView.CurrentRow;
            int id = Convert.ToInt32(secili.Cells["Id"].Value ?? 0);
            string adSoyad = secili.Cells["Ad Soyad"].Value?.ToString() ?? "";
            string telefon = secili.Cells["Telefon"].Value?.ToString() ?? "";
            string adres = secili.Cells["Adres"].Value?.ToString() ?? "";
            string email = secili.Cells["Email"].Value?.ToString() ?? "";
            string gorevi = secili.Cells["Görevi"].Value?.ToString() ?? "";
            string kullaniciAdi = secili.Cells["Kullanıcı Adı"].Value?.ToString() ?? "";
            bool aktifMi = Convert.ToBoolean(secili.Cells["Aktif Mi"].Value ?? false);
            string soru = secili.Cells["Soru"].Value?.ToString() ?? "";
            string cevap = secili.Cells["Cevap"].Value?.ToString() ?? "";
            string aciklama = secili.Cells["Açıklama"].Value?.ToString() ?? "";

            var frm = new KullaniciKayitForm(id, adSoyad, telefon, adres, email, gorevi, kullaniciAdi, aktifMi, soru, cevap, aciklama);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Listele();
            }
        }

        private void btnRoller_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce bir kullanıcı seçiniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = dataGridView.CurrentRow.Cells["Kullanıcı Adı"].Value?.ToString() ?? "";
            MessageBox.Show($"{kullaniciAdi} kullanıcısının rolleri düzenlenecek.", "Roller",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tüm kayıtlar canlı olarak veritabanına işlenmektedir.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                tab.TabControl.TabPages.Remove(tab);
            }
        }
    }
}
