using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu.Tools
{
    public static class ThemeHelper
    {
        public static void ChangeTheme(string themeName)
        {
            // Kullanıcı isteği üzerine: İç sayfalar (panel/usercontrol kısımları) 
            // her zaman AÇIK (Beyaz) kalacak. Sadece DevExpress şeridi (Ribbon) temadan etkilenecek.
            // Bu sayede koyu tema seçildiğinde beyaz sayfadaki siyah yazıların görünmez olması engellenmiş olur.
            Color formBg = Color.White;
            Color panelBg = Color.WhiteSmoke;
            Color textColor = Color.Black;

            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = formBg;
                ApplyToControls(form, formBg, panelBg, textColor);
            }
        }

        private static void ApplyToControls(Control parent, Color formBg, Color panelBg, Color textColor)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Üst mavi sekmeleri ve sabit siyah başlıkları (örn ayarlar başlığı) ellemiyoruz
                if (ctrl.Name == "lblBaslik" || ctrl.Name.EndsWith("AltDusuk") || ctrl.Name == "panelAlt")
                {
                    // Buton panellerini genelde beyaz ya da gri yapıyorduk
                    if (ctrl.Name == "panelAlt" || ctrl.Name.EndsWith("AltDusuk"))
                    {
                        ctrl.BackColor = (textColor == Color.White) ? Color.FromArgb(25, 25, 25) : Color.WhiteSmoke;
                    }
                    continue; 
                }

                if (ctrl is Label label)
                {
                    label.ForeColor = textColor;
                    label.BackColor = Color.Transparent;
                }
                else if (ctrl is CheckBox cb)
                {
                    cb.ForeColor = textColor;
                }
                else if (ctrl is GroupBox gb)
                {
                    gb.ForeColor = textColor;
                    gb.BackColor = Color.Transparent;
                }
                else if (ctrl is Panel panel)
                {
                    panel.BackColor = panelBg;
                }
                else if (ctrl is UserControl uc)
                {
                    uc.BackColor = formBg;
                }
                else if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is RichTextBox || ctrl is ComboBox)
                {
                    if (textColor == Color.White)
                    {
                        ctrl.BackColor = Color.FromArgb(60, 60, 60);
                        ctrl.ForeColor = Color.White;
                    }
                    else
                    {
                        ctrl.BackColor = Color.White;
                        ctrl.ForeColor = Color.Black;
                    }
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = formBg;
                    dgv.DefaultCellStyle.BackColor = (textColor == Color.White) ? Color.FromArgb(40,40,40) : Color.White;
                    dgv.DefaultCellStyle.ForeColor = textColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = panelBg;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = textColor;
                }

                // Alt objelere de in
                if (ctrl.HasChildren)
                {
                    ApplyToControls(ctrl, formBg, panelBg, textColor);
                }
            }
        }
    }
}
