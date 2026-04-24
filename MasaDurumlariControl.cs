using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class MasaDurumlariControl : UserControl
    {
        // Her masanın durumunu tutan sözlük: masaAdı → açık mı?
        private readonly Dictionary<string, bool> _masaDurumlari = new Dictionary<string, bool>();

        private string _seciliMasaAdi = null;
        private Button _seciliBtn     = null;

        // Renk sabitleri
        private static readonly Color RenkBos    = Color.FromArgb(40, 167, 69);   // yeşil
        private static readonly Color RenkDolu   = Color.FromArgb(220, 53, 69);   // kırmızı
        private static readonly Color RenkSecili = Color.Yellow;

        public MasaDurumlariControl()
        {
            InitializeComponent();
            MasalariYukle();
        }

        // =========================================================
        // MASALARI YÜKLE — hepsi baştan yeşil (boş)
        // =========================================================
        private void MasalariYukle()
        {
            panelMasalar.Controls.Clear();
            _seciliMasaAdi = null;
            _seciliBtn     = null;

            int x = 8, y = 8;
            int genislik = 80, yukseklik = 60, aralik = 8;
            int siraSayac = 0;
            int satiraGecSayisi = 10;

            try
            {
                var dt = DAL.DatabaseHelper.GetData("SELECT Id, MasaAdi, Durum FROM Masalar ORDER BY Id ASC");
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["Id"]);
                    string ad = row["MasaAdi"].ToString();
                    bool dolu = Convert.ToBoolean(row["Durum"]);

                    _masaDurumlari[ad] = dolu;

                    var btn = new Button
                    {
                        Text      = ad,
                        Width     = genislik,
                        Height    = yukseklik,
                        Location  = new Point(x, y),
                        BackColor = dolu ? RenkDolu : RenkBos,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font      = new Font("Segoe UI", 9f, FontStyle.Bold),
                        Cursor    = Cursors.Hand,
                        Tag       = id // ID bilgisini Tag'da tutuyoruz
                    };
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += BtnMasa_Click;

                    panelMasalar.Controls.Add(btn);

                    siraSayac++;
                    if (siraSayac % satiraGecSayisi == 0)
                    {
                        x  = 8;
                        y += yukseklik + aralik;
                    }
                    else
                    {
                        x += genislik + aralik;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masalar yüklenirken hata oluştu: " + ex.Message, "Hata");
            }
        }

        // =========================================================
        // MASAYA TIKLANINCA — sadece seç (sarı çerçeve)
        // =========================================================
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            if (!(sender is Button tiklanan)) return;

            if (_seciliBtn != null && _seciliBtn != tiklanan)
            {
                bool eskiDolu = _masaDurumlari.ContainsKey(_seciliBtn.Text)
                                && _masaDurumlari[_seciliBtn.Text];
                _seciliBtn.BackColor                  = eskiDolu ? RenkDolu : RenkBos;
                _seciliBtn.ForeColor                  = Color.White;
                _seciliBtn.FlatAppearance.BorderSize  = 0;
            }

            _seciliBtn     = tiklanan;
            _seciliMasaAdi = tiklanan.Text; // Tag'da ID olduğu için Text'ten Adı okuyoruz

            tiklanan.FlatAppearance.BorderSize  = 3;
            tiklanan.FlatAppearance.BorderColor = RenkSecili;
            tiklanan.ForeColor                  = RenkSecili;
        }

        // =========================================================
        // MASA AÇ — seçili masayı kırmızı yap (dolu)
        // =========================================================
        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (!MasaSeciliMi()) return;

            bool zatenDolu = _masaDurumlari.ContainsKey(_seciliMasaAdi) && _masaDurumlari[_seciliMasaAdi];
            if (zatenDolu)
            {
                MessageBox.Show($"{_seciliMasaAdi} zaten açık (dolu).", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int masaId = Convert.ToInt32(_seciliBtn.Tag);

            // Masayı dolu yap ve veritabanını güncelle, Satış başlatıldı.
            DAL.DatabaseHelper.ExecuteCommand("UPDATE Masalar SET Durum=1 WHERE Id=@Id", 
                new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", masaId) });

            _masaDurumlari[_seciliMasaAdi] = true;

            Button hedefBtn = _seciliBtn;
            
            // Eğer isterseniz seçimi hemen iptal edebilirsiniz veya bekletebilirsiniz
            // Şimdilik sadece rengi güncelliyoruz
            hedefBtn.BackColor                  = RenkDolu;
            hedefBtn.ForeColor                  = Color.White;
            hedefBtn.FlatAppearance.BorderSize  = 3;
            hedefBtn.FlatAppearance.BorderColor = RenkSecili;
        }

        // =========================================================
        // SİPARİŞ — seçili masa için sipariş formu aç
        // =========================================================
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if (!MasaSeciliMi()) return;

            string masaAdi = _seciliMasaAdi;
            Button masaBtn = _seciliBtn;

            var form = new MasaSiparisleriForm(masaAdi);
            DialogResult sonuc = form.ShowDialog();

            // Satis kapatildiysa Masayı tekrar "MÜSAİT" yapmalıyız
            // Bunu form.ShowDialog sonucuna göre (OK) ise DB update ile çözeriz 
            if (sonuc == DialogResult.OK)
            {
                int masaId = Convert.ToInt32(masaBtn.Tag);
                DAL.DatabaseHelper.ExecuteCommand("UPDATE Masalar SET Durum=0 WHERE Id=@Id", 
                    new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", masaId) });

                _masaDurumlari[masaAdi]       = false; 
                masaBtn.BackColor             = RenkBos;
                masaBtn.ForeColor             = Color.White;
                masaBtn.FlatAppearance.BorderSize = 0;

                if (_seciliBtn == masaBtn)
                {
                    _seciliBtn     = null;
                    _seciliMasaAdi = null;
                }
            }
        }

        // =========================================================
        // REZERV ET
        // =========================================================
        private void btnRezervEt_Click(object sender, EventArgs e)
        {
            if (!MasaSeciliMi()) return;
            MessageBox.Show($"{_seciliMasaAdi} rezerve edildi.", "Rezervasyon",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =========================================================
        // YENİLE / LİSTELE
        // =========================================================
        private void btnYenileListele_Click(object sender, EventArgs e)
        {
            MasalariYukle();
        }

        // =========================================================
        // KAPAT
        // =========================================================
        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                var tabControl = tab.TabControl;
                tabControl.TabPages.Remove(tab);
            }
        }

        // =========================================================
        // YARDIMCI
        // =========================================================
        private bool MasaSeciliMi()
        {
            if (string.IsNullOrEmpty(_seciliMasaAdi))
            {
                MessageBox.Show("Lütfen önce bir masa seçiniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
