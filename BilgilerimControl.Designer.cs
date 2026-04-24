namespace CafeOtomasyonu
{
    partial class BilgilerimControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtYetki = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(900, 45);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(900, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kişisel Bilgiler";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIcerik
            // 
            this.panelIcerik.BackColor = System.Drawing.Color.DarkGray;
            this.panelIcerik.Controls.Add(this.label1);
            this.panelIcerik.Controls.Add(this.textBox1);
            this.panelIcerik.Controls.Add(this.btnAdminEkle);
            this.panelIcerik.Controls.Add(this.btnKaydet);
            this.panelIcerik.Controls.Add(this.txtYetki);
            this.panelIcerik.Controls.Add(this.lblYetki);
            this.panelIcerik.Controls.Add(this.txtEmail);
            this.panelIcerik.Controls.Add(this.lblEmail);
            this.panelIcerik.Controls.Add(this.txtTelefon);
            this.panelIcerik.Controls.Add(this.lblTelefon);
            this.panelIcerik.Controls.Add(this.txtAdSoyad);
            this.panelIcerik.Controls.Add(this.lblAdSoyad);
            this.panelIcerik.Controls.Add(this.txtKullaniciAdi);
            this.panelIcerik.Controls.Add(this.lblKullaniciAdi);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 45);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Size = new System.Drawing.Size(900, 405);
            this.panelIcerik.TabIndex = 1;
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdminEkle.FlatAppearance.BorderSize = 0;
            this.btnAdminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdminEkle.ForeColor = System.Drawing.Color.White;
            this.btnAdminEkle.Location = new System.Drawing.Point(150, 318);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(300, 30);
            this.btnAdminEkle.TabIndex = 0;
            this.btnAdminEkle.Text = "Yeni Admin Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = false;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(150, 281);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(300, 30);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "💾 Bilgileri Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtYetki
            // 
            this.txtYetki.Location = new System.Drawing.Point(150, 238);
            this.txtYetki.Name = "txtYetki";
            this.txtYetki.ReadOnly = true;
            this.txtYetki.Size = new System.Drawing.Size(300, 27);
            this.txtYetki.TabIndex = 2;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(44, 241);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(95, 20);
            this.lblYetki.TabIndex = 3;
            this.lblYetki.Text = "Sistem Yetki :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(70, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Posta :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(150, 158);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(300, 27);
            this.txtTelefon.TabIndex = 6;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(70, 161);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 20);
            this.lblTelefon.TabIndex = 7;
            this.lblTelefon.Text = "Telefon :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(150, 77);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(300, 27);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(96, 84);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 20);
            this.lblAdSoyad.TabIndex = 9;
            this.lblAdSoyad.Text = "Ad :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(150, 37);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.ReadOnly = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(300, 27);
            this.txtKullaniciAdi.TabIndex = 10;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(40, 40);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 20);
            this.lblKullaniciAdi.TabIndex = 11;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.btnKapat);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 450);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(900, 50);
            this.panelIslemler.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(790, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 27);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Soyad :";
            // 
            // BilgilerimControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.panelIslemler);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "BilgilerimControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.panelUst.ResumeLayout(false);
            this.panelIcerik.ResumeLayout(false);
            this.panelIcerik.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnKapat;

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblYetki;

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtYetki;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
