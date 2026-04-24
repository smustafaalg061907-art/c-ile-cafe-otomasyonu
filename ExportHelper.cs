using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CafeOtomasyonu.Tools
{
    public static class ExportHelper
    {
        /// <summary>
        /// DataGridView içeriğini Excel'in yerel olarak tanıyacağı CSV (.csv) formatında kaydeder.
        /// </summary>
        public static void ExportToExcel(DataGridView grid, string varsayilanDosyaAdi = "Rapor")
        {
            if (grid == null || grid.Rows.Count == 0)
            {
                MessageBox.Show("Dışa aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (Virgülle Ayrılmış) formatı (*.csv)|*.csv|Tüm Dosyalar (*.*)|*.*";
                sfd.FileName = varsayilanDosyaAdi + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                sfd.Title = "Excel (CSV) Olarak Kaydet";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // UTF8 encoding with BOM for Excel to automatically recognise Turkish Characters
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            // 1. Yazdırılacak geçerli (görünür) sütunları bul
                            int colCount = grid.Columns.Count;
                            for (int i = 0; i < colCount; i++)
                            {
                                if (grid.Columns[i].Visible)
                                {
                                    sw.Write("\"" + grid.Columns[i].HeaderText + "\"");
                                    if (i < colCount - 1)
                                        sw.Write(";");
                                }
                            }
                            sw.WriteLine();

                            // 2. Satırları dön
                            foreach (DataGridViewRow row in grid.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < colCount; i++)
                                    {
                                        if (grid.Columns[i].Visible)
                                        {
                                            string cellValue = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                                            // Satır içindeki yeni satırları ve çift tırnakları temizle
                                            cellValue = cellValue.Replace("\r", "").Replace("\n", " ").Replace("\"", "\"\"");
                                            sw.Write("\"" + cellValue + "\"");

                                            if (i < colCount - 1)
                                                sw.Write(";");
                                        }
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }
                        MessageBox.Show("Rapor başarıyla Excel (CSV) formatında dışa aktarıldı!\n\nDosya Yolu:\n" + sfd.FileName, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dışa aktarma sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// DataGridView içeriğini bir HTML raporu olarak oluşturarak PDF veya yazıcı çıktısı gibi kullanılabilecek şekilde kaydeder.
        /// </summary>
        public static void ExportToPdfOrHtml(DataGridView grid, string raporBasligi = "Sistem Raporu")
        {
             if (grid == null || grid.Rows.Count == 0)
             {
                 MessageBox.Show("Dışa aktarılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             using (SaveFileDialog sfd = new SaveFileDialog())
             {
                 sfd.Filter = "HTML Rapor Dosyası (*.html)|*.html|Tüm Dosyalar (*.*)|*.*";
                 sfd.FileName = raporBasligi.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html";
                 sfd.Title = "Rapor (PDF / HTML) Görüntüsü Olarak Kaydet";

                 if (sfd.ShowDialog() == DialogResult.OK)
                 {
                     try
                     {
                         StringBuilder sb = new StringBuilder();
                         sb.AppendLine("<!DOCTYPE html>");
                         sb.AppendLine("<html>");
                         sb.AppendLine("<head>");
                         sb.AppendLine("<meta charset=\"utf-8\">");
                         sb.AppendLine("<title>" + raporBasligi + "</title>");
                         sb.AppendLine("<style>");
                         sb.AppendLine("body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 20px; color: #333; }");
                         sb.AppendLine("h1 { text-align: center; color: #1772be; }");
                         sb.AppendLine(".date { text-align: right; font-size: 12px; color: #666; margin-bottom: 20px;}");
                         sb.AppendLine("table { width: 100%; border-collapse: collapse; margin-top: 10px; font-size: 13px; }");
                         sb.AppendLine("th, td { border: 1px solid #ddd; padding: 10px; text-align: left; }");
                         sb.AppendLine("th { background-color: #f2f2f2; color: #333; font-weight: bold; }");
                         sb.AppendLine("tr:nth-child(even) { background-color: #f9f9f9; }");
                         sb.AppendLine("tr:hover { background-color: #f1f1f1; }");
                         sb.AppendLine(".footer { text-align: center; margin-top: 30px; font-size: 11px; color: #999; border-top: 1px solid #eee; padding-top: 10px; }");
                         sb.AppendLine("</style>");
                         sb.AppendLine("</head>");
                         sb.AppendLine("<body>");

                         sb.AppendLine("<h1>" + raporBasligi + "</h1>");
                         sb.AppendLine("<div class=\"date\">Rapor Tarihi: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "</div>");

                         sb.AppendLine("<table>");
                         
                         // Headers
                         sb.AppendLine("<thead><tr>");
                         foreach (DataGridViewColumn col in grid.Columns)
                         {
                             if (col.Visible)
                             {
                                 sb.AppendLine("<th>" + col.HeaderText + "</th>");
                             }
                         }
                         sb.AppendLine("</tr></thead>");

                         // Rows
                         sb.AppendLine("<tbody>");
                         foreach (DataGridViewRow row in grid.Rows)
                         {
                             if (!row.IsNewRow)
                             {
                                 sb.AppendLine("<tr>");
                                 foreach (DataGridViewColumn col in grid.Columns)
                                 {
                                     if (col.Visible)
                                     {
                                         string val = row.Cells[col.Index].Value != null ? row.Cells[col.Index].Value.ToString() : "";
                                         sb.AppendLine("<td>" + System.Net.WebUtility.HtmlEncode(val) + "</td>");
                                     }
                                 }
                                 sb.AppendLine("</tr>");
                             }
                         }
                         sb.AppendLine("</tbody>");
                         sb.AppendLine("</table>");

                         sb.AppendLine("<div class=\"footer\">Bu belge Cafe Otomasyonu Sistemi tarafından otomatik olarak oluşturulmuştur.<br><br><b>Not:</b> Bu sayfayı tarayıcınızın 'Yazdır' (Ctrl+P) özelliğini kullanarak doğrudan PDF olarak kaydedebilirsiniz.</div>");
                         sb.AppendLine("</body>");
                         sb.AppendLine("</html>");

                         File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                         // Kullanıcıya görüntülemek isteyip istemediğini sor
                         DialogResult dr = MessageBox.Show("Rapor dosyası başarıyla kaydedildi!\n\nRaporu tarayıcınızda açıp yazdırmak (veya PDF olarak kaydetmek) ister misiniz?", "İşlem Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         
                         if(dr == DialogResult.Yes) 
                         {
                             System.Diagnostics.Process.Start(sfd.FileName);
                         }

                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Raporlama sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
             }
        }
    }
}
