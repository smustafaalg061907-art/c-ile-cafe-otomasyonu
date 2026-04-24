using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MasaSiparisleriForm : Form
    {
        private string _masaAdi;
        private DataTable _siparisTablosu;
        private DataTable _odemelerTablosu;

        private int _masaId = 0;
        private int _satisId = 0;

        // ---- Normal constructor (Masa Durumları'ndan açılırken) ----
        public MasaSiparisleriForm(string masaAdi)
        {
            _masaAdi = masaAdi;
            OrtakBaslat();
            lblBaslik.Text = masaAdi + " Siparişleri";

            try
            {
                // Masayı Öğren
                _masaId = Convert.ToInt32(DAL.DatabaseHelper.GetData("SELECT Id FROM Masalar WHERE MasaAdi=@Ad",
                    new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Ad", masaAdi) }).Rows[0][0]);

                // Açık bir satış var mı?
                var dtSatis = DAL.DatabaseHelper.GetData("SELECT Id FROM Satislar WHERE MasaId=@MId AND Durum='Açık'",
                    new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@MId", _masaId) });

                if (dtSatis.Rows.Count > 0)
                {
                    _satisId = Convert.ToInt32(dtSatis.Rows[0][0]);
                }
                else
                {
                    // Yoksa oluştur
                    string sKodu = "S" + DateTime.Now.ToString("yyMMddHHmmss");
                    _satisId = DAL.DatabaseHelper.ExecuteScalar("INSERT INTO Satislar (MasaId, SatisKodu, Durum, Tutar) OUTPUT INSERTED.Id VALUES (@MId, @Kodu, 'Açık', 0)",
                        new System.Data.SqlClient.SqlParameter("@MId", _masaId),
                        new System.Data.SqlClient.SqlParameter("@Kodu", sKodu));
                }
            }
            catch { }

            SiparisleriYukle();
        }

        // ---- Satışlar'dan Sipariş Detayları ile açılırken ----
        public MasaSiparisleriForm(string satisKodu, string musteri, string aciklama, string tarih)
        {
            _masaAdi = satisKodu;
            OrtakBaslat();
            lblBaslik.Text   = satisKodu + " - Sipariş Detayları";
            cmbMusteri.Text  = musteri;
            txtAciklama.Text = aciklama;

            if (DateTime.TryParseExact(tarih, "dd.MM.yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime dt))
                dtpTarih.Value = dt;

            try
            {
                var dtSatis = DAL.DatabaseHelper.GetData("SELECT Id FROM Satislar WHERE SatisKodu=@Kod",
                    new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Kod", satisKodu) });
                if (dtSatis.Rows.Count > 0) _satisId = Convert.ToInt32(dtSatis.Rows[0][0]);
            }
            catch { }

            SiparisleriYukle();
        }

        private void OrtakBaslat()
        {
            InitializeComponent();
            this.Text      = "Masa Siparişleri";
            dtpTarih.Value = DateTime.Now;
        }

        private void SiparisleriYukle()
        {
            if (_satisId == 0) return;

            string qDetay = @"SELECT d.Id, u.UrunAdi AS [Ürün Adı], d.Miktar AS [Miktarı], d.BirimFiyati AS [Birim Fiyatı], 
                              d.Indirim AS [İndirim Tutarı], d.Tutar, d.Aciklama AS [Açıklama], s.Tarih 
                              FROM SatisDetaylari d JOIN Urunler u ON d.UrunId = u.Id JOIN Satislar s ON d.SatisId = s.Id 
                              WHERE d.SatisId=@sId";
            _siparisTablosu = DAL.DatabaseHelper.GetData(qDetay, new System.Data.SqlClient.SqlParameter("@sId", _satisId));
            dataGridView.DataSource = _siparisTablosu;
            dataGridView.RowHeadersVisible  = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
            if(dataGridView.Columns.Count > 0 && dataGridView.Columns.Contains("Id")) dataGridView.Columns["Id"].Visible = false;

            string qOdeme = @"SELECT Id, OdemeTuru AS [Ödeme Türü], OdemeTutari AS [Ödenen], Aciklama AS [Açıklama], Tarih
                              FROM Odemeler WHERE SatisId=@sId";
            _odemelerTablosu = DAL.DatabaseHelper.GetData(qOdeme, new System.Data.SqlClient.SqlParameter("@sId", _satisId));
            dataGridViewOdemeler.DataSource = _odemelerTablosu;
            dataGridViewOdemeler.RowHeadersVisible  = false;
            dataGridViewOdemeler.AllowUserToAddRows = false;
            dataGridViewOdemeler.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
            if(dataGridViewOdemeler.Columns.Count > 0 && dataGridViewOdemeler.Columns.Contains("Id")) dataGridViewOdemeler.Columns["Id"].Visible = false;

            ToplanlariGuncelle();
        }

        private void EkleSiparisSatiri(string urun, int miktar, decimal birimFiyat, decimal indTutar, string aciklama, string tarih)
        {
            // Eğer UrunId'yi bilemezsek isimden buluruz.
            int urunId = 0;
            try { urunId = Convert.ToInt32(DAL.DatabaseHelper.GetData("SELECT TOP 1 Id FROM Urunler WHERE UrunAdi=@Ad", new System.Data.SqlClient.SqlParameter("@Ad", urun)).Rows[0][0]); } catch { return; }
            
            decimal tutar = (miktar * birimFiyat) - indTutar;
            string sorgu = "INSERT INTO SatisDetaylari (SatisId, UrunId, Miktar, BirimFiyati, Tutar, Indirim, Aciklama) VALUES (@Satis, @Urun, @Miktar, @Fiyat, @Tutar, @Ind, @Ack)";
            DAL.DatabaseHelper.ExecuteCommand(sorgu, 
                new System.Data.SqlClient.SqlParameter("@Satis", _satisId),
                new System.Data.SqlClient.SqlParameter("@Urun", urunId),
                new System.Data.SqlClient.SqlParameter("@Miktar", miktar),
                new System.Data.SqlClient.SqlParameter("@Fiyat", birimFiyat),
                new System.Data.SqlClient.SqlParameter("@Tutar", tutar),
                new System.Data.SqlClient.SqlParameter("@Ind", indTutar),
                new System.Data.SqlClient.SqlParameter("@Ack", string.IsNullOrEmpty(aciklama) ? (object)DBNull.Value : aciklama));
            SiparisleriYukle();
        }

        // =========================================================
        // TOPLAMLAR
        // =========================================================
        private void ToplanlariGuncelle()
        {
            if (_satisId == 0) return;

            decimal toplamTutar = 0, toplamInd = 0;
            foreach (DataRow row in _siparisTablosu.Rows)
            {
                toplamTutar += Convert.ToDecimal(row["Tutar"]);
                toplamInd   += Convert.ToDecimal(row["İndirim Tutarı"]);
            }

            decimal genelToplam = (toplamTutar + toplamInd);
            decimal indliToplam = toplamTutar;
            decimal indOrani    = genelToplam > 0 ? (toplamInd / genelToplam * 100) : 0;

            decimal odenen = 0;
            foreach (DataRow row in _odemelerTablosu.Rows)
                odenen += Convert.ToDecimal(row["Ödenen"]);

            decimal kalan = indliToplam - odenen;

            // Satislar Tablosunda Veriyi Güncelle
            DAL.DatabaseHelper.ExecuteCommand("UPDATE Satislar SET Tutar=@T, Indirim=@I, Odenen=@O, Kalan=@K WHERE Id=@Id",
                new System.Data.SqlClient.SqlParameter("@T", genelToplam),
                new System.Data.SqlClient.SqlParameter("@I", toplamInd),
                new System.Data.SqlClient.SqlParameter("@O", odenen),
                new System.Data.SqlClient.SqlParameter("@K", kalan),
                new System.Data.SqlClient.SqlParameter("@Id", _satisId));

            lblOdenen.Text      = "₺" + odenen.ToString("N2");
            lblKalan.Text       = "₺" + kalan.ToString("N2");
            lblIndToplamı.Text  = "₺" + toplamInd.ToString("N2");
            lblIndOrani.Text    = "%" + indOrani.ToString("N2");
            lblToplam.Text      = "₺" + genelToplam.ToString("N2");
            lblIndliToplam.Text = "₺" + indliToplam.ToString("N2");

            lblKalan.BackColor = (kalan <= 0) ? System.Drawing.Color.FromArgb(40, 167, 69) : System.Drawing.Color.FromArgb(220, 53, 69);
        }

        private decimal HesaplaKalan()
        {
            decimal tutar = 0, ind = 0, odenen = 0;
            foreach (DataRow row in _siparisTablosu.Rows)
            {
                tutar += Convert.ToDecimal(row["Tutar"]);
                ind   += Convert.ToDecimal(row["İndirim Tutarı"]);
            }
            foreach (DataRow row in _odemelerTablosu.Rows)
                odenen += Convert.ToDecimal(row["Ödenen"]);

            return tutar - odenen;
        }

        // =========================================================
        // NAVİGASYON — Sidebar ikon butonları
        // =========================================================
        private void btnNavSiparisler_Click(object sender, EventArgs e)
        {
            panelSiparisler.Visible = true;
            panelOdemeler.Visible   = false;
            // Aktif buton görsel durumu
            btnNavSiparisler.BackColor             = System.Drawing.Color.FromArgb(219, 234, 255);
            btnNavSiparisler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnNavOdemeler.BackColor               = System.Drawing.Color.White;
            btnNavOdemeler.FlatAppearance.BorderColor   = System.Drawing.Color.LightGray;
        }

        private void btnNavOdemeler_Click(object sender, EventArgs e)
        {
            panelSiparisler.Visible = false;
            panelOdemeler.Visible   = true;
            // Aktif buton görsel durumu
            btnNavOdemeler.BackColor               = System.Drawing.Color.FromArgb(219, 234, 255);
            btnNavOdemeler.FlatAppearance.BorderColor   = System.Drawing.Color.FromArgb(0, 120, 215);
            btnNavSiparisler.BackColor             = System.Drawing.Color.White;
            btnNavSiparisler.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
        }

        // =========================================================
        // ÖDEME BUTONLARI
        // =========================================================
        private void btnNakit_Click(object sender, EventArgs e)
        {
            AcikOdemeFormu("Nakit Ödeme", "Nakit");
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            AcikOdemeFormu("Kredi Kartı ile Ödeme", "Kredi Kartı");
        }

        private void AcikOdemeFormu(string baslik, string odemeTuru)
        {
            decimal kalan = HesaplaKalan();
            if (kalan <= 0) { MessageBox.Show("Ödenecek bakiye bulunmuyor."); return; }

            using (var form = new OdemeForm(baslik, kalan))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    string sorgu = "INSERT INTO Odemeler (SatisId, OdemeTuru, OdemeTutari, Aciklama) VALUES (@sId, @Tur, @Tutar, @Ack)";
                    DAL.DatabaseHelper.ExecuteCommand(sorgu,
                        new System.Data.SqlClient.SqlParameter("@sId", _satisId),
                        new System.Data.SqlClient.SqlParameter("@Tur", odemeTuru),
                        new System.Data.SqlClient.SqlParameter("@Tutar", form.OdenenTutar),
                        new System.Data.SqlClient.SqlParameter("@Ack", form.Aciklama));
                    SiparisleriYukle();
                }
            }
        }

        // =========================================================
        // SİPARİŞ BUTON OLAYLARI
        // =========================================================
        private void btnMusteriTemizle_Click(object sender, EventArgs e)
        {
            cmbMusteri.Text = "Müşteri Seçiniz";
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            using (var form = new UrunSecimForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK && form.SecilenUrun != null)
                {
                    var urun = form.SecilenUrun;
                    string ad   = urun["Ürün Adı"].ToString();
                    decimal fiy = Convert.ToDecimal(urun["Birim Fiyatı1"]);
                    EkleSiparisSatiri(ad, 1, fiy, 0m, "", DateTime.Now.ToShortDateString());
                    ToplanlariGuncelle();
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            // Manuel ekleme satırı şimdilik siparişler uzerinden "Urun Secim" formuna devrediliyor.
        }

        private void btnYenileListele_Click(object sender, EventArgs e)
        {
            SiparisleriYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veriler zaten canlı olarak SQL'e işlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSonuclandır_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sipariş sonuçlandırılsın mı?", "Onay",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;  // masayı yeşile çevirecek sinyal
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView.Columns[e.ColumnIndex].Name == "colSil")
            {
                if (MessageBox.Show("Bu satır silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int detayId = Convert.ToInt32(_siparisTablosu.Rows[e.RowIndex]["Id"]);
                    DAL.DatabaseHelper.ExecuteCommand("DELETE FROM SatisDetaylari WHERE Id=@Id", 
                        new System.Data.SqlClient.SqlParameter("@Id", detayId));
                    SiparisleriYukle();
                }
            }
        }

        private void dataGridViewOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridViewOdemeler.Columns[e.ColumnIndex].Name == "colSilOdeme")
            {
                if (MessageBox.Show("Bu ödeme silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int odemeId = Convert.ToInt32(_odemelerTablosu.Rows[e.RowIndex]["Id"]);
                    DAL.DatabaseHelper.ExecuteCommand("DELETE FROM Odemeler WHERE Id=@Id", 
                        new System.Data.SqlClient.SqlParameter("@Id", odemeId));
                    SiparisleriYukle();
                }
            }
        }
    }
}
