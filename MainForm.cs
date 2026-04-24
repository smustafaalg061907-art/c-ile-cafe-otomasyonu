using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;

namespace CafeOtomasyonu
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            HookRibbonEvents();
            YetkileriAyarla();
        }

        private void YetkileriAyarla()
        {
            string kullaniciAdi = Tools.KullaniciOturum.KullaniciAdi?.Trim().ToLower();
            if (kullaniciAdi == "admin") return;

            string gorev = Tools.KullaniciOturum.Gorevi?.Trim().ToLower();
            if (gorev != "admin" && gorev != "yönetici" && gorev != "tam yetkili (admin)")
            {
                barBtnUrunler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnUrunHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnMenuler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnMenuHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnKullanicilar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnKullaniciHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnOdemeHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnMasaHareketleriRaporu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnOzelRaporOlustur.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnDashboard.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnGenelAyarlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtnMasaHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void HookRibbonEvents()
        {
            barBtnMasalar.ItemClick         += (s, e) => AcMasalar();
            barBtnMasaHareketleri.ItemClick += (s, e) => AcMasaHareketleri();
            barbtnmasasiparis.ItemClick += (s, e) => AcMasaDurumlari();
            barBtnUrunler.ItemClick         += (s, e) => AcUrunler();
            barBtnUrunHareketleri.ItemClick += (s, e) => AcUrunHareketleri();
            barBtnMenuler.ItemClick         += (s, e) => { var frm = new MenulerForm(); frm.ShowDialog(); };
            barBtnMenuHareketleri.ItemClick += (s, e) => AcMenuHareketleri();
            barBtnSatislar.ItemClick        += (s, e) => AcSatislar();
            barBtnKullanicilar.ItemClick    += (s, e) => AcKullanicilar();
            barBtnKullaniciHareketleri.ItemClick += (s, e) => AcKullaniciHareketleri();
            barBtnBilgilerim.ItemClick      += (s, e) => AcBilgilerim();
            barBtnMusteriler.ItemClick      += (s, e) => AcMusteriler();
            barBtnOdemeHareketleri.ItemClick += (s, e) => AcOdemeHareketleri();
            barBtnPaketSiparisi.ItemClick    += (s, e) => AcPaketSiparisi();
            barBtnMasaHareketleriRaporu.ItemClick += (s, e) => AcMasaHareketleriRaporu();
            barBtnOzelRaporOlustur.ItemClick += (s, e) => AcOzelRaporOlustur();
            barBtnDashboard.ItemClick        += (s, e) => AcDashboard();
            
            // Ayarlar
            this.barBtnGenelAyarlar.ItemClick += (s, e) => AddTab("Sistem Ayarları", new AyarlarControl());
        }

        private void AddTab(string text, UserControl control)
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Text == text)
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Text = text
            };

            control.Dock = DockStyle.Fill;
            tab.Controls.Add(control);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMasalar()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMasalar")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabMasalar",
                Text = "Masalar"
            };

            var ctrl = new MasalarControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMasaDurumlari()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMasaDurumlari")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabMasaDurumlari",
                Text = "Masa Durumları"
            };

            var ctrl = new MasaDurumlariControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcUrunler()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabUrunler")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabUrunler",
                Text = "Ürünler"
            };

            var ctrl = new UrunlerControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcSatislar()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabSatislar")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabSatislar",
                Text = "Satışlar"
            };

            var ctrl = new SatislarControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcKullanicilar()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabKullanicilar")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabKullanicilar",
                Text = "Kullanıcılar Formu"
            };

            var ctrl = new KullanicilarControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMasaHareketleri()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMasaHareketleri")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabMasaHareketleri",
                Text = "Masa Hareketleri"
            };

            var ctrl = new MasaHareketleriControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMenuHareketleri()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMenuHareketleri")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabMenuHareketleri",
                Text = "Menü Hareketleri"
            };

            var ctrl = new MenuHareketleriControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcUrunHareketleri()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabUrunHareketleri")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabUrunHareketleri",
                Text = "Ürün Hareketleri"
            };

            var ctrl = new UrunHareketleriControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcKullaniciHareketleri()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabKullaniciHareketleri")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabKullaniciHareketleri",
                Text = "Kullanıcı Hareketleri"
            };

            var ctrl = new KullaniciHareketleriControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcBilgilerim()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabBilgilerim")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabBilgilerim",
                Text = "Kişisel Bilgilerim"
            };

            var ctrl = new BilgilerimControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMusteriler()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMusteriler")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabMusteriler",
                Text = "Müşteriler (Cari Bilgileri)"
            };

            var ctrl = new MusterilerControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcOdemeHareketleri()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabOdemeHareketleri")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage
            {
                Name = "tabOdemeHareketleri",
                Text = "Ödeme Hareketleri"
            };

            var ctrl = new OdemeHareketleriControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcPaketSiparisi()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabPaketSiparisi")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage { Name = "tabPaketSiparisi", Text = "Paket Siparişleri" };
            var ctrl = new PaketSiparisiControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcMasaHareketleriRaporu()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabMasaHareketleriRaporu")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage { Name = "tabMasaHareketleriRaporu", Text = "Masa Hareketleri Raporu" };
            var ctrl = new MasaHareketleriRaporuControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcOzelRaporOlustur()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabOzelRaporOlustur")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage { Name = "tabOzelRaporOlustur", Text = "Özel Rapor Oluştur" };
            var ctrl = new OzelRaporOlusturControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void AcDashboard()
        {
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == "tabDashboard")
                {
                    xtraTabControl.SelectedTabPage = page;
                    return;
                }
            }

            var tab = new XtraTabPage { Name = "tabDashboard", Text = "Dashboard (Yönetim)" };
            var ctrl = new DashboardControl { Dock = DockStyle.Fill };
            tab.Controls.Add(ctrl);
            xtraTabControl.TabPages.Add(tab);
            xtraTabControl.SelectedTabPage = tab;
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barBtnMenuler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnGenelAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
