namespace CafeOtomasyonu
{
    partial class MasaKayitForm
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
            this.panelAltDusuk = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblMasaAdi = new System.Windows.Forms.Label();
            this.txtMasaAdi = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.panelAltDusuk.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(613, 74);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Masa Kayıt";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.BackColor = System.Drawing.Color.Gray;
            this.panelAltDusuk.Controls.Add(this.btnKapat);
            this.panelAltDusuk.Controls.Add(this.btnKaydet);
            this.panelAltDusuk.Controls.Add(this.panelIslemler);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 333);
            this.panelAltDusuk.Margin = new System.Windows.Forms.Padding(4);
            this.panelAltDusuk.Name = "panelAltDusuk";
            this.panelAltDusuk.Size = new System.Drawing.Size(613, 98);
            this.panelAltDusuk.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(471, 39);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(127, 47);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.Location = new System.Drawing.Point(16, 39);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 47);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "💾 Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(613, 31);
            this.panelIslemler.TabIndex = 0;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblIslemler.Location = new System.Drawing.Point(11, 6);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(13, 0, 13, 12);
            this.panelMain.Size = new System.Drawing.Size(613, 259);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.lblMasaAdi, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtMasaAdi, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAciklama, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtAciklama, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(13, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(587, 247);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblMasaAdi
            // 
            this.lblMasaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMasaAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMasaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMasaAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMasaAdi.ForeColor = System.Drawing.Color.White;
            this.lblMasaAdi.Location = new System.Drawing.Point(0, 0);
            this.lblMasaAdi.Margin = new System.Windows.Forms.Padding(0, 0, 3, 6);
            this.lblMasaAdi.Name = "lblMasaAdi";
            this.lblMasaAdi.Size = new System.Drawing.Size(173, 37);
            this.lblMasaAdi.TabIndex = 0;
            this.lblMasaAdi.Text = "Masa Adı :";
            this.lblMasaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasaAdi
            // 
            this.txtMasaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMasaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMasaAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMasaAdi.Location = new System.Drawing.Point(176, 0);
            this.txtMasaAdi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtMasaAdi.Multiline = true;
            this.txtMasaAdi.Name = "txtMasaAdi";
            this.txtMasaAdi.Size = new System.Drawing.Size(411, 37);
            this.txtMasaAdi.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(0, 43);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(173, 204);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAciklama.Location = new System.Drawing.Point(176, 43);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(0);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(411, 204);
            this.txtAciklama.TabIndex = 3;
            // 
            // MasaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 431);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAltDusuk);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasaKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Masa Kayıt";
            this.panelAltDusuk.ResumeLayout(false);
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblMasaAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtMasaAdi;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}
