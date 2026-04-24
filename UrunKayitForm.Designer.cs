namespace CafeOtomasyonu
{
    partial class UrunKayitForm
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblFiyat1 = new System.Windows.Forms.Label();
            this.numFiyat1 = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat2 = new System.Windows.Forms.Label();
            this.numFiyat2 = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat3 = new System.Windows.Forms.Label();
            this.numFiyat3 = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.lblResimSecilmedi = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.panelSagButonlar = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelSolButonlar = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.pictureBoxResim.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(816, 62);
            this.lblBaslik.TabIndex = 18;
            this.lblBaslik.Text = "Ürün Kayıt";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMenu.Location = new System.Drawing.Point(13, 73);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(159, 28);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menü :";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMenu
            // 
            this.cmbMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMenu.Items.AddRange(new object[] {
            "Sıcak İçecekler",
            "Soğuk İçecekler",
            "Tatlılar",
            "Dondurma",
            "Yiyecekler"});
            this.cmbMenu.Location = new System.Drawing.Point(180, 73);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(332, 28);
            this.cmbMenu.TabIndex = 1;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblUrunKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUrunKodu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUrunKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUrunKodu.Location = new System.Drawing.Point(13, 107);
            this.lblUrunKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(159, 28);
            this.lblUrunKodu.TabIndex = 2;
            this.lblUrunKodu.Text = "Ürün Kodu :";
            this.lblUrunKodu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunKodu.Location = new System.Drawing.Point(180, 107);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(332, 27);
            this.txtUrunKodu.TabIndex = 3;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUrunAdi.Location = new System.Drawing.Point(13, 142);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(159, 28);
            this.lblUrunAdi.TabIndex = 4;
            this.lblUrunAdi.Text = "Ürün Adı :";
            this.lblUrunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunAdi.Location = new System.Drawing.Point(180, 142);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(332, 27);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // lblFiyat1
            // 
            this.lblFiyat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblFiyat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFiyat1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiyat1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFiyat1.Location = new System.Drawing.Point(13, 176);
            this.lblFiyat1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat1.Name = "lblFiyat1";
            this.lblFiyat1.Size = new System.Drawing.Size(159, 28);
            this.lblFiyat1.TabIndex = 6;
            this.lblFiyat1.Text = "Birim Fiyatı 1 :";
            this.lblFiyat1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numFiyat1
            // 
            this.numFiyat1.DecimalPlaces = 2;
            this.numFiyat1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numFiyat1.Location = new System.Drawing.Point(180, 176);
            this.numFiyat1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFiyat1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFiyat1.Name = "numFiyat1";
            this.numFiyat1.Size = new System.Drawing.Size(333, 27);
            this.numFiyat1.TabIndex = 7;
            // 
            // lblFiyat2
            // 
            this.lblFiyat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblFiyat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFiyat2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiyat2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFiyat2.Location = new System.Drawing.Point(13, 211);
            this.lblFiyat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat2.Name = "lblFiyat2";
            this.lblFiyat2.Size = new System.Drawing.Size(159, 28);
            this.lblFiyat2.TabIndex = 8;
            this.lblFiyat2.Text = "Birim Fiyatı 2 :";
            this.lblFiyat2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numFiyat2
            // 
            this.numFiyat2.DecimalPlaces = 2;
            this.numFiyat2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numFiyat2.Location = new System.Drawing.Point(180, 211);
            this.numFiyat2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFiyat2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFiyat2.Name = "numFiyat2";
            this.numFiyat2.Size = new System.Drawing.Size(333, 27);
            this.numFiyat2.TabIndex = 9;
            // 
            // lblFiyat3
            // 
            this.lblFiyat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblFiyat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFiyat3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiyat3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFiyat3.Location = new System.Drawing.Point(13, 245);
            this.lblFiyat3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat3.Name = "lblFiyat3";
            this.lblFiyat3.Size = new System.Drawing.Size(159, 28);
            this.lblFiyat3.TabIndex = 10;
            this.lblFiyat3.Text = "Birim Fiyatı 3 :";
            this.lblFiyat3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numFiyat3
            // 
            this.numFiyat3.DecimalPlaces = 2;
            this.numFiyat3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numFiyat3.Location = new System.Drawing.Point(180, 245);
            this.numFiyat3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFiyat3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFiyat3.Name = "numFiyat3";
            this.numFiyat3.Size = new System.Drawing.Size(333, 27);
            this.numFiyat3.TabIndex = 11;
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblAciklama.Location = new System.Drawing.Point(13, 279);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(159, 123);
            this.lblAciklama.TabIndex = 12;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(180, 279);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(332, 122);
            this.txtAciklama.TabIndex = 13;
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTarih.Location = new System.Drawing.Point(13, 409);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(159, 28);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(180, 409);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(332, 27);
            this.dtTarih.TabIndex = 15;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.Controls.Add(this.lblResimSecilmedi);
            this.pictureBoxResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxResim.Location = new System.Drawing.Point(533, 68);
            this.pictureBoxResim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(213, 196);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResim.TabIndex = 16;
            this.pictureBoxResim.TabStop = false;
            this.pictureBoxResim.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblResimSecilmedi
            // 
            this.lblResimSecilmedi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResimSecilmedi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblResimSecilmedi.ForeColor = System.Drawing.Color.Gray;
            this.lblResimSecilmedi.Location = new System.Drawing.Point(0, 0);
            this.lblResimSecilmedi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResimSecilmedi.Name = "lblResimSecilmedi";
            this.lblResimSecilmedi.Size = new System.Drawing.Size(211, 194);
            this.lblResimSecilmedi.TabIndex = 0;
            this.lblResimSecilmedi.Text = "Resim Seçilmedi";
            this.lblResimSecilmedi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResimSecilmedi.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panelAlt.Controls.Add(this.panelSagButonlar);
            this.panelAlt.Controls.Add(this.panelSolButonlar);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 471);
            this.panelAlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(816, 62);
            this.panelAlt.TabIndex = 17;
            // 
            // panelSagButonlar
            // 
            this.panelSagButonlar.BackColor = System.Drawing.Color.Gray;
            this.panelSagButonlar.Controls.Add(this.btnKapat);
            this.panelSagButonlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Location = new System.Drawing.Point(689, 0);
            this.panelSagButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSagButonlar.Name = "panelSagButonlar";
            this.panelSagButonlar.Size = new System.Drawing.Size(127, 62);
            this.panelSagButonlar.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 16);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(113, 37);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelSolButonlar
            // 
            this.panelSolButonlar.BackColor = System.Drawing.Color.Gray;
            this.panelSolButonlar.Controls.Add(this.lblIslemler);
            this.panelSolButonlar.Controls.Add(this.btnKaydet);
            this.panelSolButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Location = new System.Drawing.Point(0, 0);
            this.panelSolButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSolButonlar.Name = "panelSolButonlar";
            this.panelSolButonlar.Size = new System.Drawing.Size(816, 62);
            this.panelSolButonlar.TabIndex = 1;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblIslemler.Location = new System.Drawing.Point(11, 2);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(11, 22);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 32);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "💾  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // UrunKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 533);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblFiyat1);
            this.Controls.Add(this.numFiyat1);
            this.Controls.Add(this.lblFiyat2);
            this.Controls.Add(this.numFiyat2);
            this.Controls.Add(this.lblFiyat3);
            this.Controls.Add(this.numFiyat3);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunKayitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Kaydetme";
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.pictureBoxResim.ResumeLayout(false);
            this.panelAlt.ResumeLayout(false);
            this.panelSagButonlar.ResumeLayout(false);
            this.panelSolButonlar.ResumeLayout(false);
            this.panelSolButonlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CreateLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.AutoSize  = false;
            lbl.Location  = new System.Drawing.Point(x, y);
            lbl.Size      = new System.Drawing.Size(120, 23);
            lbl.Text      = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            
            // Başlıkları kutucuk içine al (Ekran görüntüsündeki gibi gri zemin + kenarlık)
            lbl.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.Controls.Add(lbl);
        }

        private void CreateNumDown(System.Windows.Forms.NumericUpDown num, int x, int y)
        {
            num.Location = new System.Drawing.Point(x, y);
            num.Size = new System.Drawing.Size(250, 23);
            num.Font = new System.Drawing.Font("Segoe UI", 9F);
            num.DecimalPlaces = 2;
            num.Maximum = 100000;
            this.Controls.Add(num);
        }

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Label          lblMenu;
        private System.Windows.Forms.ComboBox       cmbMenu;
        private System.Windows.Forms.Label          lblUrunKodu;
        private System.Windows.Forms.TextBox        txtUrunKodu;
        private System.Windows.Forms.Label          lblUrunAdi;
        private System.Windows.Forms.TextBox        txtUrunAdi;
        private System.Windows.Forms.Label          lblFiyat1;
        private System.Windows.Forms.NumericUpDown  numFiyat1;
        private System.Windows.Forms.Label          lblFiyat2;
        private System.Windows.Forms.NumericUpDown  numFiyat2;
        private System.Windows.Forms.Label          lblFiyat3;
        private System.Windows.Forms.NumericUpDown  numFiyat3;
        private System.Windows.Forms.Label          lblAciklama;
        private System.Windows.Forms.TextBox        txtAciklama;
        private System.Windows.Forms.Label          lblTarih;
        private System.Windows.Forms.DateTimePicker dtTarih;
        
        private System.Windows.Forms.PictureBox     pictureBoxResim;
        private System.Windows.Forms.Label          lblResimSecilmedi;

        private System.Windows.Forms.Panel          panelAlt;
        private System.Windows.Forms.Panel          panelSolButonlar;
        private System.Windows.Forms.Panel          panelSagButonlar;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnKaydet;
        private System.Windows.Forms.Button         btnKapat;
    }
}
