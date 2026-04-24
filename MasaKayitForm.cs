using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MasaKayitForm : Form
    {
        public string MasaAdi { get; private set; }
        public string Aciklama { get; private set; }
        public bool Kaydedildi { get; private set; }

        public MasaKayitForm(string mAdi = "", string mAciklama = "")
        {
            InitializeComponent();
            txtMasaAdi.Text = mAdi;
            txtAciklama.Text = mAciklama;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasaAdi.Text))
            {
                MessageBox.Show("Masa adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MasaAdi = txtMasaAdi.Text;
            Aciklama = txtAciklama.Text;
            Kaydedildi = true;

            this.Close();
        }
    }
}
