using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtParola.Text))
            {
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@K AND Parola=@P AND AktifMi=1";
            var dt = DAL.DatabaseHelper.GetData(query, 
                new System.Data.SqlClient.SqlParameter("@K", txtKullaniciAdi.Text),
                new System.Data.SqlClient.SqlParameter("@P", txtParola.Text));

            if (dt.Rows.Count > 0)
            {
                Tools.KullaniciOturum.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                Tools.KullaniciOturum.AdSoyad = dt.Rows[0]["AdSoyad"].ToString();
                Tools.KullaniciOturum.KullaniciAdi = dt.Rows[0]["KullaniciAdi"].ToString();
                Tools.KullaniciOturum.Gorevi = dt.Rows[0]["Gorevi"].ToString();
                Tools.KullaniciOturum.Email = dt.Rows[0]["Email"].ToString();
                Tools.KullaniciOturum.Telefon = dt.Rows[0]["Telefon"].ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!\n(Ya da hesabınız pasif durumda olabilir)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new KullaniciKayitForm();
            frm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            var frm = new SifreSifirlaForm();
            frm.ShowDialog();
        }

        private void lblIslemler_Click(object sender, EventArgs e)
        {

        }
    }
}
