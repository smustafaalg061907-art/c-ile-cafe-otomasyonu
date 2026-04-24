using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class SatisDetayiForm : Form
    {
        public string SatisKodu { get; set; }
        public string OdemeTuru { get; set; }
        public decimal OdenenMiktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
        public string Aciklama { get; set; }

        public SatisDetayiForm()
        {
            InitializeComponent();
        }

        private void SatisDetayiForm_Load(object sender, EventArgs e)
        {
            lblSatisKodu.Text = SatisKodu;
            lblOdemeTuru.Text = OdemeTuru;
            lblMiktar.Text = OdenenMiktar.ToString("C2");
            lblTarih.Text = Tarih.ToString("dd.MM.yyyy HH:mm");
            lblKullanici.Text = Kullanici;
            txtAciklama.Text = Aciklama;

            DetayListele();
        }

        private void DetayListele()
        {
            // Dummy Data For Sale Details
            DataTable dt = new DataTable();
            dt.Columns.Add("UrunAdi", typeof(string));
            dt.Columns.Add("Miktar", typeof(int));
            dt.Columns.Add("BirimFiyati", typeof(decimal));
            dt.Columns.Add("Toplam", typeof(decimal));

            // Generate some random random dummy products based on SaleCode length logic just for diversity
            int genValue = SatisKodu.Length > 0 ? (int)SatisKodu[SatisKodu.Length-1] : 5;
            
            if(genValue % 2 == 0) 
            {
                dt.Rows.Add("Filtre Kahve", 2, 80.00m, 160.00m);
                dt.Rows.Add("Cheesecake", 1, 150.00m, 150.00m);
            }
            else 
            {
                dt.Rows.Add("Çay", 4, 25.00m, 100.00m);
                dt.Rows.Add("Su", 2, 10.00m, 20.00m);
                dt.Rows.Add("Tost", 1, 90.00m, 90.00m);
            }

            dataGridViewUrunler.DataSource = dt;
            
            dataGridViewUrunler.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            dataGridViewUrunler.Columns["UrunAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridViewUrunler.Columns["Miktar"].HeaderText = "Miktar";
            dataGridViewUrunler.Columns["Miktar"].Width = 80;
            
            dataGridViewUrunler.Columns["BirimFiyati"].HeaderText = "Birim Fiyatı";
            dataGridViewUrunler.Columns["BirimFiyati"].Width = 100;
            dataGridViewUrunler.Columns["BirimFiyati"].DefaultCellStyle.Format = "C2";
            
            dataGridViewUrunler.Columns["Toplam"].HeaderText = "Toplam";
            dataGridViewUrunler.Columns["Toplam"].Width = 100;
            dataGridViewUrunler.Columns["Toplam"].DefaultCellStyle.Format = "C2";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
