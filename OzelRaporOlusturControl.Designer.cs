namespace CafeOtomasyonu
{
    partial class OzelRaporOlusturControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelGirisArea = new System.Windows.Forms.Panel();
            this.lblRaporTuru = new System.Windows.Forms.Label();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblTire = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelAltDusuk = new System.Windows.Forms.Panel();
            this.panelSagButonlar = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelSolButonlar = new System.Windows.Forms.Panel();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.panelGirisArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelAltDusuk.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.panelIslemler.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1467, 68);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = " Rapor Oluşturucu";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGirisArea
            // 
            this.panelGirisArea.BackColor = System.Drawing.Color.Gray;
            this.panelGirisArea.Controls.Add(this.lblRaporTuru);
            this.panelGirisArea.Controls.Add(this.cmbRaporTuru);
            this.panelGirisArea.Controls.Add(this.lblTarihAraligi);
            this.panelGirisArea.Controls.Add(this.dtBaslangic);
            this.panelGirisArea.Controls.Add(this.lblTire);
            this.panelGirisArea.Controls.Add(this.dtBitis);
            this.panelGirisArea.Controls.Add(this.btnCalistir);
            this.panelGirisArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGirisArea.Location = new System.Drawing.Point(0, 68);
            this.panelGirisArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGirisArea.Name = "panelGirisArea";
            this.panelGirisArea.Size = new System.Drawing.Size(1467, 98);
            this.panelGirisArea.TabIndex = 1;
            // 
            // lblRaporTuru
            // 
            this.lblRaporTuru.AutoSize = true;
            this.lblRaporTuru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRaporTuru.Location = new System.Drawing.Point(13, 37);
            this.lblRaporTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaporTuru.Name = "lblRaporTuru";
            this.lblRaporTuru.Size = new System.Drawing.Size(131, 20);
            this.lblRaporTuru.TabIndex = 0;
            this.lblRaporTuru.Text = "Hazır Rapor Türü:";
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaporTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Günlük Satış Özeti",
            "Personel Satış Performansı",
            "Masa ve Paket Servis Analizi",
            "Ürün Bazlı Satış Grafiği"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(173, 33);
            this.cmbRaporTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(332, 31);
            this.cmbRaporTuru.TabIndex = 1;
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarihAraligi.Location = new System.Drawing.Point(533, 37);
            this.lblTarihAraligi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(98, 20);
            this.lblTarihAraligi.TabIndex = 2;
            this.lblTarihAraligi.Text = "Tarih Aralığı:";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(653, 33);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(132, 27);
            this.dtBaslangic.TabIndex = 3;
            // 
            // lblTire
            // 
            this.lblTire.AutoSize = true;
            this.lblTire.Location = new System.Drawing.Point(793, 37);
            this.lblTire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTire.Name = "lblTire";
            this.lblTire.Size = new System.Drawing.Size(11, 16);
            this.lblTire.TabIndex = 4;
            this.lblTire.Text = "-";
            // 
            // dtBitis
            // 
            this.dtBitis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(813, 33);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(132, 27);
            this.dtBitis.TabIndex = 5;
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.Black;
            this.btnCalistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalistir.FlatAppearance.BorderSize = 0;
            this.btnCalistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalistir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalistir.ForeColor = System.Drawing.Color.White;
            this.btnCalistir.Location = new System.Drawing.Point(973, 25);
            this.btnCalistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(160, 49);
            this.btnCalistir.TabIndex = 6;
            this.btnCalistir.Text = "▶️ Sorgula";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 166);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1467, 467);
            this.dataGridView.TabIndex = 0;
            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.Controls.Add(this.panelSagButonlar);
            this.panelAltDusuk.Controls.Add(this.panelSolButonlar);
            this.panelAltDusuk.Controls.Add(this.panelIslemler);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 633);
            this.panelAltDusuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAltDusuk.Name = "panelAltDusuk";
            this.panelAltDusuk.Size = new System.Drawing.Size(1467, 105);
            this.panelAltDusuk.TabIndex = 3;
            // 
            // panelSagButonlar
            // 
            this.panelSagButonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSagButonlar.Controls.Add(this.btnKapat);
            this.panelSagButonlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Location = new System.Drawing.Point(1307, 31);
            this.panelSagButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSagButonlar.Name = "panelSagButonlar";
            this.panelSagButonlar.Size = new System.Drawing.Size(160, 74);
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
            this.btnKapat.Location = new System.Drawing.Point(13, 12);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(133, 43);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelSolButonlar
            // 
            this.panelSolButonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSolButonlar.Controls.Add(this.btnExcelAktar);
            this.panelSolButonlar.Controls.Add(this.btnPdfAktar);
            this.panelSolButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Location = new System.Drawing.Point(0, 31);
            this.panelSolButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSolButonlar.Name = "panelSolButonlar";
            this.panelSolButonlar.Size = new System.Drawing.Size(1467, 74);
            this.panelSolButonlar.TabIndex = 1;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExcelAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelAktar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnExcelAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelAktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelAktar.Location = new System.Drawing.Point(13, 12);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(187, 43);
            this.btnExcelAktar.TabIndex = 0;
            this.btnExcelAktar.Text = "📊 Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPdfAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfAktar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPdfAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfAktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdfAktar.Location = new System.Drawing.Point(213, 12);
            this.btnPdfAktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(187, 43);
            this.btnPdfAktar.TabIndex = 1;
            this.btnPdfAktar.Text = "📄 PDF\'e Aktar";
            this.btnPdfAktar.UseVisualStyleBackColor = false;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1467, 31);
            this.panelIslemler.TabIndex = 2;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblIslemler.Location = new System.Drawing.Point(11, 6);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(115, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "Sonuç İşlemleri";
            // 
            // OzelRaporOlusturControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGirisArea);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAltDusuk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OzelRaporOlusturControl";
            this.Size = new System.Drawing.Size(1467, 738);
            this.Load += new System.EventHandler(this.OzelRaporOlusturControl_Load);
            this.panelGirisArea.ResumeLayout(false);
            this.panelGirisArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelAltDusuk.ResumeLayout(false);
            this.panelSagButonlar.ResumeLayout(false);
            this.panelSolButonlar.ResumeLayout(false);
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelGirisArea;
        private System.Windows.Forms.Label lblRaporTuru;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label lblTire;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Panel panelSagButonlar;
        private System.Windows.Forms.Panel panelSolButonlar;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Button btnPdfAktar;
        private System.Windows.Forms.Button btnKapat;
    }
}
