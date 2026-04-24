using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class BilgilerimControl : UserControl
    {
        public BilgilerimControl()
        {
            InitializeComponent();
            KullaniciBilgileriniGetir();
        }

        private void KullaniciBilgileriniGetir()
        {
            txtKullaniciAdi.Text = Tools.KullaniciOturum.KullaniciAdi;
            txtAdSoyad.Text = Tools.KullaniciOturum.AdSoyad;
            txtTelefon.Text = Tools.KullaniciOturum.Telefon;
            txtEmail.Text = Tools.KullaniciOturum.Email;
            txtYetki.Text = Tools.KullaniciOturum.Gorevi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profil bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            KullaniciKayitForm frm = new KullaniciKayitForm();
            frm.ShowDialog();
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
