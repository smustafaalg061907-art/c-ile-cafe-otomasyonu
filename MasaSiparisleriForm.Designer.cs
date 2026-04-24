namespace CafeOtomasyonu
{
    partial class MasaSiparisleriForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOdemeler = new System.Windows.Forms.Panel();
            this.dataGridViewOdemeler = new System.Windows.Forms.DataGridView();
            this.colSilOdeme = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelNakitKredi = new System.Windows.Forms.Panel();
            this.btnNakit = new System.Windows.Forms.Button();
            this.btnKrediKarti = new System.Windows.Forms.Button();
            this.panelGroupOdemeler = new System.Windows.Forms.Panel();
            this.lblSearchOdemeler = new System.Windows.Forms.Label();
            this.lblGroupTextOdemeler = new System.Windows.Forms.Label();
            this.lblOdemeler = new System.Windows.Forms.Label();
            this.panelSiparisler = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colSil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAciklama = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.panelMusteri = new System.Windows.Forms.Panel();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnMusteriTemizle = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblSiparisler = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNavSiparisler = new System.Windows.Forms.Button();
            this.btnNavOdemeler = new System.Windows.Forms.Button();
            this.panelToplam = new System.Windows.Forms.Panel();
            this.lblOdenenEtiket = new System.Windows.Forms.Label();
            this.lblOdenen = new System.Windows.Forms.Label();
            this.lblKalanEtiket = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblIndToplamıEtiket = new System.Windows.Forms.Label();
            this.lblIndToplamı = new System.Windows.Forms.Label();
            this.lblIndOraniEtiket = new System.Windows.Forms.Label();
            this.lblIndOrani = new System.Windows.Forms.Label();
            this.lblToplamEtiket = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblIndliToplamEtiket = new System.Windows.Forms.Label();
            this.lblIndliToplam = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnYenileListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelIslemlerSag = new System.Windows.Forms.Panel();
            this.btnSonuclandır = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelOdemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).BeginInit();
            this.panelNakitKredi.SuspendLayout();
            this.panelGroupOdemeler.SuspendLayout();
            this.panelSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelAciklama.SuspendLayout();
            this.panelMusteri.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelToplam.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1413, 66);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Masa Siparişleri";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelOdemeler);
            this.panelMain.Controls.Add(this.panelSiparisler);
            this.panelMain.Controls.Add(this.panelSidebar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 66);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1413, 638);
            this.panelMain.TabIndex = 0;
            // 
            // panelOdemeler
            // 
            this.panelOdemeler.BackColor = System.Drawing.Color.White;
            this.panelOdemeler.Controls.Add(this.dataGridViewOdemeler);
            this.panelOdemeler.Controls.Add(this.panelNakitKredi);
            this.panelOdemeler.Controls.Add(this.panelGroupOdemeler);
            this.panelOdemeler.Controls.Add(this.lblOdemeler);
            this.panelOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOdemeler.Location = new System.Drawing.Point(59, 0);
            this.panelOdemeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOdemeler.Name = "panelOdemeler";
            this.panelOdemeler.Size = new System.Drawing.Size(1354, 638);
            this.panelOdemeler.TabIndex = 0;
            this.panelOdemeler.Visible = false;
            // 
            // dataGridViewOdemeler
            // 
            this.dataGridViewOdemeler.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGridViewOdemeler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOdemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewOdemeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOdemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSilOdeme});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOdemeler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOdemeler.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewOdemeler.Location = new System.Drawing.Point(0, 71);
            this.dataGridViewOdemeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOdemeler.Name = "dataGridViewOdemeler";
            this.dataGridViewOdemeler.RowHeadersWidth = 18;
            this.dataGridViewOdemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdemeler.Size = new System.Drawing.Size(1354, 518);
            this.dataGridViewOdemeler.TabIndex = 0;
            this.dataGridViewOdemeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdemeler_CellClick);
            // 
            // colSilOdeme
            // 
            this.colSilOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSilOdeme.HeaderText = "Sil";
            this.colSilOdeme.MinimumWidth = 6;
            this.colSilOdeme.Name = "colSilOdeme";
            this.colSilOdeme.Width = 35;
            // 
            // panelNakitKredi
            // 
            this.panelNakitKredi.BackColor = System.Drawing.Color.Gray;
            this.panelNakitKredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNakitKredi.Controls.Add(this.btnNakit);
            this.panelNakitKredi.Controls.Add(this.btnKrediKarti);
            this.panelNakitKredi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNakitKredi.Location = new System.Drawing.Point(0, 589);
            this.panelNakitKredi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNakitKredi.Name = "panelNakitKredi";
            this.panelNakitKredi.Size = new System.Drawing.Size(1354, 49);
            this.panelNakitKredi.TabIndex = 1;
            // 
            // btnNakit
            // 
            this.btnNakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNakit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNakit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNakit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNakit.ForeColor = System.Drawing.Color.Black;
            this.btnNakit.Location = new System.Drawing.Point(8, 9);
            this.btnNakit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(120, 32);
            this.btnNakit.TabIndex = 0;
            this.btnNakit.Text = "Nakit";
            this.btnNakit.UseVisualStyleBackColor = false;
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // btnKrediKarti
            // 
            this.btnKrediKarti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKrediKarti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKrediKarti.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKrediKarti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrediKarti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKrediKarti.ForeColor = System.Drawing.Color.Black;
            this.btnKrediKarti.Location = new System.Drawing.Point(139, 9);
            this.btnKrediKarti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKrediKarti.Name = "btnKrediKarti";
            this.btnKrediKarti.Size = new System.Drawing.Size(133, 32);
            this.btnKrediKarti.TabIndex = 1;
            this.btnKrediKarti.Text = "Kredi Kartı";
            this.btnKrediKarti.UseVisualStyleBackColor = false;
            this.btnKrediKarti.Click += new System.EventHandler(this.btnKrediKarti_Click);
            // 
            // panelGroupOdemeler
            // 
            this.panelGroupOdemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelGroupOdemeler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroupOdemeler.Controls.Add(this.lblSearchOdemeler);
            this.panelGroupOdemeler.Controls.Add(this.lblGroupTextOdemeler);
            this.panelGroupOdemeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroupOdemeler.Location = new System.Drawing.Point(0, 42);
            this.panelGroupOdemeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGroupOdemeler.Name = "panelGroupOdemeler";
            this.panelGroupOdemeler.Size = new System.Drawing.Size(1354, 29);
            this.panelGroupOdemeler.TabIndex = 2;
            // 
            // lblSearchOdemeler
            // 
            this.lblSearchOdemeler.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearchOdemeler.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearchOdemeler.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchOdemeler.Location = new System.Drawing.Point(1320, 0);
            this.lblSearchOdemeler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchOdemeler.Name = "lblSearchOdemeler";
            this.lblSearchOdemeler.Size = new System.Drawing.Size(32, 27);
            this.lblSearchOdemeler.TabIndex = 0;
            this.lblSearchOdemeler.Text = "🔍";
            this.lblSearchOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupTextOdemeler
            // 
            this.lblGroupTextOdemeler.AutoSize = true;
            this.lblGroupTextOdemeler.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupTextOdemeler.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupTextOdemeler.Location = new System.Drawing.Point(8, 5);
            this.lblGroupTextOdemeler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupTextOdemeler.Name = "lblGroupTextOdemeler";
            this.lblGroupTextOdemeler.Size = new System.Drawing.Size(331, 19);
            this.lblGroupTextOdemeler.TabIndex = 1;
            this.lblGroupTextOdemeler.Text = "Drag a column header here to group by that column";
            // 
            // lblOdemeler
            // 
            this.lblOdemeler.BackColor = System.Drawing.Color.Gray;
            this.lblOdemeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOdemeler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOdemeler.ForeColor = System.Drawing.Color.White;
            this.lblOdemeler.Location = new System.Drawing.Point(0, 0);
            this.lblOdemeler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeler.Name = "lblOdemeler";
            this.lblOdemeler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblOdemeler.Size = new System.Drawing.Size(1354, 42);
            this.lblOdemeler.TabIndex = 3;
            this.lblOdemeler.Text = "Ödemeler";
            this.lblOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSiparisler
            // 
            this.panelSiparisler.BackColor = System.Drawing.Color.White;
            this.panelSiparisler.Controls.Add(this.dataGridView);
            this.panelSiparisler.Controls.Add(this.panelAciklama);
            this.panelSiparisler.Controls.Add(this.panelMusteri);
            this.panelSiparisler.Controls.Add(this.lblSiparisler);
            this.panelSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSiparisler.Location = new System.Drawing.Point(59, 0);
            this.panelSiparisler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSiparisler.Name = "panelSiparisler";
            this.panelSiparisler.Size = new System.Drawing.Size(1354, 638);
            this.panelSiparisler.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSil});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(0, 150);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1354, 488);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // colSil
            // 
            this.colSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSil.HeaderText = "Sil";
            this.colSil.MinimumWidth = 6;
            this.colSil.Name = "colSil";
            this.colSil.Width = 35;
            // 
            // panelAciklama
            // 
            this.panelAciklama.BackColor = System.Drawing.Color.White;
            this.panelAciklama.Controls.Add(this.txtAciklama);
            this.panelAciklama.Controls.Add(this.lblAciklama);
            this.panelAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAciklama.Location = new System.Drawing.Point(0, 84);
            this.panelAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAciklama.Name = "panelAciklama";
            this.panelAciklama.Size = new System.Drawing.Size(1354, 66);
            this.panelAciklama.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(91, 5);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(2286, 56);
            this.txtAciklama.TabIndex = 0;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAciklama.Location = new System.Drawing.Point(5, 22);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 20);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // panelMusteri
            // 
            this.panelMusteri.BackColor = System.Drawing.Color.White;
            this.panelMusteri.Controls.Add(this.dtpTarih);
            this.panelMusteri.Controls.Add(this.lblTarih);
            this.panelMusteri.Controls.Add(this.btnMusteriTemizle);
            this.panelMusteri.Controls.Add(this.cmbMusteri);
            this.panelMusteri.Controls.Add(this.lblMusteri);
            this.panelMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMusteri.Location = new System.Drawing.Point(0, 42);
            this.panelMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMusteri.Name = "panelMusteri";
            this.panelMusteri.Size = new System.Drawing.Size(1354, 42);
            this.panelMusteri.TabIndex = 2;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(553, 6);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(212, 27);
            this.dtpTarih.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarih.Location = new System.Drawing.Point(493, 10);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 20);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih :";
            // 
            // btnMusteriTemizle
            // 
            this.btnMusteriTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMusteriTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriTemizle.FlatAppearance.BorderSize = 0;
            this.btnMusteriTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriTemizle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnMusteriTemizle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriTemizle.Location = new System.Drawing.Point(440, 6);
            this.btnMusteriTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusteriTemizle.Name = "btnMusteriTemizle";
            this.btnMusteriTemizle.Size = new System.Drawing.Size(29, 26);
            this.btnMusteriTemizle.TabIndex = 2;
            this.btnMusteriTemizle.Text = "X";
            this.btnMusteriTemizle.UseVisualStyleBackColor = false;
            this.btnMusteriTemizle.Click += new System.EventHandler(this.btnMusteriTemizle_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMusteri.Location = new System.Drawing.Point(91, 6);
            this.cmbMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(345, 28);
            this.cmbMusteri.TabIndex = 3;
            this.cmbMusteri.Text = "Müşteri Seçiniz";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMusteri.Location = new System.Drawing.Point(5, 10);
            this.lblMusteri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(65, 20);
            this.lblMusteri.TabIndex = 4;
            this.lblMusteri.Text = "Müşteri :";
            // 
            // lblSiparisler
            // 
            this.lblSiparisler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSiparisler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSiparisler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.lblSiparisler.Location = new System.Drawing.Point(0, 0);
            this.lblSiparisler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiparisler.Name = "lblSiparisler";
            this.lblSiparisler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSiparisler.Size = new System.Drawing.Size(1354, 42);
            this.lblSiparisler.TabIndex = 3;
            this.lblSiparisler.Text = "Siparişler";
            this.lblSiparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Gray;
            this.panelSidebar.Controls.Add(this.btnNavSiparisler);
            this.panelSidebar.Controls.Add(this.btnNavOdemeler);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(59, 638);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnNavSiparisler
            // 
            this.btnNavSiparisler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnNavSiparisler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSiparisler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNavSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSiparisler.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnNavSiparisler.ForeColor = System.Drawing.Color.Black;
            this.btnNavSiparisler.Location = new System.Drawing.Point(5, 12);
            this.btnNavSiparisler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavSiparisler.Name = "btnNavSiparisler";
            this.btnNavSiparisler.Size = new System.Drawing.Size(48, 44);
            this.btnNavSiparisler.TabIndex = 0;
            this.btnNavSiparisler.Text = "🛒";
            this.btnNavSiparisler.UseVisualStyleBackColor = false;
            this.btnNavSiparisler.Click += new System.EventHandler(this.btnNavSiparisler_Click);
            // 
            // btnNavOdemeler
            // 
            this.btnNavOdemeler.BackColor = System.Drawing.Color.White;
            this.btnNavOdemeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOdemeler.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNavOdemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOdemeler.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnNavOdemeler.ForeColor = System.Drawing.Color.Black;
            this.btnNavOdemeler.Location = new System.Drawing.Point(5, 66);
            this.btnNavOdemeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavOdemeler.Name = "btnNavOdemeler";
            this.btnNavOdemeler.Size = new System.Drawing.Size(48, 44);
            this.btnNavOdemeler.TabIndex = 1;
            this.btnNavOdemeler.Text = "🏷";
            this.btnNavOdemeler.UseVisualStyleBackColor = false;
            this.btnNavOdemeler.Click += new System.EventHandler(this.btnNavOdemeler_Click);
            // 
            // panelToplam
            // 
            this.panelToplam.BackColor = System.Drawing.Color.Gray;
            this.panelToplam.Controls.Add(this.lblOdenenEtiket);
            this.panelToplam.Controls.Add(this.lblOdenen);
            this.panelToplam.Controls.Add(this.lblKalanEtiket);
            this.panelToplam.Controls.Add(this.lblKalan);
            this.panelToplam.Controls.Add(this.lblIndToplamıEtiket);
            this.panelToplam.Controls.Add(this.lblIndToplamı);
            this.panelToplam.Controls.Add(this.lblIndOraniEtiket);
            this.panelToplam.Controls.Add(this.lblIndOrani);
            this.panelToplam.Controls.Add(this.lblToplamEtiket);
            this.panelToplam.Controls.Add(this.lblToplam);
            this.panelToplam.Controls.Add(this.lblIndliToplamEtiket);
            this.panelToplam.Controls.Add(this.lblIndliToplam);
            this.panelToplam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToplam.Location = new System.Drawing.Point(0, 704);
            this.panelToplam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelToplam.Name = "panelToplam";
            this.panelToplam.Size = new System.Drawing.Size(1413, 71);
            this.panelToplam.TabIndex = 1;
            // 
            // lblOdenenEtiket
            // 
            this.lblOdenenEtiket.AutoSize = true;
            this.lblOdenenEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdenenEtiket.Location = new System.Drawing.Point(13, 10);
            this.lblOdenenEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdenenEtiket.Name = "lblOdenenEtiket";
            this.lblOdenenEtiket.Size = new System.Drawing.Size(68, 20);
            this.lblOdenenEtiket.TabIndex = 0;
            this.lblOdenenEtiket.Text = "Ödenen :";
            // 
            // lblOdenen
            // 
            this.lblOdenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblOdenen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdenen.ForeColor = System.Drawing.Color.White;
            this.lblOdenen.Location = new System.Drawing.Point(107, 7);
            this.lblOdenen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdenen.Name = "lblOdenen";
            this.lblOdenen.Size = new System.Drawing.Size(173, 25);
            this.lblOdenen.TabIndex = 1;
            this.lblOdenen.Text = "₺0,00";
            this.lblOdenen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanEtiket
            // 
            this.lblKalanEtiket.AutoSize = true;
            this.lblKalanEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKalanEtiket.Location = new System.Drawing.Point(13, 41);
            this.lblKalanEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanEtiket.Name = "lblKalanEtiket";
            this.lblKalanEtiket.Size = new System.Drawing.Size(53, 20);
            this.lblKalanEtiket.TabIndex = 2;
            this.lblKalanEtiket.Text = "Kalan :";
            // 
            // lblKalan
            // 
            this.lblKalan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblKalan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKalan.ForeColor = System.Drawing.Color.White;
            this.lblKalan.Location = new System.Drawing.Point(107, 38);
            this.lblKalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(173, 25);
            this.lblKalan.TabIndex = 3;
            this.lblKalan.Text = "₺0,00";
            this.lblKalan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndToplamıEtiket
            // 
            this.lblIndToplamıEtiket.AutoSize = true;
            this.lblIndToplamıEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndToplamıEtiket.Location = new System.Drawing.Point(480, 10);
            this.lblIndToplamıEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndToplamıEtiket.Name = "lblIndToplamıEtiket";
            this.lblIndToplamıEtiket.Size = new System.Drawing.Size(121, 20);
            this.lblIndToplamıEtiket.TabIndex = 4;
            this.lblIndToplamıEtiket.Text = "İndirim Toplamı :";
            // 
            // lblIndToplamı
            // 
            this.lblIndToplamı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblIndToplamı.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndToplamı.ForeColor = System.Drawing.Color.White;
            this.lblIndToplamı.Location = new System.Drawing.Point(633, 7);
            this.lblIndToplamı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndToplamı.Name = "lblIndToplamı";
            this.lblIndToplamı.Size = new System.Drawing.Size(160, 25);
            this.lblIndToplamı.TabIndex = 5;
            this.lblIndToplamı.Text = "₺0,00";
            this.lblIndToplamı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndOraniEtiket
            // 
            this.lblIndOraniEtiket.AutoSize = true;
            this.lblIndOraniEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndOraniEtiket.Location = new System.Drawing.Point(480, 41);
            this.lblIndOraniEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndOraniEtiket.Name = "lblIndOraniEtiket";
            this.lblIndOraniEtiket.Size = new System.Drawing.Size(125, 20);
            this.lblIndOraniEtiket.TabIndex = 6;
            this.lblIndOraniEtiket.Text = "İndirim Oranı(%) :";
            // 
            // lblIndOrani
            // 
            this.lblIndOrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblIndOrani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndOrani.ForeColor = System.Drawing.Color.White;
            this.lblIndOrani.Location = new System.Drawing.Point(633, 38);
            this.lblIndOrani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndOrani.Name = "lblIndOrani";
            this.lblIndOrani.Size = new System.Drawing.Size(160, 25);
            this.lblIndOrani.TabIndex = 7;
            this.lblIndOrani.Text = "%0,00";
            this.lblIndOrani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamEtiket
            // 
            this.lblToplamEtiket.AutoSize = true;
            this.lblToplamEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblToplamEtiket.Location = new System.Drawing.Point(960, 10);
            this.lblToplamEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamEtiket.Name = "lblToplamEtiket";
            this.lblToplamEtiket.Size = new System.Drawing.Size(66, 20);
            this.lblToplamEtiket.TabIndex = 8;
            this.lblToplamEtiket.Text = "Toplam :";
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(1053, 7);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(173, 25);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "₺0,00";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndliToplamEtiket
            // 
            this.lblIndliToplamEtiket.AutoSize = true;
            this.lblIndliToplamEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndliToplamEtiket.Location = new System.Drawing.Point(960, 41);
            this.lblIndliToplamEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndliToplamEtiket.Name = "lblIndliToplamEtiket";
            this.lblIndliToplamEtiket.Size = new System.Drawing.Size(125, 20);
            this.lblIndliToplamEtiket.TabIndex = 10;
            this.lblIndliToplamEtiket.Text = "İndirimli Toplam :";
            // 
            // lblIndliToplam
            // 
            this.lblIndliToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblIndliToplam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndliToplam.ForeColor = System.Drawing.Color.White;
            this.lblIndliToplam.Location = new System.Drawing.Point(1093, 38);
            this.lblIndliToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndliToplam.Name = "lblIndliToplam";
            this.lblIndliToplam.Size = new System.Drawing.Size(173, 25);
            this.lblIndliToplam.TabIndex = 11;
            this.lblIndliToplam.Text = "₺0,00";
            this.lblIndliToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Controls.Add(this.btnSiparisEkle);
            this.panelIslemler.Controls.Add(this.btnYeni);
            this.panelIslemler.Controls.Add(this.btnYenileListele);
            this.panelIslemler.Controls.Add(this.btnKaydet);
            this.panelIslemler.Controls.Add(this.panelIslemlerSag);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 775);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1413, 62);
            this.panelIslemler.TabIndex = 2;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location = new System.Drawing.Point(11, 5);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSiparisEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisEkle.FlatAppearance.BorderSize = 0;
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Location = new System.Drawing.Point(11, 17);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(153, 34);
            this.btnSiparisEkle.TabIndex = 1;
            this.btnSiparisEkle.Text = "✚  Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(173, 17);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(120, 34);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "📄  Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnYenileListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenileListele.FlatAppearance.BorderSize = 0;
            this.btnYenileListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenileListele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenileListele.ForeColor = System.Drawing.Color.White;
            this.btnYenileListele.Location = new System.Drawing.Point(304, 17);
            this.btnYenileListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYenileListele.Name = "btnYenileListele";
            this.btnYenileListele.Size = new System.Drawing.Size(167, 34);
            this.btnYenileListele.TabIndex = 3;
            this.btnYenileListele.Text = "↺  Yenile-Listele";
            this.btnYenileListele.UseVisualStyleBackColor = false;
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(481, 17);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "💾  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panelIslemlerSag
            // 
            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Controls.Add(this.btnSonuclandır);
            this.panelIslemlerSag.Controls.Add(this.btnKapat);
            this.panelIslemlerSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Location = new System.Drawing.Point(1133, 0);
            this.panelIslemlerSag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemlerSag.Name = "panelIslemlerSag";
            this.panelIslemlerSag.Size = new System.Drawing.Size(280, 62);
            this.panelIslemlerSag.TabIndex = 5;
            // 
            // btnSonuclandır
            // 
            this.btnSonuclandır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSonuclandır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonuclandır.FlatAppearance.BorderSize = 0;
            this.btnSonuclandır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonuclandır.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSonuclandır.ForeColor = System.Drawing.Color.White;
            this.btnSonuclandır.Location = new System.Drawing.Point(7, 14);
            this.btnSonuclandır.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSonuclandır.Name = "btnSonuclandır";
            this.btnSonuclandır.Size = new System.Drawing.Size(171, 34);
            this.btnSonuclandır.TabIndex = 0;
            this.btnSonuclandır.Text = "✔  Sonuçlandır";
            this.btnSonuclandır.UseVisualStyleBackColor = false;
            this.btnSonuclandır.Click += new System.EventHandler(this.btnSonuclandır_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(187, 14);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 34);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "✖  Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // MasaSiparisleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 837);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelToplam);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasaSiparisleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMain.ResumeLayout(false);
            this.panelOdemeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).EndInit();
            this.panelNakitKredi.ResumeLayout(false);
            this.panelGroupOdemeler.ResumeLayout(false);
            this.panelGroupOdemeler.PerformLayout();
            this.panelSiparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelAciklama.ResumeLayout(false);
            this.panelAciklama.PerformLayout();
            this.panelMusteri.ResumeLayout(false);
            this.panelMusteri.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelToplam.ResumeLayout(false);
            this.panelToplam.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private static void KurIslemButon(System.Windows.Forms.Button btn, string name, string text,
                                          System.Drawing.Color renk, int x, int y, int w)
        {
            btn.BackColor                = renk;
            btn.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font                     = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor                = System.Drawing.Color.White;
            btn.Location                 = new System.Drawing.Point(x, y);
            btn.Name                     = name;
            btn.Size                     = new System.Drawing.Size(w, 28);
            btn.Text                     = text;
            btn.Cursor                   = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Label     lblBaslik;
        private System.Windows.Forms.Panel     panelMain;
        private System.Windows.Forms.Panel     panelSidebar;
        private System.Windows.Forms.Button    btnNavSiparisler;
        private System.Windows.Forms.Button    btnNavOdemeler;
        private System.Windows.Forms.Panel     panelSiparisler;
        private System.Windows.Forms.Label     lblSiparisler;
        private System.Windows.Forms.Panel     panelMusteri;
        private System.Windows.Forms.Label     lblMusteri;
        private System.Windows.Forms.ComboBox  cmbMusteri;
        private System.Windows.Forms.Button    btnMusteriTemizle;
        private System.Windows.Forms.Label     lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel     panelAciklama;
        private System.Windows.Forms.Label     lblAciklama;
        private System.Windows.Forms.TextBox   txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn colSil;
        private System.Windows.Forms.Panel     panelOdemeler;
        private System.Windows.Forms.Label     lblOdemeler;
        private System.Windows.Forms.Panel     panelGroupOdemeler;
        private System.Windows.Forms.Label     lblGroupTextOdemeler;
        private System.Windows.Forms.Label     lblSearchOdemeler;
        private System.Windows.Forms.Panel     panelNakitKredi;
        private System.Windows.Forms.Button    btnNakit;
        private System.Windows.Forms.Button    btnKrediKarti;
        private System.Windows.Forms.DataGridView dataGridViewOdemeler;
        private System.Windows.Forms.DataGridViewButtonColumn colSilOdeme;
        private System.Windows.Forms.Panel     panelToplam;
        private System.Windows.Forms.Label     lblOdenenEtiket;
        private System.Windows.Forms.Label     lblOdenen;
        private System.Windows.Forms.Label     lblKalanEtiket;
        private System.Windows.Forms.Label     lblKalan;
        private System.Windows.Forms.Label     lblIndToplamıEtiket;
        private System.Windows.Forms.Label     lblIndToplamı;
        private System.Windows.Forms.Label     lblIndOraniEtiket;
        private System.Windows.Forms.Label     lblIndOrani;
        private System.Windows.Forms.Label     lblToplamEtiket;
        private System.Windows.Forms.Label     lblToplam;
        private System.Windows.Forms.Label     lblIndliToplamEtiket;
        private System.Windows.Forms.Label     lblIndliToplam;
        private System.Windows.Forms.Panel     panelIslemler;
        private System.Windows.Forms.Label     lblIslemler;
        private System.Windows.Forms.Button    btnSiparisEkle;
        private System.Windows.Forms.Button    btnYeni;
        private System.Windows.Forms.Button    btnYenileListele;
        private System.Windows.Forms.Button    btnKaydet;
        private System.Windows.Forms.Panel     panelIslemlerSag;
        private System.Windows.Forms.Button    btnSonuclandır;
        private System.Windows.Forms.Button    btnKapat;
    }
}
