using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class KullaniciKayitForm : Form
    {
        private int _kullaniciId = 0;

        public KullaniciKayitForm()
        {
            InitializeComponent();
            lblBaslik.Text = "Yeni Kullanıcı Kayıt Sayfası";
        }

        public KullaniciKayitForm(int id, string adSoyad, string telefon, string adres, string email, string gorevi, string kullaniciAdi, bool aktifMi, string soru, string cevap, string aciklama)
        {
            InitializeComponent();

            _kullaniciId = id;
            lblBaslik.Text = $"{kullaniciAdi} Bilgileri Sayfası";

            txtAdSoyad.Text = adSoyad;
            txtTelefon.Text = telefon;
            txtAdres.Text = adres;
            txtEmail.Text = email;
            txtGorevi.Text = gorevi;
            txtKullaniciAdi.Text = kullaniciAdi;
            toggleDurum.IsOn = aktifMi;
            txtSoru.Text = soru;
            txtCevap.Text = cevap;
            txtAciklama.Text = aciklama;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtParola.Text) && txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Parolalar birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_kullaniciId == 0)
            {
                if (string.IsNullOrEmpty(txtParola.Text))
                {
                    MessageBox.Show("Yeni kayıt için parola girmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sorgu = @"INSERT INTO Kullanicilar (AdSoyad, Telefon, Adres, Email, Gorevi, KullaniciAdi, Parola, AktifMi, Soru, Cevap, Aciklama) 
                                 VALUES (@A, @T, @Ad, @E, @G, @K, @P, @Aktif, @Soru, @Cevap, @Aciklama)";
                DAL.DatabaseHelper.ExecuteCommand(sorgu,
                    new System.Data.SqlClient.SqlParameter("@A", txtAdSoyad.Text),
                    new System.Data.SqlClient.SqlParameter("@T", txtTelefon.Text),
                    new System.Data.SqlClient.SqlParameter("@Ad", txtAdres.Text),
                    new System.Data.SqlClient.SqlParameter("@E", txtEmail.Text),
                    new System.Data.SqlClient.SqlParameter("@G", txtGorevi.Text),
                    new System.Data.SqlClient.SqlParameter("@K", txtKullaniciAdi.Text),
                    new System.Data.SqlClient.SqlParameter("@P", txtParola.Text),
                    new System.Data.SqlClient.SqlParameter("@Aktif", toggleDurum.IsOn),
                    new System.Data.SqlClient.SqlParameter("@Soru", txtSoru.Text),
                    new System.Data.SqlClient.SqlParameter("@Cevap", txtCevap.Text),
                    new System.Data.SqlClient.SqlParameter("@Aciklama", txtAciklama.Text));
            }
            else
            {
                string sorgu = @"UPDATE Kullanicilar SET AdSoyad=@A, Telefon=@T, Adres=@Ad, Email=@E, Gorevi=@G, KullaniciAdi=@K, AktifMi=@Aktif, Soru=@Soru, Cevap=@Cevap, Aciklama=@Aciklama ";
                if (!string.IsNullOrEmpty(txtParola.Text))
                    sorgu += ", Parola=@P ";
                sorgu += "WHERE Id=@Id";

                var parms = new System.Collections.Generic.List<System.Data.SqlClient.SqlParameter>
                {
                    new System.Data.SqlClient.SqlParameter("@A", txtAdSoyad.Text),
                    new System.Data.SqlClient.SqlParameter("@T", txtTelefon.Text),
                    new System.Data.SqlClient.SqlParameter("@Ad", txtAdres.Text),
                    new System.Data.SqlClient.SqlParameter("@E", txtEmail.Text),
                    new System.Data.SqlClient.SqlParameter("@G", txtGorevi.Text),
                    new System.Data.SqlClient.SqlParameter("@K", txtKullaniciAdi.Text),
                    new System.Data.SqlClient.SqlParameter("@Aktif", toggleDurum.IsOn),
                    new System.Data.SqlClient.SqlParameter("@Soru", txtSoru.Text),
                    new System.Data.SqlClient.SqlParameter("@Cevap", txtCevap.Text),
                    new System.Data.SqlClient.SqlParameter("@Aciklama", txtAciklama.Text),
                    new System.Data.SqlClient.SqlParameter("@Id", _kullaniciId)
                };
                if (!string.IsNullOrEmpty(txtParola.Text))
                    parms.Add(new System.Data.SqlClient.SqlParameter("@P", txtParola.Text));

                DAL.DatabaseHelper.ExecuteCommand(sorgu, parms.ToArray());
            }

            MessageBox.Show("Kullanıcı bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
