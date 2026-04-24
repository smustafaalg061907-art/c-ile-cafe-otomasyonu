using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class UrunKayitForm : Form
    {
        public DataRow UrunBilgisi { get; private set; }
        public bool Kaydedildi { get; private set; }

        public UrunKayitForm(DataRow urun = null)
        {
            InitializeComponent();
            
            // Eğer ürün düzenleniyorsa verileri doldur
            if (urun != null)
            {
                UrunBilgisi = urun;
                VerileriEkranaBas(urun);
            }
            else
            {
                dtTarih.Value = DateTime.Now;
            }
        }

        private void VerileriEkranaBas(DataRow urun)
        {
            cmbMenu.Text       = urun["Menü"]?.ToString();
            txtUrunKodu.Text   = urun["Ürün Kodu"]?.ToString();
            txtUrunAdi.Text    = urun["Ürün Adı"]?.ToString();
            
            if (decimal.TryParse(urun["Birim Fiyat1"]?.ToString(), out decimal f1)) numFiyat1.Value = f1;
            if (decimal.TryParse(urun["Birim Fiyat2"]?.ToString(), out decimal f2)) numFiyat2.Value = f2;
            if (decimal.TryParse(urun["Birim Fiyat3"]?.ToString(), out decimal f3)) numFiyat3.Value = f3;

            txtAciklama.Text = urun["Açıklama"]?.ToString();
            
            if (DateTime.TryParse(urun["Tarih"]?.ToString(), out DateTime t))
                dtTarih.Value = t;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UrunBilgisi == null)
            {
                // Çağıran form yeni bir satır oluşturup buna atasın diye tablo kopyası falan gerekir.
                // Biz sadece özellikleri tutup formun dışından çekilmesini sağlayabiliriz.
                // Ancak DataRow referansı vermek için dışarıdan DataTable'ın NewRow() metodunu kullanabiliriz.
                // Daha basit olması için, dışarıdaki form bu formu açtığında:
                // urun = tablomuz.NewRow(); var frm = new UrunKayitForm(urun); frm.Show(); diyebiliriz.
            }

            if (UrunBilgisi != null)
            {
                UrunBilgisi["Menü"]         = cmbMenu.Text;
                UrunBilgisi["Ürün Kodu"]    = txtUrunKodu.Text;
                UrunBilgisi["Ürün Adı"]     = txtUrunAdi.Text;
                UrunBilgisi["Birim Fiyat1"] = numFiyat1.Value;
                UrunBilgisi["Birim Fiyat2"] = numFiyat2.Value;
                UrunBilgisi["Birim Fiyat3"] = numFiyat3.Value;
                UrunBilgisi["Açıklama"]     = txtAciklama.Text;
                UrunBilgisi["Tarih"]        = dtTarih.Value.ToString("dd.MM.yyyy");
                // Hızlı Satış check edilmiyor resimde, ama eklenebilir. Şimdilik false vs tutarız dışarıda.
            }

            Kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxResim.ImageLocation = ofd.FileName;
                    lblResimSecilmedi.Visible = false;
                }
            }
        }
    }
}
