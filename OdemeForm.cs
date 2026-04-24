using System;
using System.Windows.Forms;
using System.Drawing;

namespace CafeOtomasyonu
{
    /// <summary>
    /// Nakit Ödeme veya Kredi Kartı ile Ödeme formu.
    /// baslik parametresiyle başlık değişir.
    /// </summary>
    public partial class OdemeForm : Form
    {
        private readonly decimal _odenecekTutar;

        public decimal OdenenTutar { get; private set; }
        public string  Aciklama    { get; private set; }
        public string  SelectedTarih { get; private set; }

        public OdemeForm(string baslik, decimal odenecekTutar)
        {
            InitializeComponent();
            _odenecekTutar      = odenecekTutar;
            lblOdemeBaslik.Text = baslik;
            txtTutar.Text       = odenecekTutar.ToString("N2");
            dtpTarih.Value      = DateTime.Now;
            
            txtTutar.TextChanged += TxtTutar_TextChanged;
            KalanTutarGuncelle();
        }

        private void TxtTutar_TextChanged(object sender, EventArgs e)
        {
            KalanTutarGuncelle();
        }

        private void KalanTutarGuncelle()
        {
            string ham = txtTutar.Text.Trim().Replace("₺", "").Replace(" ", "");
            decimal girilenTutar = 0;
            decimal.TryParse(ham,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture, out girilenTutar);
            if (girilenTutar == 0)
                decimal.TryParse(ham,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out girilenTutar);

            decimal kalan = _odenecekTutar - girilenTutar;
            lblKalan.Text      = "Kalan: ₺" + kalan.ToString("N2");
            lblKalan.ForeColor = (kalan <= 0)
                ? System.Drawing.Color.FromArgb(40, 167, 69)   // yeşil — tamam
                : System.Drawing.Color.FromArgb(220, 53, 69);  // kırmızı — eksik
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği (veya değiştirdiği) tutarı oku
            string ham = txtTutar.Text.Trim()
                .Replace("₺", "")
                .Replace(" ", "");

            if (!decimal.TryParse(ham,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.CurrentCulture, out decimal tutar)
                && !decimal.TryParse(ham,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out tutar))
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutar.Focus();
                return;
            }

            OdenenTutar   = tutar;
            Aciklama      = txtAciklama.Text.Trim();
            SelectedTarih = dtpTarih.Value.ToShortDateString();

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
