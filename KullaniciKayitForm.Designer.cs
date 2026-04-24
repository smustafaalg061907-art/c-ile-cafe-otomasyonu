namespace CafeOtomasyonu
{
    partial class KullaniciKayitForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.toggleDurum = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGorevi = new System.Windows.Forms.Label();
            this.txtGorevi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParolaTekrar = new System.Windows.Forms.Label();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDurum.Properties)).BeginInit();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(579, 55);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "👨‍💼 Yeni Kullanıcı Kayıt";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblDurumu, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.toggleDurum, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAdSoyad, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtAdSoyad, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblTelefon, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtTelefon, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblAdres, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAdres, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblEmail, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.txtEmail, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblGorevi, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtGorevi, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblKullaniciAdi, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtKullaniciAdi, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.lblParola, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.txtParola, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblParolaTekrar, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.txtParolaTekrar, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.lblSoru, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.txtSoru, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.lblCevap, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.txtCevap, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.lblAciklama, 0, 11);
            this.tableLayoutPanel.Controls.Add(this.txtAciklama, 1, 11);
            this.tableLayoutPanel.Location = new System.Drawing.Point(16, 59);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 12;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(547, 544);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblDurumu
            // 
            this.lblDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDurumu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDurumu.ForeColor = System.Drawing.Color.White;
            this.lblDurumu.Location = new System.Drawing.Point(5, 1);
            this.lblDurumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(152, 37);
            this.lblDurumu.TabIndex = 0;
            this.lblDurumu.Text = "Durumu :";
            this.lblDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleDurum
            // 
            this.toggleDurum.Location = new System.Drawing.Point(166, 5);
            this.toggleDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleDurum.Name = "toggleDurum";
            this.toggleDurum.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggleDurum.Properties.Appearance.Options.UseForeColor = true;
            this.toggleDurum.Properties.OffText = "Aktif Değil";
            this.toggleDurum.Properties.OnText = "Aktif";
            this.toggleDurum.Size = new System.Drawing.Size(160, 24);
            this.toggleDurum.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(5, 39);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(152, 37);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad :";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdSoyad.Location = new System.Drawing.Point(163, 44);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(382, 27);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.ForeColor = System.Drawing.Color.White;
            this.lblTelefon.Location = new System.Drawing.Point(5, 77);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(152, 37);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon :";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefon.Location = new System.Drawing.Point(163, 82);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(382, 27);
            this.txtTelefon.TabIndex = 4;
            // 
            // lblAdres
            // 
            this.lblAdres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdres.ForeColor = System.Drawing.Color.White;
            this.lblAdres.Location = new System.Drawing.Point(5, 115);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(152, 80);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres :";
            this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdres.Location = new System.Drawing.Point(163, 120);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(382, 70);
            this.txtAdres.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(5, 196);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 37);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(163, 201);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // lblGorevi
            // 
            this.lblGorevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGorevi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGorevi.ForeColor = System.Drawing.Color.White;
            this.lblGorevi.Location = new System.Drawing.Point(5, 234);
            this.lblGorevi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGorevi.Name = "lblGorevi";
            this.lblGorevi.Size = new System.Drawing.Size(152, 37);
            this.lblGorevi.TabIndex = 9;
            this.lblGorevi.Text = "Görevi :";
            this.lblGorevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGorevi
            // 
            this.txtGorevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGorevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGorevi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGorevi.Location = new System.Drawing.Point(163, 239);
            this.txtGorevi.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Size = new System.Drawing.Size(382, 27);
            this.txtGorevi.TabIndex = 10;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(5, 272);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(152, 37);
            this.lblKullaniciAdi.TabIndex = 11;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(163, 277);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(382, 27);
            this.txtKullaniciAdi.TabIndex = 12;
            // 
            // lblParola
            // 
            this.lblParola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParola.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(5, 310);
            this.lblParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(152, 37);
            this.lblParola.TabIndex = 13;
            this.lblParola.Text = "Parola :";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParola
            // 
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParola.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParola.Location = new System.Drawing.Point(163, 315);
            this.txtParola.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '●';
            this.txtParola.Size = new System.Drawing.Size(382, 27);
            this.txtParola.TabIndex = 14;
            // 
            // lblParolaTekrar
            // 
            this.lblParolaTekrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParolaTekrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblParolaTekrar.ForeColor = System.Drawing.Color.White;
            this.lblParolaTekrar.Location = new System.Drawing.Point(5, 348);
            this.lblParolaTekrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParolaTekrar.Name = "lblParolaTekrar";
            this.lblParolaTekrar.Size = new System.Drawing.Size(152, 37);
            this.lblParolaTekrar.TabIndex = 15;
            this.lblParolaTekrar.Text = "Parola Tekrar :";
            this.lblParolaTekrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParolaTekrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParolaTekrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParolaTekrar.Location = new System.Drawing.Point(163, 353);
            this.txtParolaTekrar.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.PasswordChar = '●';
            this.txtParolaTekrar.Size = new System.Drawing.Size(382, 27);
            this.txtParolaTekrar.TabIndex = 16;
            // 
            // lblSoru
            // 
            this.lblSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoru.ForeColor = System.Drawing.Color.White;
            this.lblSoru.Location = new System.Drawing.Point(5, 386);
            this.lblSoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(152, 37);
            this.lblSoru.TabIndex = 17;
            this.lblSoru.Text = "Soru :";
            this.lblSoru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoru
            // 
            this.txtSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoru.Location = new System.Drawing.Point(163, 391);
            this.txtSoru.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(382, 27);
            this.txtSoru.TabIndex = 18;
            // 
            // lblCevap
            // 
            this.lblCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCevap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCevap.ForeColor = System.Drawing.Color.White;
            this.lblCevap.Location = new System.Drawing.Point(5, 424);
            this.lblCevap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(152, 37);
            this.lblCevap.TabIndex = 19;
            this.lblCevap.Text = "Cevap :";
            this.lblCevap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCevap
            // 
            this.txtCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCevap.Location = new System.Drawing.Point(163, 429);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(382, 27);
            this.txtCevap.TabIndex = 20;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(5, 462);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(152, 81);
            this.lblAciklama.TabIndex = 21;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(163, 467);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(382, 71);
            this.txtAciklama.TabIndex = 22;
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.btnKapat);
            this.panelIslemler.Controls.Add(this.btnKaydet);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.ForeColor = System.Drawing.Color.White;
            this.panelIslemler.Location = new System.Drawing.Point(0, 617);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(579, 64);
            this.panelIslemler.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(427, 12);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 37);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(293, 12);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "💾 Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblIslemler
            // 
            this.lblIslemler.Location = new System.Drawing.Point(0, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(100, 23);
            this.lblIslemler.TabIndex = 0;
            // 
            // KullaniciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 681);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Kayıt Sayfası";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDurum.Properties)).EndInit();
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void KurLabel(System.Windows.Forms.Label lbl, string text)
        {
            lbl.Text = text;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            lbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        }

        private void KurTextBox(System.Windows.Forms.TextBox txt)
        {
            txt.Dock = System.Windows.Forms.DockStyle.Fill;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            txt.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGorevi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblParolaTekrar;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblAciklama;

        private DevExpress.XtraEditors.ToggleSwitch toggleDurum;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGorevi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtAciklama;

        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
    }
}
