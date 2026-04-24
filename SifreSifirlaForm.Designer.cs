namespace CafeOtomasyonu
{
    partial class SifreSifirlaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblSifreGirisKullanici = new System.Windows.Forms.Label();
            this.txtSifreGirisKullanici = new System.Windows.Forms.TextBox();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreyiSifirla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBaslik.Location = new System.Drawing.Point(0, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(430, 40);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Şifremi Sıfırla";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSifreGirisKullanici
            // 
            this.lblSifreGirisKullanici.AutoSize = true;
            this.lblSifreGirisKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSifreGirisKullanici.Location = new System.Drawing.Point(30, 80);
            this.lblSifreGirisKullanici.Name = "lblSifreGirisKullanici";
            this.lblSifreGirisKullanici.Size = new System.Drawing.Size(95, 20);
            this.lblSifreGirisKullanici.TabIndex = 1;
            this.lblSifreGirisKullanici.Text = "Kullanıcı Adı:";
            // 
            // txtSifreGirisKullanici
            // 
            this.txtSifreGirisKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifreGirisKullanici.Location = new System.Drawing.Point(140, 77);
            this.txtSifreGirisKullanici.Name = "txtSifreGirisKullanici";
            this.txtSifreGirisKullanici.Size = new System.Drawing.Size(240, 27);
            this.txtSifreGirisKullanici.TabIndex = 2;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYeniSifre.Location = new System.Drawing.Point(30, 120);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(73, 20);
            this.lblYeniSifre.TabIndex = 3;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYeniSifre.Location = new System.Drawing.Point(140, 117);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(240, 27);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(30, 160);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(117, 20);
            this.lblYeniSifreTekrar.TabIndex = 5;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(140, 157);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '*';
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(240, 27);
            this.txtYeniSifreTekrar.TabIndex = 6;
            // 
            // btnSifreyiSifirla
            // 
            this.btnSifreyiSifirla.BackColor = System.Drawing.Color.Firebrick;
            this.btnSifreyiSifirla.FlatAppearance.BorderSize = 0;
            this.btnSifreyiSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreyiSifirla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSifreyiSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifreyiSifirla.Location = new System.Drawing.Point(140, 21);
            this.btnSifreyiSifirla.Name = "btnSifreyiSifirla";
            this.btnSifreyiSifirla.Size = new System.Drawing.Size(140, 30);
            this.btnSifreyiSifirla.TabIndex = 0;
            this.btnSifreyiSifirla.Text = "🔑 Kaydet";
            this.btnSifreyiSifirla.UseVisualStyleBackColor = false;
            this.btnSifreyiSifirla.Click += new System.EventHandler(this.btnSifreyiSifirla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.Location = new System.Drawing.Point(163, 57);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "❌ İptal";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.btnKapat);
            this.panelIslemler.Controls.Add(this.btnSifreyiSifirla);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 227);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(430, 93);
            this.panelIslemler.TabIndex = 7;
            // 
            // SifreSifirlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 320);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.lblYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtSifreGirisKullanici);
            this.Controls.Add(this.lblSifreGirisKullanici);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifreSifirlaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırlama";
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSifreGirisKullanici;
        private System.Windows.Forms.TextBox txtSifreGirisKullanici;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnSifreyiSifirla;
        private System.Windows.Forms.Button btnKapat;
    }
}
