namespace CafeOtomasyonu
{
    partial class DashboardControl
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGununCirosu = new System.Windows.Forms.Panel();
            this.lblGununCirosu = new System.Windows.Forms.Label();
            this.lblGununCirosuTitle = new System.Windows.Forms.Label();
            this.panelHaftalikCiro = new System.Windows.Forms.Panel();
            this.lblHaftalikCiro = new System.Windows.Forms.Label();
            this.lblHaftalikCiroTitle = new System.Windows.Forms.Label();
            this.panelAylikCiro = new System.Windows.Forms.Panel();
            this.lblAylikCiro = new System.Windows.Forms.Label();
            this.lblAylikCiroTitle = new System.Windows.Forms.Label();
            this.panelToplamKasa = new System.Windows.Forms.Panel();
            this.lblToplamKasa = new System.Windows.Forms.Label();
            this.lblToplamKasaTitle = new System.Windows.Forms.Label();
            this.panelAktifMasalar = new System.Windows.Forms.Panel();
            this.lblAktifMasalar = new System.Windows.Forms.Label();
            this.lblAktifMasalarTitle = new System.Windows.Forms.Label();
            this.panelPaketSiparisler = new System.Windows.Forms.Panel();
            this.lblPaketSiparisler = new System.Windows.Forms.Label();
            this.lblPaketSiparislerTitle = new System.Windows.Forms.Label();
            this.panelToplamMusteri = new System.Windows.Forms.Panel();
            this.lblToplamMusteri = new System.Windows.Forms.Label();
            this.lblToplamMusteriTitle = new System.Windows.Forms.Label();
            this.panelSatilanUrun = new System.Windows.Forms.Panel();
            this.lblSatilanUrun = new System.Windows.Forms.Label();
            this.lblSatilanUrunTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelCards.SuspendLayout();
            this.panelGununCirosu.SuspendLayout();
            this.panelHaftalikCiro.SuspendLayout();
            this.panelAylikCiro.SuspendLayout();
            this.panelToplamKasa.SuspendLayout();
            this.panelAktifMasalar.SuspendLayout();
            this.panelPaketSiparisler.SuspendLayout();
            this.panelToplamMusteri.SuspendLayout();
            this.panelSatilanUrun.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1365, 68);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Yönetim Paneli";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1227, 12);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(133, 43);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanelCards.Controls.Add(this.panelGununCirosu);
            this.flowLayoutPanelCards.Controls.Add(this.panelHaftalikCiro);
            this.flowLayoutPanelCards.Controls.Add(this.panelAylikCiro);
            this.flowLayoutPanelCards.Controls.Add(this.panelToplamKasa);
            this.flowLayoutPanelCards.Controls.Add(this.panelAktifMasalar);
            this.flowLayoutPanelCards.Controls.Add(this.panelPaketSiparisler);
            this.flowLayoutPanelCards.Controls.Add(this.panelToplamMusteri);
            this.flowLayoutPanelCards.Controls.Add(this.panelSatilanUrun);
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelCards.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(1365, 670);
            this.flowLayoutPanelCards.TabIndex = 1;
            // 
            // panelGununCirosu
            // 
            this.panelGununCirosu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panelGununCirosu.Controls.Add(this.lblGununCirosu);
            this.panelGununCirosu.Controls.Add(this.lblGununCirosuTitle);
            this.panelGununCirosu.Location = new System.Drawing.Point(47, 43);
            this.panelGununCirosu.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelGununCirosu.Name = "panelGununCirosu";
            this.panelGununCirosu.Size = new System.Drawing.Size(373, 172);
            this.panelGununCirosu.TabIndex = 0;
            // 
            // lblGununCirosu
            // 
            this.lblGununCirosu.AutoSize = true;
            this.lblGununCirosu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblGununCirosu.ForeColor = System.Drawing.Color.White;
            this.lblGununCirosu.Location = new System.Drawing.Point(20, 80);
            this.lblGununCirosu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGununCirosu.Name = "lblGununCirosu";
            this.lblGununCirosu.Size = new System.Drawing.Size(199, 50);
            this.lblGununCirosu.TabIndex = 0;
            this.lblGununCirosu.Text = "₺ 5,300.00";
            // 
            // lblGununCirosuTitle
            // 
            this.lblGununCirosuTitle.AutoSize = true;
            this.lblGununCirosuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGununCirosuTitle.ForeColor = System.Drawing.Color.White;
            this.lblGununCirosuTitle.Location = new System.Drawing.Point(20, 25);
            this.lblGununCirosuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGununCirosuTitle.Name = "lblGununCirosuTitle";
            this.lblGununCirosuTitle.Size = new System.Drawing.Size(186, 28);
            this.lblGununCirosuTitle.TabIndex = 1;
            this.lblGununCirosuTitle.Text = "📅 Günlük Kazanç";
            // 
            // panelHaftalikCiro
            // 
            this.panelHaftalikCiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.panelHaftalikCiro.Controls.Add(this.lblHaftalikCiro);
            this.panelHaftalikCiro.Controls.Add(this.lblHaftalikCiroTitle);
            this.panelHaftalikCiro.Location = new System.Drawing.Point(460, 43);
            this.panelHaftalikCiro.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelHaftalikCiro.Name = "panelHaftalikCiro";
            this.panelHaftalikCiro.Size = new System.Drawing.Size(373, 172);
            this.panelHaftalikCiro.TabIndex = 1;
            // 
            // lblHaftalikCiro
            // 
            this.lblHaftalikCiro.AutoSize = true;
            this.lblHaftalikCiro.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHaftalikCiro.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikCiro.Location = new System.Drawing.Point(20, 80);
            this.lblHaftalikCiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHaftalikCiro.Name = "lblHaftalikCiro";
            this.lblHaftalikCiro.Size = new System.Drawing.Size(220, 50);
            this.lblHaftalikCiro.TabIndex = 0;
            this.lblHaftalikCiro.Text = "₺ 45,000.00";
            // 
            // lblHaftalikCiroTitle
            // 
            this.lblHaftalikCiroTitle.AutoSize = true;
            this.lblHaftalikCiroTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHaftalikCiroTitle.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikCiroTitle.Location = new System.Drawing.Point(20, 25);
            this.lblHaftalikCiroTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHaftalikCiroTitle.Name = "lblHaftalikCiroTitle";
            this.lblHaftalikCiroTitle.Size = new System.Drawing.Size(239, 28);
            this.lblHaftalikCiroTitle.TabIndex = 1;
            this.lblHaftalikCiroTitle.Text = "🗓️ Bu Haftanın Kazancı";
            // 
            // panelAylikCiro
            // 
            this.panelAylikCiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.panelAylikCiro.Controls.Add(this.lblAylikCiro);
            this.panelAylikCiro.Controls.Add(this.lblAylikCiroTitle);
            this.panelAylikCiro.Location = new System.Drawing.Point(873, 43);
            this.panelAylikCiro.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelAylikCiro.Name = "panelAylikCiro";
            this.panelAylikCiro.Size = new System.Drawing.Size(373, 172);
            this.panelAylikCiro.TabIndex = 2;
            // 
            // lblAylikCiro
            // 
            this.lblAylikCiro.AutoSize = true;
            this.lblAylikCiro.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAylikCiro.ForeColor = System.Drawing.Color.White;
            this.lblAylikCiro.Location = new System.Drawing.Point(20, 80);
            this.lblAylikCiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAylikCiro.Name = "lblAylikCiro";
            this.lblAylikCiro.Size = new System.Drawing.Size(210, 50);
            this.lblAylikCiro.TabIndex = 0;
            this.lblAylikCiro.Text = "130,340.50";
            // 
            // lblAylikCiroTitle
            // 
            this.lblAylikCiroTitle.AutoSize = true;
            this.lblAylikCiroTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAylikCiroTitle.ForeColor = System.Drawing.Color.White;
            this.lblAylikCiroTitle.Location = new System.Drawing.Point(20, 25);
            this.lblAylikCiroTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAylikCiroTitle.Name = "lblAylikCiroTitle";
            this.lblAylikCiroTitle.Size = new System.Drawing.Size(204, 28);
            this.lblAylikCiroTitle.TabIndex = 1;
            this.lblAylikCiroTitle.Text = "📆 Bu Ay ki Kazanç ";
            // 
            // panelToplamKasa
            // 
            this.panelToplamKasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.panelToplamKasa.Controls.Add(this.lblToplamKasa);
            this.panelToplamKasa.Controls.Add(this.lblToplamKasaTitle);
            this.panelToplamKasa.Location = new System.Drawing.Point(47, 251);
            this.panelToplamKasa.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelToplamKasa.Name = "panelToplamKasa";
            this.panelToplamKasa.Size = new System.Drawing.Size(373, 172);
            this.panelToplamKasa.TabIndex = 3;
            // 
            // lblToplamKasa
            // 
            this.lblToplamKasa.AutoSize = true;
            this.lblToplamKasa.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblToplamKasa.ForeColor = System.Drawing.Color.White;
            this.lblToplamKasa.Location = new System.Drawing.Point(20, 80);
            this.lblToplamKasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamKasa.Name = "lblToplamKasa";
            this.lblToplamKasa.Size = new System.Drawing.Size(220, 50);
            this.lblToplamKasa.TabIndex = 0;
            this.lblToplamKasa.Text = "₺ 90,000.00";
            // 
            // lblToplamKasaTitle
            // 
            this.lblToplamKasaTitle.AutoSize = true;
            this.lblToplamKasaTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamKasaTitle.ForeColor = System.Drawing.Color.White;
            this.lblToplamKasaTitle.Location = new System.Drawing.Point(20, 25);
            this.lblToplamKasaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamKasaTitle.Name = "lblToplamKasaTitle";
            this.lblToplamKasaTitle.Size = new System.Drawing.Size(153, 28);
            this.lblToplamKasaTitle.TabIndex = 1;
            this.lblToplamKasaTitle.Text = "💰 Toplam Kâr";
            // 
            // panelAktifMasalar
            // 
            this.panelAktifMasalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.panelAktifMasalar.Controls.Add(this.lblAktifMasalar);
            this.panelAktifMasalar.Controls.Add(this.lblAktifMasalarTitle);
            this.panelAktifMasalar.Location = new System.Drawing.Point(460, 251);
            this.panelAktifMasalar.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelAktifMasalar.Name = "panelAktifMasalar";
            this.panelAktifMasalar.Size = new System.Drawing.Size(373, 172);
            this.panelAktifMasalar.TabIndex = 4;
            // 
            // lblAktifMasalar
            // 
            this.lblAktifMasalar.AutoSize = true;
            this.lblAktifMasalar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAktifMasalar.ForeColor = System.Drawing.Color.White;
            this.lblAktifMasalar.Location = new System.Drawing.Point(20, 80);
            this.lblAktifMasalar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAktifMasalar.Name = "lblAktifMasalar";
            this.lblAktifMasalar.Size = new System.Drawing.Size(111, 50);
            this.lblAktifMasalar.TabIndex = 0;
            this.lblAktifMasalar.Text = "5/ 25";
            // 
            // lblAktifMasalarTitle
            // 
            this.lblAktifMasalarTitle.AutoSize = true;
            this.lblAktifMasalarTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAktifMasalarTitle.ForeColor = System.Drawing.Color.White;
            this.lblAktifMasalarTitle.Location = new System.Drawing.Point(20, 25);
            this.lblAktifMasalarTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAktifMasalarTitle.Name = "lblAktifMasalarTitle";
            this.lblAktifMasalarTitle.Size = new System.Drawing.Size(227, 28);
            this.lblAktifMasalarTitle.TabIndex = 1;
            this.lblAktifMasalarTitle.Text = "🍴 Boş / Dolu Masalar";
            // 
            // panelPaketSiparisler
            // 
            this.panelPaketSiparisler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelPaketSiparisler.Controls.Add(this.lblPaketSiparisler);
            this.panelPaketSiparisler.Controls.Add(this.lblPaketSiparislerTitle);
            this.panelPaketSiparisler.Location = new System.Drawing.Point(873, 251);
            this.panelPaketSiparisler.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelPaketSiparisler.Name = "panelPaketSiparisler";
            this.panelPaketSiparisler.Size = new System.Drawing.Size(373, 172);
            this.panelPaketSiparisler.TabIndex = 5;
            // 
            // lblPaketSiparisler
            // 
            this.lblPaketSiparisler.AutoSize = true;
            this.lblPaketSiparisler.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPaketSiparisler.ForeColor = System.Drawing.Color.White;
            this.lblPaketSiparisler.Location = new System.Drawing.Point(20, 80);
            this.lblPaketSiparisler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaketSiparisler.Name = "lblPaketSiparisler";
            this.lblPaketSiparisler.Size = new System.Drawing.Size(43, 50);
            this.lblPaketSiparisler.TabIndex = 0;
            this.lblPaketSiparisler.Text = "0";
            // 
            // lblPaketSiparislerTitle
            // 
            this.lblPaketSiparislerTitle.AutoSize = true;
            this.lblPaketSiparislerTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaketSiparislerTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaketSiparislerTitle.Location = new System.Drawing.Point(20, 25);
            this.lblPaketSiparislerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaketSiparislerTitle.Name = "lblPaketSiparislerTitle";
            this.lblPaketSiparislerTitle.Size = new System.Drawing.Size(216, 28);
            this.lblPaketSiparislerTitle.TabIndex = 1;
            this.lblPaketSiparislerTitle.Text = "🛵 Bekleyen Paketler";
            // 
            // panelToplamMusteri
            // 
            this.panelToplamMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.panelToplamMusteri.Controls.Add(this.lblToplamMusteri);
            this.panelToplamMusteri.Controls.Add(this.lblToplamMusteriTitle);
            this.panelToplamMusteri.Location = new System.Drawing.Point(47, 459);
            this.panelToplamMusteri.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelToplamMusteri.Name = "panelToplamMusteri";
            this.panelToplamMusteri.Size = new System.Drawing.Size(373, 172);
            this.panelToplamMusteri.TabIndex = 6;
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.AutoSize = true;
            this.lblToplamMusteri.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblToplamMusteri.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteri.Location = new System.Drawing.Point(20, 80);
            this.lblToplamMusteri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.Size = new System.Drawing.Size(85, 50);
            this.lblToplamMusteri.TabIndex = 0;
            this.lblToplamMusteri.Text = "706";
            // 
            // lblToplamMusteriTitle
            // 
            this.lblToplamMusteriTitle.AutoSize = true;
            this.lblToplamMusteriTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamMusteriTitle.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteriTitle.Location = new System.Drawing.Point(20, 25);
            this.lblToplamMusteriTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamMusteriTitle.Name = "lblToplamMusteriTitle";
            this.lblToplamMusteriTitle.Size = new System.Drawing.Size(211, 28);
            this.lblToplamMusteriTitle.TabIndex = 1;
            this.lblToplamMusteriTitle.Text = "👥 Kayıtlı Müşteriler";
            // 
            // panelSatilanUrun
            // 
            this.panelSatilanUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.panelSatilanUrun.Controls.Add(this.lblSatilanUrun);
            this.panelSatilanUrun.Controls.Add(this.lblSatilanUrunTitle);
            this.panelSatilanUrun.Location = new System.Drawing.Point(460, 459);
            this.panelSatilanUrun.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelSatilanUrun.Name = "panelSatilanUrun";
            this.panelSatilanUrun.Size = new System.Drawing.Size(373, 172);
            this.panelSatilanUrun.TabIndex = 7;
            // 
            // lblSatilanUrun
            // 
            this.lblSatilanUrun.AutoSize = true;
            this.lblSatilanUrun.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSatilanUrun.ForeColor = System.Drawing.Color.White;
            this.lblSatilanUrun.Location = new System.Drawing.Point(20, 80);
            this.lblSatilanUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSatilanUrun.Name = "lblSatilanUrun";
            this.lblSatilanUrun.Size = new System.Drawing.Size(85, 50);
            this.lblSatilanUrun.TabIndex = 0;
            this.lblSatilanUrun.Text = "237";
            // 
            // lblSatilanUrunTitle
            // 
            this.lblSatilanUrunTitle.AutoSize = true;
            this.lblSatilanUrunTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSatilanUrunTitle.ForeColor = System.Drawing.Color.White;
            this.lblSatilanUrunTitle.Location = new System.Drawing.Point(20, 25);
            this.lblSatilanUrunTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSatilanUrunTitle.Name = "lblSatilanUrunTitle";
            this.lblSatilanUrunTitle.Size = new System.Drawing.Size(291, 28);
            this.lblSatilanUrunTitle.TabIndex = 1;
            this.lblSatilanUrunTitle.Text = "☕ Bugün Satılan Ürün Adedi";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1365, 738);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.flowLayoutPanelCards.ResumeLayout(false);
            this.panelGununCirosu.ResumeLayout(false);
            this.panelGununCirosu.PerformLayout();
            this.panelHaftalikCiro.ResumeLayout(false);
            this.panelHaftalikCiro.PerformLayout();
            this.panelAylikCiro.ResumeLayout(false);
            this.panelAylikCiro.PerformLayout();
            this.panelToplamKasa.ResumeLayout(false);
            this.panelToplamKasa.PerformLayout();
            this.panelAktifMasalar.ResumeLayout(false);
            this.panelAktifMasalar.PerformLayout();
            this.panelPaketSiparisler.ResumeLayout(false);
            this.panelPaketSiparisler.PerformLayout();
            this.panelToplamMusteri.ResumeLayout(false);
            this.panelToplamMusteri.PerformLayout();
            this.panelSatilanUrun.ResumeLayout(false);
            this.panelSatilanUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        
        // Row 1
        private System.Windows.Forms.Panel panelGununCirosu;
        private System.Windows.Forms.Label lblGununCirosuTitle;
        private System.Windows.Forms.Label lblGununCirosu;

        private System.Windows.Forms.Panel panelHaftalikCiro;
        private System.Windows.Forms.Label lblHaftalikCiroTitle;
        private System.Windows.Forms.Label lblHaftalikCiro;

        private System.Windows.Forms.Panel panelAylikCiro;
        private System.Windows.Forms.Label lblAylikCiroTitle;
        private System.Windows.Forms.Label lblAylikCiro;

        private System.Windows.Forms.Panel panelToplamKasa;
        private System.Windows.Forms.Label lblToplamKasaTitle;
        private System.Windows.Forms.Label lblToplamKasa;

        // Row 2
        private System.Windows.Forms.Panel panelAktifMasalar;
        private System.Windows.Forms.Label lblAktifMasalarTitle;
        private System.Windows.Forms.Label lblAktifMasalar;

        private System.Windows.Forms.Panel panelPaketSiparisler;
        private System.Windows.Forms.Label lblPaketSiparislerTitle;
        private System.Windows.Forms.Label lblPaketSiparisler;

        private System.Windows.Forms.Panel panelToplamMusteri;
        private System.Windows.Forms.Label lblToplamMusteriTitle;
        private System.Windows.Forms.Label lblToplamMusteri;

        private System.Windows.Forms.Panel panelSatilanUrun;
        private System.Windows.Forms.Label lblSatilanUrunTitle;
        private System.Windows.Forms.Label lblSatilanUrun;
    }
}
