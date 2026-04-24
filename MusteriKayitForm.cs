using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MusteriKayitForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        
        // Formdan okunan yeni veya güncellenen veriler
        public string MusteriAdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }

        public MusteriKayitForm()
        {
            InitializeComponent();
        }

        private void MusteriKayitForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                lblBaslik.Text = "Müşteri Düzenle";
                btnKaydet.Text = "💾 Güncelle";
                
                // Müşteri adı varsa TextBox'a yazdırılıyor (Düzenleme Modu)
                if (!string.IsNullOrEmpty(MusteriAdSoyad))
                {
                    txtAdSoyad.Text = MusteriAdSoyad;
                    txtTelefon.Text = Telefon; 
                    txtEmail.Text = Email;
                    txtAdres.Text = Adres;
                    txtAciklama.Text = Aciklama;
                }
            }
            else
            {
                lblBaslik.Text = "Yeni Müşteri Ekle";
                btnKaydet.Text = "💾 Kaydet";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || !txtTelefon.MaskCompleted)
            {
                MessageBox.Show("Lütfen Ad Soyad ve geçerli bir Telefon alanı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gelişmiş veri aktarımı
            MusteriAdSoyad = txtAdSoyad.Text;
            Telefon = txtTelefon.Text;
            Email = txtEmail.Text;
            Adres = txtAdres.Text;
            Aciklama = txtAciklama.Text;

            string islemTuru = IsEditMode ? "güncellendi" : "kaydedildi";
            MessageBox.Show($"Müşteri başarıyla {islemTuru}.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK; // Panele başarılı haberi gönder
            this.Close();
        }
    }
}
