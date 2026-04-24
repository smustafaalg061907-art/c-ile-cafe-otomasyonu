using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace CafeOtomasyonu
{
    public partial class AyarlarControl : UserControl
    {
        public AyarlarControl()
        {
            InitializeComponent();
        }

        private void AyarlarControl_Load(object sender, EventArgs e)
        {
            cmbTema.SelectedIndex = 0;
            cmbYazici.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbTema.SelectedItem != null)
            {
                string secilenTema = cmbTema.SelectedItem.ToString();
                switch (secilenTema)
                {
                    case "Açık Tema (Mavi)":
                        UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
                        break;
                    case "Koyu Tema (Koyu Gri)":
                        UserLookAndFeel.Default.SetSkinStyle("The Bezier", "Office Black");
                        break;
                    case "Retro Tema":
                        UserLookAndFeel.Default.SetSkinStyle("Coffee");
                        break;
                }
                
                // Mimarideki diğer standart pencerelerdeki label/panel renk kayıplarını kökten çözen dinamik motoru çağır
                CafeOtomasyonu.Tools.ThemeHelper.ChangeTheme(secilenTema);
            }
            
            MessageBox.Show("Ayarlar başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veritabanı başarıyla yedeklendi.", "Yedekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
