using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class KullaniciHareketleriControl : UserControl
    {
        private DataTable _hareketTablosu;

        public KullaniciHareketleriControl()
        {
            InitializeComponent();
            TabloKur();
            OrnekVerileriYukle();

            // Olayları bağla
            btnFiltrele.Click += BtnFiltrele_Click;
            
            // Grid Sütun Genişlikleri Ayarları
            if (dataGridView.Columns.Count >= 5)
            {
                dataGridView.Columns[0].Width = 80;   // Hareket ID
                dataGridView.Columns[1].Width = 140;  // Tarih / Saat
                dataGridView.Columns[2].Width = 150;  // Kullanıcı
                dataGridView.Columns[3].Width = 160;  // İşlem Türü
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Açıklama
            }
        }

        private void TabloKur()
        {
            _hareketTablosu = new DataTable();
            _hareketTablosu.Columns.Add("Hareket ID", typeof(int));
            _hareketTablosu.Columns.Add("Tarih / Saat", typeof(string));
            _hareketTablosu.Columns.Add("Kullanıcı", typeof(string));
            _hareketTablosu.Columns.Add("İşlem Türü", typeof(string));
            _hareketTablosu.Columns.Add("Açıklama", typeof(string));

            dataGridView.DataSource = _hareketTablosu;
        }

        private void OrnekVerileriYukle()
        {
            // _hareketTablosu.Rows.Add(...) sahte verileri kaldırıldı. 
            // Gelecekte gerçek veritabanından çekilecektir.
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            string secilenTur = cmbIslemTuru.SelectedItem?.ToString() ?? "Tümü";

            if (secilenTur == "Tümü" || string.IsNullOrWhiteSpace(secilenTur))
            {
                _hareketTablosu.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // İşlem Türü sütununda birebir arama yap
                _hareketTablosu.DefaultView.RowFilter = $"[İşlem Türü] = '{secilenTur}'";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                tab.TabControl.TabPages.Remove(tab);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Tools.ExportHelper.ExportToPdfOrHtml(dataGridView, "Kullanıcı Hareketleri Raporu");
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            Tools.ExportHelper.ExportToExcel(dataGridView, "KullaniciHareketleri");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            _hareketTablosu.Clear();
            OrnekVerileriYukle();
            MessageBox.Show("Liste güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
