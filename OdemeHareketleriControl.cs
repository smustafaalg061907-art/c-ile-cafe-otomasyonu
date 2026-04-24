using System;
using System.Data;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class OdemeHareketleriControl : UserControl
    {
        public OdemeHareketleriControl()
        {
            InitializeComponent();
        }

        private void OdemeHareketleriControl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                string sorgu = @"
                    SELECT 
                        o.Id, 
                        s.SatisKodu, 
                        o.OdemeTuru, 
                        o.OdenenMiktar AS OdenenMiktar, 
                        o.Tarih, 
                        'Admin' AS Kullanici, 
                        o.Aciklama 
                    FROM Odemeler o 
                    INNER JOIN Satislar s ON o.SatisId = s.Id 
                    ORDER BY o.Id DESC";
                    
                DataTable dt = DAL.DatabaseHelper.GetData(sorgu);
                dataGridView.DataSource = dt;

                if (dataGridView.Columns.Count >= 7)
                {
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["SatisKodu"].HeaderText = "Satış Kodu";
                    dataGridView.Columns["SatisKodu"].Width = 120;
                    dataGridView.Columns["OdemeTuru"].HeaderText = "Ödeme Türü";
                    dataGridView.Columns["OdemeTuru"].Width = 150;
                    dataGridView.Columns["OdenenMiktar"].HeaderText = "Ödenen Miktar (₺)";
                    dataGridView.Columns["OdenenMiktar"].Width = 150;
                    dataGridView.Columns["OdenenMiktar"].DefaultCellStyle.Format = "C2";
                    dataGridView.Columns["Tarih"].HeaderText = "İşlem Tarihi";
                    dataGridView.Columns["Tarih"].Width = 150;
                    dataGridView.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                    dataGridView.Columns["Kullanici"].HeaderText = "İşlemi Yapan";
                    dataGridView.Columns["Kullanici"].Width = 150;
                    dataGridView.Columns["Aciklama"].HeaderText = "Açıklama";
                    dataGridView.Columns["Aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                SatisDetayiForm frm = new SatisDetayiForm();
                
                frm.SatisKodu = dataGridView.CurrentRow.Cells["SatisKodu"].Value?.ToString();
                frm.OdemeTuru = dataGridView.CurrentRow.Cells["OdemeTuru"].Value?.ToString();
                
                if (decimal.TryParse(dataGridView.CurrentRow.Cells["OdenenMiktar"].Value?.ToString(), out decimal miktar))
                    frm.OdenenMiktar = miktar;
                    
                if (DateTime.TryParse(dataGridView.CurrentRow.Cells["Tarih"].Value?.ToString(), out DateTime tarih))
                    frm.Tarih = tarih;
                    
                frm.Kullanici = dataGridView.CurrentRow.Cells["Kullanici"].Value?.ToString();
                frm.Aciklama = dataGridView.CurrentRow.Cells["Aciklama"].Value?.ToString();

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz ödeme hareketini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                Tools.ExportHelper.ExportToPdfOrHtml(dataGridView, "Ödeme Fişi " + dataGridView.CurrentRow.Cells["SatisKodu"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen yazdırmak istediğiniz ödeme hareketini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            Listele();
            MessageBox.Show("Ödeme hareketleri listesi başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int odemeId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                string satisKodu = dataGridView.CurrentRow.Cells["SatisKodu"].Value.ToString();
                DialogResult dr = MessageBox.Show($"{satisKodu} kodlu satısa ait ödeme hareketini silmek istediğinize emin misiniz?\n\nUyarı: Bu işlem muhasebe kayıtlarını etkileyebilir!", "Kritik Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DAL.DatabaseHelper.ExecuteCommand("DELETE FROM Odemeler WHERE Id=@Id", new System.Data.SqlClient.SqlParameter("@Id", odemeId));
                    MessageBox.Show("Ödeme hareketi sistemden silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ödeme hareketini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
