using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Günün Cirosu
                string qGununCirosu = "SELECT ISNULL(SUM(OdenenMiktar), 0) FROM Odemeler WHERE CAST(Tarih AS DATE) = CAST(GETDATE() AS DATE)";
                decimal gununCirosu = Convert.ToDecimal(DAL.DatabaseHelper.GetData(qGununCirosu).Rows[0][0]);
                lblGununCirosu.Text = gununCirosu.ToString("C2");

                // 2. Haftalık Ciro
                string qHaftalik = "SELECT ISNULL(SUM(OdenenMiktar), 0) FROM Odemeler WHERE Tarih >= DATEADD(day, -7, GETDATE())";
                decimal haftalikCiro = Convert.ToDecimal(DAL.DatabaseHelper.GetData(qHaftalik).Rows[0][0]);
                lblHaftalikCiro.Text = haftalikCiro.ToString("C2");

                // 3. Aylık Ciro
                string qAylik = "SELECT ISNULL(SUM(OdenenMiktar), 0) FROM Odemeler WHERE MONTH(Tarih) = MONTH(GETDATE()) AND YEAR(Tarih) = YEAR(GETDATE())";
                decimal aylikCiro = Convert.ToDecimal(DAL.DatabaseHelper.GetData(qAylik).Rows[0][0]);
                lblAylikCiro.Text = aylikCiro.ToString("C2");

                // 4. Toplam Kasa (Tüm Zamanlar)
                string qToplam = "SELECT ISNULL(SUM(OdenenMiktar), 0) FROM Odemeler";
                decimal toplamKasa = Convert.ToDecimal(DAL.DatabaseHelper.GetData(qToplam).Rows[0][0]);
                lblToplamKasa.Text = toplamKasa.ToString("C2");

                // 5. Aktif / Toplam Masalar
                string qAktifMasa = "SELECT COUNT(*) FROM Masalar WHERE Durum = 1";
                string qToplamMasa = "SELECT COUNT(*) FROM Masalar";
                int aktifMasa = Convert.ToInt32(DAL.DatabaseHelper.GetData(qAktifMasa).Rows[0][0]);
                int toplamMasa = Convert.ToInt32(DAL.DatabaseHelper.GetData(qToplamMasa).Rows[0][0]);
                lblAktifMasalar.Text = $"{aktifMasa} / {toplamMasa}";

                // 6. Bekleyen Paket Siparişler
                string qPaket = "SELECT COUNT(*) FROM Satislar WHERE MasaId IS NULL AND Durum = 'Açık'";
                int paketSayisi = Convert.ToInt32(DAL.DatabaseHelper.GetData(qPaket).Rows[0][0]);
                lblPaketSiparisler.Text = paketSayisi.ToString();

                // 7. Toplam Müşteriler
                string qMusteri = "SELECT COUNT(*) FROM Musteriler";
                int musteriSayisi = Convert.ToInt32(DAL.DatabaseHelper.GetData(qMusteri).Rows[0][0]);
                lblToplamMusteri.Text = musteriSayisi.ToString("N0");

                // 8. Bugün Satılan Ürün Adedi
                string qUrun = @"
                    SELECT ISNULL(SUM(sd.Miktar), 0) 
                    FROM SatisDetaylari sd 
                    INNER JOIN Satislar s ON sd.SatisId = s.Id 
                    WHERE CAST(s.Tarih AS DATE) = CAST(GETDATE() AS DATE)";
                int satilanUrun = Convert.ToInt32(DAL.DatabaseHelper.GetData(qUrun).Rows[0][0]);
                lblSatilanUrun.Text = $"{satilanUrun} Adet";
            }
            catch (Exception)
            {
                // Varsayılan kalabilir eğer ilk açılışta tablolar yoksa
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
