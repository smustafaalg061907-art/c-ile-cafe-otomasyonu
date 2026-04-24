using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class SatislarControl : UserControl
    {
        private DataTable _satisTablosu;

        public SatislarControl()
        {
            InitializeComponent();
            Listele();
            OzetGuncelle();
        }

        private void Listele()
        {
            try
            {
                string sorgu = @"
                    SELECT 
                        s.Id, 
                        s.SatisKodu AS [Satış Kodu], 
                        ISNULL(m.AdSoyad, 'Masadan') AS [Müşteri Ad Soyad], 
                        s.Tutar, 
                        s.Indirim AS [İndirim Toplamı], 
                        s.Odenen AS [Ödenen], 
                        s.Kalan AS [Kalan], 
                        s.Aciklama AS [Açıklama], 
                        CONVERT(VARCHAR, s.Tarih, 104) AS [Son İşlem Tarihi]
                    FROM Satislar s
                    LEFT JOIN Musteriler m ON s.MusteriId = m.Id
                    ORDER BY s.Id DESC";
                
                _satisTablosu = DAL.DatabaseHelper.GetData(sorgu);
                dataGridView.DataSource = _satisTablosu;

                if (dataGridView.Columns.Count >= 9)
                {
                    dataGridView.Columns["Id"].Width = 40;
                    dataGridView.Columns["Satış Kodu"].Width = 90;
                    dataGridView.Columns["Müşteri Ad Soyad"].Width = 160;
                    dataGridView.Columns["Tutar"].Width = 90;
                    dataGridView.Columns["İndirim Toplamı"].Width = 120;
                    dataGridView.Columns["Ödenen"].Width = 80;
                    dataGridView.Columns["Kalan"].Width = 80;
                    dataGridView.Columns["Açıklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["Son İşlem Tarihi"].Width = 120;

                    foreach (string colObj in new[] { "Tutar", "İndirim Toplamı", "Ödenen", "Kalan" })
                    {
                        if(dataGridView.Columns.Contains(colObj))
                        {
                            dataGridView.Columns[colObj].DefaultCellStyle.Format = "₺#,##0.00";
                            dataGridView.Columns[colObj].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }
                }
            }
            catch { }
        }

        // =========================================================
        // ÖZET BAR — Kayıt, Tutar, İndirim, Ödenen, Kalan
        // =========================================================
        private void OzetGuncelle()
        {
            int    kayit    = _satisTablosu.Rows.Count;
            decimal tutar   = 0, indirim = 0, odenen = 0, kalan = 0;

            foreach (DataRow row in _satisTablosu.Rows)
            {
                tutar   += Convert.ToDecimal(row["Tutar"]);
                indirim += Convert.ToDecimal(row["İndirim Toplamı"]);
                odenen  += Convert.ToDecimal(row["Ödenen"]);
                kalan   += Convert.ToDecimal(row["Kalan"]);
            }

            lblKayit.Text       = $"Kayıt: {kayit}";
            lblOzetTutar.Text   = $"Tutar=₺{tutar:N2}";
            lblOzetIndirim.Text = $"₺{indirim:N2}";
            lblOzetOdenen.Text  = $"₺{odenen:N2}";
            lblOzetKalan.Text   = $"₺{kalan:N2}";
        }

        // =========================================================
        // BUTON OLAYLARI
        // =========================================================
        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce bir satış kaydı seçiniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowView = dataGridView.CurrentRow.DataBoundItem as System.Data.DataRowView;
            if (rowView == null) return;

            System.Data.DataRow row = rowView.Row;

            string sKodu    = row["Satış Kodu"].ToString();
            string musteri  = row["Müşteri Ad Soyad"].ToString();
            string aciklama = row["Açıklama"].ToString();
            string tarih    = row["Son İşlem Tarihi"].ToString();

            using (var form = new MasaSiparisleriForm(sKodu, musteri, aciklama, tarih))
                form.ShowDialog(this.ParentForm);
        }

        private void btnOdemeHareketleri_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            string sKodu = dataGridView.CurrentRow.Cells["Satış Kodu"].Value?.ToString() ?? "";
            MessageBox.Show($"{sKodu} ödeme hareketleri gösterilecek.", "Ödeme Hareketleri",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYenileListele_Click(object sender, EventArgs e)
        {
            Listele();
            OzetGuncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                tab.TabControl.TabPages.Remove(tab);
            }
        }
    }
}
