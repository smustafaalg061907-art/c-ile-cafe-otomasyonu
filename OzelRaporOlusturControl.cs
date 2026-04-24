using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class OzelRaporOlusturControl : UserControl
    {
        public OzelRaporOlusturControl()
        {
            InitializeComponent();
        }

        private void OzelRaporOlusturControl_Load(object sender, EventArgs e)
        {
            // Initial load ops can go here
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            if (cmbRaporTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir rapor türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtBaslangic.Value.Date > dtBitis.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string secilenRapor = cmbRaporTuru.SelectedItem.ToString();
            
            DataTable dt = new DataTable();
            
            if (secilenRapor == "Günlük Satış Özeti")
            {
                dt.Columns.Add("Tarih", typeof(DateTime));
                dt.Columns.Add("SatisKodu", typeof(string));
                dt.Columns.Add("MusteriSiparis", typeof(string));
                dt.Columns.Add("Tutar", typeof(decimal));
                // Gerçek veriler veritabanından çekilecektir
            }
            else if (secilenRapor == "Personel Satış Performansı")
            {
                dt.Columns.Add("Personel", typeof(string));
                dt.Columns.Add("IslemSayisi", typeof(int));
                dt.Columns.Add("ToplamCiro", typeof(decimal));
                // Gerçek veriler veritabanından çekilecektir
            }
            else
            {
                dt.Columns.Add("Kategori", typeof(string));
                dt.Columns.Add("Adet", typeof(int));
                dt.Columns.Add("Toplam", typeof(decimal));
                // Gerçek veriler veritabanından çekilecektir
            }

            dataGridView.DataSource = dt;

            // Formats based on columns
            if (dataGridView.Columns.Contains("Tutar")) dataGridView.Columns["Tutar"].DefaultCellStyle.Format = "C2";
            if (dataGridView.Columns.Contains("ToplamCiro")) dataGridView.Columns["ToplamCiro"].DefaultCellStyle.Format = "C2";
            if (dataGridView.Columns.Contains("Toplam")) dataGridView.Columns["Toplam"].DefaultCellStyle.Format = "C2";
            if (dataGridView.Columns.Contains("Tarih")) dataGridView.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MessageBox.Show($"{secilenRapor} başarıyla oluşturuldu.", "Rapor Hazır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) 
            {
                MessageBox.Show("Dışa aktarılacak veri bulunamadı. Lütfen önce sorguyu çalıştırın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tools.ExportHelper.ExportToExcel(dataGridView, "OzelRapor");
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) 
            {
                MessageBox.Show("Dışa aktarılacak veri bulunamadı. Lütfen önce sorguyu çalıştırın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tools.ExportHelper.ExportToPdfOrHtml(dataGridView, "Özel Sistem Raporu");
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
