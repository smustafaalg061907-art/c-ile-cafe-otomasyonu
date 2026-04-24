using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class PaketSiparisiControl : UserControl
    {
        private DataTable _siparislerTablosu;

        public PaketSiparisiControl()
        {
            InitializeComponent();
        }

        private void PaketSiparisiControl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            if (_siparislerTablosu == null)
            {
                _siparislerTablosu = new DataTable();
                _siparislerTablosu.Columns.Add("Id", typeof(int));
                _siparislerTablosu.Columns.Add("SiparisNo", typeof(string));
                _siparislerTablosu.Columns.Add("Musteri", typeof(string));
                _siparislerTablosu.Columns.Add("Telefon", typeof(string));
                _siparislerTablosu.Columns.Add("Adres", typeof(string));
                _siparislerTablosu.Columns.Add("Tutar", typeof(decimal));
                _siparislerTablosu.Columns.Add("Durum", typeof(string));
                _siparislerTablosu.Columns.Add("Tarih", typeof(DateTime));
            }

            dataGridView.DataSource = _siparislerTablosu;

            // Görünüm Ayarları
            dataGridView.Columns["Id"].Visible = false;
            
            dataGridView.Columns["SiparisNo"].HeaderText = "Sipariş No";
            dataGridView.Columns["SiparisNo"].Width = 100;

            dataGridView.Columns["Musteri"].HeaderText = "Müşteri Adı";
            dataGridView.Columns["Musteri"].Width = 150;

            dataGridView.Columns["Telefon"].HeaderText = "Telefon";
            dataGridView.Columns["Telefon"].Width = 120;

            dataGridView.Columns["Adres"].HeaderText = "Teslimat Adresi";
            dataGridView.Columns["Adres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Columns["Tutar"].HeaderText = "Tutar (₺)";
            dataGridView.Columns["Tutar"].Width = 120;
            dataGridView.Columns["Tutar"].DefaultCellStyle.Format = "C2";

            dataGridView.Columns["Durum"].HeaderText = "Sipariş Durumu";
            dataGridView.Columns["Durum"].Width = 150;

            dataGridView.Columns["Tarih"].HeaderText = "Sipariş Zamanı";
            dataGridView.Columns["Tarih"].Width = 140;
            dataGridView.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            YeniPaketSiparisiForm frm = new YeniPaketSiparisiForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int newId = _siparislerTablosu.Rows.Count > 0 ? Convert.ToInt32(_siparislerTablosu.Compute("max([Id])", string.Empty)) + 1 : 1;
                string newOrderNo = "PKT-" + newId.ToString("000");

                _siparislerTablosu.Rows.Add(newId, newOrderNo, frm.MusteriAdi, frm.Telefon, frm.Adres, frm.Tutar, "Yeni Sipariş", DateTime.Now);
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView.CurrentRow;
                string siparisNo = row.Cells["SiparisNo"].Value.ToString();
                string guncelDurum = row.Cells["Durum"].Value.ToString();
                
                PaketDurumDegistirForm frm = new PaketDurumDegistirForm();
                frm.SiparisNo = siparisNo;
                frm.MevcutDurum = guncelDurum;
                
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    row.Cells["Durum"].Value = frm.YeniDurum;
                }
            }
            else
            {
                MessageBox.Show("Lütfen durumunu değiştirmek istediğiniz siparişi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            Listele();
            MessageBox.Show("Paket siparişleri listesi başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                string siparisNo = dataGridView.CurrentRow.Cells["SiparisNo"].Value.ToString();
                DialogResult dr = MessageBox.Show($"{siparisNo} numaralı siparişi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dataGridView.Rows.Remove(dataGridView.CurrentRow);
                    MessageBox.Show("Paket siparişi iptal edildi/silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz siparişi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                if (tab.Parent is DevExpress.XtraTab.XtraTabControl tabControl)
                {
                    tabControl.TabPages.Remove(tab);
                }
            }
        }
    }
}
