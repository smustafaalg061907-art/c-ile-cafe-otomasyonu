using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string dir = @"C:\Users\smust\OneDrive\Desktop\C# DevExpress Katmalý Mimari ile Cafe Otomasyonu\CafeOtomasyonu";
        string[] files = Directory.GetFiles(dir, "*Designer.cs", SearchOption.AllDirectories);
        
        Regex regex = new Regex(@"(Btn|KurIslemButon)\(\s*this\.(\w+)\s*,\s*"([^"]+)"\s*,\s*"([^"]+)"\s*,\s*System\.Drawing\.Color\.FromArgb\(\s*(\d+)\s*,\s*(\d+)\s*,\s*(\d+)\s*\)\s*,\s*(\d+)\s*,\s*(\d+)\s*,\s*(\d+)\s*\);", RegexOptions.Singleline);
        
        foreach (string file in files)
        {
            string content = File.ReadAllText(file);
            if (regex.IsMatch(content))
            {
                Console.WriteLine("Fixing " + Path.GetFileName(file));
                string newContent = regex.Replace(content, match =>
                {
                    string btn = match.Groups[2].Value;
                    string name = match.Groups[3].Value;
                    string text = match.Groups[4].Value;
                    string r = match.Groups[5].Value;
                    string g = match.Groups[6].Value;
                    string b = match.Groups[7].Value;
                    string x = match.Groups[8].Value;
                    string y = match.Groups[9].Value;
                    string w = match.Groups[10].Value;
                    
                    return $"this.{btn}.BackColor = System.Drawing.Color.FromArgb({r}, {g}, {b});\r\n" +
                           $"            this.{btn}.FlatStyle = System.Windows.Forms.FlatStyle.Flat;\r\n" +
                           $"            this.{btn}.FlatAppearance.BorderSize = 0;\r\n" +
                           $"            this.{btn}.Font = new System.Drawing.Font(\"Segoe UI\", 9F);\r\n" +
                           $"            this.{btn}.ForeColor = System.Drawing.Color.White;\r\n" +
                           $"            this.{btn}.Location = new System.Drawing.Point({x}, {y});\r\n" +
                           $"            this.{btn}.Name = \"{name}\";\r\n" +
                           $"            this.{btn}.Size = new System.Drawing.Size({w}, 28);\r\n" +
                           $"            this.{btn}.Text = \"{text}\";\r\n" +
                           $"            this.{btn}.Cursor = System.Windows.Forms.Cursors.Hand;";
                });
                File.WriteAllText(file, newContent);
            }
        }
    }
}
