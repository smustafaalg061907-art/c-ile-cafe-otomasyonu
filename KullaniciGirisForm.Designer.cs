namespace CafeOtomasyonu
{
    partial class KullaniciGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisForm));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.picKilit = new System.Windows.Forms.PictureBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.lnkKaydol = new System.Windows.Forms.LinkLabel();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnParolamiUnuttum = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblIslemler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKilit)).BeginInit();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBaslik.Location = new System.Drawing.Point(187, 10);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(347, 49);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kullanıcı Girişi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picKilit
            // 
            this.picKilit.BackColor = System.Drawing.Color.Goldenrod;
            this.picKilit.Image = ((System.Drawing.Image)(resources.GetObject("picKilit.Image")));
            this.picKilit.Location = new System.Drawing.Point(11, 45);
            this.picKilit.Margin = new System.Windows.Forms.Padding(4);
            this.picKilit.Name = "picKilit";
            this.picKilit.Size = new System.Drawing.Size(168, 160);
            this.picKilit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKilit.TabIndex = 1;
            this.picKilit.TabStop = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(187, 77);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(345, 30);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "Admin";
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParola.Location = new System.Drawing.Point(187, 126);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '●';
            this.txtParola.Size = new System.Drawing.Size(345, 30);
            this.txtParola.TabIndex = 3;
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkBeniHatirla.Location = new System.Drawing.Point(187, 183);
            this.chkBeniHatirla.Margin = new System.Windows.Forms.Padding(4);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(109, 24);
            this.chkBeniHatirla.TabIndex = 4;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // lnkKaydol
            // 
            this.lnkKaydol.AutoSize = true;
            this.lnkKaydol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkKaydol.Location = new System.Drawing.Point(473, 185);
            this.lnkKaydol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkKaydol.Name = "lnkKaydol";
            this.lnkKaydol.Size = new System.Drawing.Size(55, 20);
            this.lnkKaydol.TabIndex = 5;
            this.lnkKaydol.TabStop = true;
            this.lnkKaydol.Text = "Kaydol";
            this.lnkKaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKaydol_LinkClicked);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.btnKapat);
            this.panelIslemler.Controls.Add(this.btnParolamiUnuttum);
            this.panelIslemler.Controls.Add(this.btnGirisYap);
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 251);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(603, 94);
            this.panelIslemler.TabIndex = 6;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.Location = new System.Drawing.Point(436, 27);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 37);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnParolamiUnuttum.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnParolamiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParolamiUnuttum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(205, 27);
            this.btnParolamiUnuttum.Margin = new System.Windows.Forms.Padding(4);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(187, 37);
            this.btnParolamiUnuttum.TabIndex = 1;
            this.btnParolamiUnuttum.Text = "❓ Parolamı Unuttum";
            this.btnParolamiUnuttum.UseVisualStyleBackColor = false;
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGirisYap.Location = new System.Drawing.Point(46, 27);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(133, 37);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location = new System.Drawing.Point(7, 6);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(0, 19);
            this.lblIslemler.TabIndex = 3;
            this.lblIslemler.Click += new System.EventHandler(this.lblIslemler_Click);
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(603, 345);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lnkKaydol);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.picKilit);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.picKilit)).EndInit();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox picKilit;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.LinkLabel lnkKaydol;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnParolamiUnuttum;
        private System.Windows.Forms.Button btnKapat;
    }
}
