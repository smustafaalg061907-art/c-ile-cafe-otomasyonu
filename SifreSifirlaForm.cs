using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class SifreSifirlaForm : Form
    {
        public SifreSifirlaForm()
        {
            InitializeComponent();
        }

        private void btnSifreyiSifirla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifreGirisKullanici.Text) || 
                string.IsNullOrWhiteSpace(txtYeniSifre.Text) || 
                string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Girdiğiniz yeni şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Sistemdeki şifreniz başarıyla sıfırlandı. Yeni şifrenizle giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
