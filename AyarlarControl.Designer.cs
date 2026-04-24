namespace CafeOtomasyonu
{
    partial class AyarlarControl
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

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.groupBoxFirma = new System.Windows.Forms.GroupBox();
            this.lblKafeninAdi = new System.Windows.Forms.Label();
            this.txtKafeninAdi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.groupBoxSistem = new System.Windows.Forms.GroupBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblYazici = new System.Windows.Forms.Label();
            this.cmbYazici = new System.Windows.Forms.ComboBox();
            this.chkOdemeAl = new System.Windows.Forms.CheckBox();
            this.groupBoxYedekleme = new System.Windows.Forms.GroupBox();
            this.lblYedeklemeBilgi = new System.Windows.Forms.Label();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelOrta.SuspendLayout();
            this.groupBoxFirma.SuspendLayout();
            this.groupBoxSistem.SuspendLayout();
            this.groupBoxYedekleme.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBaslik.Size = new System.Drawing.Size(900, 50);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = " Sistem Ayarları";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOrta
            // 
            this.panelOrta.AutoScroll = true;
            this.panelOrta.BackColor = System.Drawing.Color.DarkGray;
            this.panelOrta.Controls.Add(this.groupBoxFirma);
            this.panelOrta.Controls.Add(this.groupBoxSistem);
            this.panelOrta.Controls.Add(this.groupBoxYedekleme);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 50);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(900, 500);
            this.panelOrta.TabIndex = 0;
            // 
            // groupBoxFirma
            // 
            this.groupBoxFirma.Controls.Add(this.lblKafeninAdi);
            this.groupBoxFirma.Controls.Add(this.txtKafeninAdi);
            this.groupBoxFirma.Controls.Add(this.lblTelefon);
            this.groupBoxFirma.Controls.Add(this.txtTelefon);
            this.groupBoxFirma.Controls.Add(this.lblAdres);
            this.groupBoxFirma.Controls.Add(this.txtAdres);
            this.groupBoxFirma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxFirma.Location = new System.Drawing.Point(30, 20);
            this.groupBoxFirma.Name = "groupBoxFirma";
            this.groupBoxFirma.Size = new System.Drawing.Size(400, 250);
            this.groupBoxFirma.TabIndex = 0;
            this.groupBoxFirma.TabStop = false;
            this.groupBoxFirma.Text = "🏠 İşletme Bilgileri";
            // 
            // lblKafeninAdi
            // 
            this.lblKafeninAdi.AutoSize = true;
            this.lblKafeninAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKafeninAdi.Location = new System.Drawing.Point(20, 40);
            this.lblKafeninAdi.Name = "lblKafeninAdi";
            this.lblKafeninAdi.Size = new System.Drawing.Size(99, 23);
            this.lblKafeninAdi.TabIndex = 0;
            this.lblKafeninAdi.Text = "İşletme Adı:";
            // 
            // txtKafeninAdi
            // 
            this.txtKafeninAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKafeninAdi.Location = new System.Drawing.Point(120, 37);
            this.txtKafeninAdi.Name = "txtKafeninAdi";
            this.txtKafeninAdi.Size = new System.Drawing.Size(250, 30);
            this.txtKafeninAdi.TabIndex = 1;
            this.txtKafeninAdi.Text = "Kafe Otomasyon";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefon.Location = new System.Drawing.Point(20, 80);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(68, 23);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefon.Location = new System.Drawing.Point(120, 77);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 30);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.Text = "5448464205";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdres.Location = new System.Drawing.Point(20, 120);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(57, 23);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdres.Location = new System.Drawing.Point(120, 117);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(250, 100);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.Text = "Ankara Eryaman Kaşmir";
            // 
            // groupBoxSistem
            // 
            this.groupBoxSistem.Controls.Add(this.lblTema);
            this.groupBoxSistem.Controls.Add(this.cmbTema);
            this.groupBoxSistem.Controls.Add(this.lblYazici);
            this.groupBoxSistem.Controls.Add(this.cmbYazici);
            this.groupBoxSistem.Controls.Add(this.chkOdemeAl);
            this.groupBoxSistem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxSistem.Location = new System.Drawing.Point(450, 20);
            this.groupBoxSistem.Name = "groupBoxSistem";
            this.groupBoxSistem.Size = new System.Drawing.Size(430, 250);
            this.groupBoxSistem.TabIndex = 1;
            this.groupBoxSistem.TabStop = false;
            this.groupBoxSistem.Text = "💻 Sistem Tercihleri";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTema.Location = new System.Drawing.Point(15, 40);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(128, 23);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Ara Yüz Teması:";
            // 
            // cmbTema
            // 
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTema.Items.AddRange(new object[] {
            "Açık Tema (Mavi)",
            "Koyu Tema (Koyu Gri)",
            "Retro Tema"});
            this.cmbTema.Location = new System.Drawing.Point(160, 37);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(240, 31);
            this.cmbTema.TabIndex = 1;
            // 
            // lblYazici
            // 
            this.lblYazici.AutoSize = true;
            this.lblYazici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYazici.Location = new System.Drawing.Point(15, 80);
            this.lblYazici.Name = "lblYazici";
            this.lblYazici.Size = new System.Drawing.Size(114, 23);
            this.lblYazici.TabIndex = 2;
            this.lblYazici.Text = "Adres Yazıcısı:";
            // 
            // cmbYazici
            // 
            this.cmbYazici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYazici.Items.AddRange(new object[] {
            "Microsoft Print to PDF",
            "Mutfak Fiş Yazıcısı",
            "Kasa Yazıcısı"});
            this.cmbYazici.Location = new System.Drawing.Point(160, 77);
            this.cmbYazici.Name = "cmbYazici";
            this.cmbYazici.Size = new System.Drawing.Size(240, 31);
            this.cmbYazici.TabIndex = 3;
            // 
            // chkOdemeAl
            // 
            this.chkOdemeAl.Checked = true;
            this.chkOdemeAl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOdemeAl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkOdemeAl.Location = new System.Drawing.Point(160, 120);
            this.chkOdemeAl.Name = "chkOdemeAl";
            this.chkOdemeAl.Size = new System.Drawing.Size(260, 25);
            this.chkOdemeAl.TabIndex = 4;
            this.chkOdemeAl.Text = "Masayı Kapatırken Otomatik Fiş Yazdır";
            // 
            // groupBoxYedekleme
            // 
            this.groupBoxYedekleme.Controls.Add(this.lblYedeklemeBilgi);
            this.groupBoxYedekleme.Controls.Add(this.btnYedekle);
            this.groupBoxYedekleme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxYedekleme.Location = new System.Drawing.Point(30, 290);
            this.groupBoxYedekleme.Name = "groupBoxYedekleme";
            this.groupBoxYedekleme.Size = new System.Drawing.Size(820, 100);
            this.groupBoxYedekleme.TabIndex = 2;
            this.groupBoxYedekleme.TabStop = false;
            this.groupBoxYedekleme.Text = "💾 Veri Güvenliği ve Yedekleme";
            // 
            // lblYedeklemeBilgi
            // 
            this.lblYedeklemeBilgi.AutoSize = true;
            this.lblYedeklemeBilgi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYedeklemeBilgi.Location = new System.Drawing.Point(20, 45);
            this.lblYedeklemeBilgi.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblYedeklemeBilgi.Name = "lblYedeklemeBilgi";
            this.lblYedeklemeBilgi.Size = new System.Drawing.Size(560, 46);
            this.lblYedeklemeBilgi.TabIndex = 0;
            this.lblYedeklemeBilgi.Text = "Tüm masa, menü ve hareket kayıtlarını güvenli bir şekilde bilgisayarınıza yedekle" +
    "yebilirsiniz.";
            // 
            // btnYedekle
            // 
            this.btnYedekle.BackColor = System.Drawing.Color.Black;
            this.btnYedekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekle.ForeColor = System.Drawing.Color.White;
            this.btnYedekle.Location = new System.Drawing.Point(640, 40);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(180, 32);
            this.btnYedekle.TabIndex = 1;
            this.btnYedekle.Text = "🔄 Şimdi Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = false;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.White;
            this.panelAlt.Controls.Add(this.btnKapat);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 550);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(900, 60);
            this.panelAlt.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.Brown;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.Black;
            this.btnKapat.Location = new System.Drawing.Point(780, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 32);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(630, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 32);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "💾  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // AyarlarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AyarlarControl";
            this.Size = new System.Drawing.Size(900, 610);
            this.Load += new System.EventHandler(this.AyarlarControl_Load);
            this.panelOrta.ResumeLayout(false);
            this.groupBoxFirma.ResumeLayout(false);
            this.groupBoxFirma.PerformLayout();
            this.groupBoxSistem.ResumeLayout(false);
            this.groupBoxSistem.PerformLayout();
            this.groupBoxYedekleme.ResumeLayout(false);
            this.groupBoxYedekleme.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.GroupBox groupBoxFirma;
        private System.Windows.Forms.Label lblKafeninAdi;
        private System.Windows.Forms.TextBox txtKafeninAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.RichTextBox txtAdres;

        private System.Windows.Forms.GroupBox groupBoxSistem;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblYazici;
        private System.Windows.Forms.ComboBox cmbYazici;
        private System.Windows.Forms.CheckBox chkOdemeAl;

        private System.Windows.Forms.GroupBox groupBoxYedekleme;
        private System.Windows.Forms.Label lblYedeklemeBilgi;
        private System.Windows.Forms.Button btnYedekle;
    }
}
