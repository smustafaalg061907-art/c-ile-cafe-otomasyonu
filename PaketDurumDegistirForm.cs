using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class PaketDurumDegistirForm : Form
    {
        public string SiparisNo { get; set; }
        public string MevcutDurum { get; set; }
        
        public string YeniDurum { get; private set; }

        public PaketDurumDegistirForm()
        {
            InitializeComponent();
        }

        private void PaketDurumDegistirForm_Load(object sender, EventArgs e)
        {
            lblSiparisNo.Text = SiparisNo;
            
            // Popülasyon
            cmbDurum.Items.Add("Yeni Sipariş");
            cmbDurum.Items.Add("Hazırlanıyor");
            cmbDurum.Items.Add("Yolda");
            cmbDurum.Items.Add("Teslim Edildi");
            cmbDurum.Items.Add("İptal Edildi");
            
            if(cmbDurum.Items.Contains(MevcutDurum))
                cmbDurum.SelectedItem = MevcutDurum;
            else
                cmbDurum.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir durum seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            YeniDurum = cmbDurum.SelectedItem.ToString();
            
            MessageBox.Show($"Sipariş durumu '{YeniDurum}' olarak güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
