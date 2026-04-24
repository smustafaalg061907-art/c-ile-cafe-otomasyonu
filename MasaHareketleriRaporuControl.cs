using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MasaHareketleriRaporuControl : UserControl
    {
        public MasaHareketleriRaporuControl()
        {
            InitializeComponent();
        }

        private void MasaHareketleriRaporuControl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            // Dummy Data
            DataTable dt = new DataTable();
            dt.Columns.Add("IslemId", typeof(string));
            dt.Columns.Add("MasaAdi", typeof(string));
            dt.Columns.Add("IslemTipi", typeof(string));
            dt.Columns.Add("IslemTutari", typeof(decimal));
            dt.Columns.Add("Kullanici", typeof(string));
            dt.Columns.Add("AcilisZamani", typeof(DateTime));
            dt.Columns.Add("KapanisZamani", typeof(DateTime));
            dt.Columns.Add("FarkSaniye", typeof(int));

            // Gerçek veriler veritabanından çekilecektir
            dataGridView.DataSource = dt;

            // Görünüm Ayarları
            dataGridView.Columns["IslemId"].HeaderText = "Kayıt No";
            dataGridView.Columns["IslemId"].Width = 100;

            dataGridView.Columns["MasaAdi"].HeaderText = "Masa Adı";
            dataGridView.Columns["MasaAdi"].Width = 120;

            dataGridView.Columns["IslemTipi"].HeaderText = "Hareket Türü";
            dataGridView.Columns["IslemTipi"].Width = 140;

            dataGridView.Columns["IslemTutari"].HeaderText = "Tutar (₺)";
            dataGridView.Columns["IslemTutari"].Width = 100;
            dataGridView.Columns["IslemTutari"].DefaultCellStyle.Format = "C2";

            dataGridView.Columns["Kullanici"].HeaderText = "Personel";
            dataGridView.Columns["Kullanici"].Width = 130;

            dataGridView.Columns["AcilisZamani"].HeaderText = "Açılış Zamanı";
            dataGridView.Columns["AcilisZamani"].Width = 140;
            dataGridView.Columns["AcilisZamani"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

            dataGridView.Columns["KapanisZamani"].HeaderText = "İşlem Bitiş";
            dataGridView.Columns["KapanisZamani"].Width = 140;
            dataGridView.Columns["KapanisZamani"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

            dataGridView.Columns["FarkSaniye"].HeaderText = "Oturma Süresi (Sn)";
            dataGridView.Columns["FarkSaniye"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            Tools.ExportHelper.ExportToExcel(dataGridView, "MasaHareketleriRaporu");
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
            Tools.ExportHelper.ExportToPdfOrHtml(dataGridView, "Masa Hareketleri Detaylı Raporu");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            Listele();
            MessageBox.Show("Rapor listesi başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
