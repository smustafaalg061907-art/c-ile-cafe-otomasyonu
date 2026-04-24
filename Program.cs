using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Veritabanındaki eksik kolonları (Adres, Soru vs.) otomatik tamamla
            DAL.DatabaseHelper.TablolariGuncelle();

            using (KullaniciGirisForm frm = new KullaniciGirisForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
