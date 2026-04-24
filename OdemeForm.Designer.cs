namespace CafeOtomasyonu
{
    partial class OdemeForm
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
            this.lblOdemeBaslik = new System.Windows.Forms.Label();
            this.panelTutar = new System.Windows.Forms.Panel();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutarEtiket = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.panelAciklama = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.panelTarih = new System.Windows.Forms.Panel();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarihEtiket = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.panelIslemlerSag = new System.Windows.Forms.Panel();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelTutar.SuspendLayout();
            this.panelAciklama.SuspendLayout();
            this.panelTarih.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdemeBaslik
            // 
            this.lblOdemeBaslik.BackColor = System.Drawing.Color.Gray;
            this.lblOdemeBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOdemeBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOdemeBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblOdemeBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeBaslik.Name = "lblOdemeBaslik";
            this.lblOdemeBaslik.Size = new System.Drawing.Size(559, 64);
            this.lblOdemeBaslik.TabIndex = 4;
            this.lblOdemeBaslik.Text = "Nakit Ödeme";
            this.lblOdemeBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTutar
            // 
            this.panelTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTutar.Controls.Add(this.txtTutar);
            this.panelTutar.Controls.Add(this.lblTutarEtiket);
            this.panelTutar.Controls.Add(this.lblKalan);
            this.panelTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutar.Location = new System.Drawing.Point(0, 64);
            this.panelTutar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTutar.Name = "panelTutar";
            this.panelTutar.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.panelTutar.Size = new System.Drawing.Size(559, 74);
            this.panelTutar.TabIndex = 3;
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.txtTutar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTutar.ForeColor = System.Drawing.Color.White;
            this.txtTutar.Location = new System.Drawing.Point(167, 7);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(267, 27);
            this.txtTutar.TabIndex = 0;
            this.txtTutar.Text = "0,00";
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTutarEtiket
            // 
            this.lblTutarEtiket.AutoSize = true;
            this.lblTutarEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTutarEtiket.ForeColor = System.Drawing.Color.White;
            this.lblTutarEtiket.Location = new System.Drawing.Point(13, 12);
            this.lblTutarEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutarEtiket.Name = "lblTutarEtiket";
            this.lblTutarEtiket.Size = new System.Drawing.Size(120, 20);
            this.lblTutarEtiket.TabIndex = 1;
            this.lblTutarEtiket.Text = "Ödenecek Tutar :";
            // 
            // lblKalan
            // 
            this.lblKalan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKalan.ForeColor = System.Drawing.Color.Green;
            this.lblKalan.Location = new System.Drawing.Point(13, 46);
            this.lblKalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(493, 22);
            this.lblKalan.TabIndex = 2;
            this.lblKalan.Text = "Kalan: ₺0,00";
            this.lblKalan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAciklama
            // 
            this.panelAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAciklama.Controls.Add(this.txtAciklama);
            this.panelAciklama.Controls.Add(this.lblAciklama);
            this.panelAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAciklama.Location = new System.Drawing.Point(0, 138);
            this.panelAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.panelAciklama.Name = "panelAciklama";
            this.panelAciklama.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.panelAciklama.Size = new System.Drawing.Size(559, 98);
            this.panelAciklama.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(107, 7);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(452, 83);
            this.txtAciklama.TabIndex = 0;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(13, 12);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 20);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // panelTarih
            // 
            this.panelTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTarih.Controls.Add(this.dtpTarih);
            this.panelTarih.Controls.Add(this.lblTarihEtiket);
            this.panelTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTarih.Location = new System.Drawing.Point(0, 236);
            this.panelTarih.Margin = new System.Windows.Forms.Padding(4);
            this.panelTarih.Name = "panelTarih";
            this.panelTarih.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.panelTarih.Size = new System.Drawing.Size(559, 42);
            this.panelTarih.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(107, 7);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(265, 27);
            this.dtpTarih.TabIndex = 0;
            // 
            // lblTarihEtiket
            // 
            this.lblTarihEtiket.AutoSize = true;
            this.lblTarihEtiket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarihEtiket.ForeColor = System.Drawing.Color.White;
            this.lblTarihEtiket.Location = new System.Drawing.Point(13, 11);
            this.lblTarihEtiket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarihEtiket.Name = "lblTarihEtiket";
            this.lblTarihEtiket.Size = new System.Drawing.Size(47, 20);
            this.lblTarihEtiket.TabIndex = 1;
            this.lblTarihEtiket.Text = "Tarih :";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Controls.Add(this.panelIslemlerSag);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 278);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(559, 62);
            this.panelIslemler.TabIndex = 0;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location = new System.Drawing.Point(11, 20);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // panelIslemlerSag
            // 
            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Controls.Add(this.btnOnay);
            this.panelIslemlerSag.Controls.Add(this.btnKapat);
            this.panelIslemlerSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Location = new System.Drawing.Point(279, 0);
            this.panelIslemlerSag.Margin = new System.Windows.Forms.Padding(4);
            this.panelIslemlerSag.Name = "panelIslemlerSag";
            this.panelIslemlerSag.Size = new System.Drawing.Size(280, 62);
            this.panelIslemlerSag.TabIndex = 1;
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnOnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOnay.ForeColor = System.Drawing.Color.White;
            this.btnOnay.Location = new System.Drawing.Point(7, 14);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(120, 34);
            this.btnOnay.TabIndex = 0;
            this.btnOnay.Text = "✔  Onay";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(137, 14);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 34);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "✖  Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 340);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelTarih);
            this.Controls.Add(this.panelAciklama);
            this.Controls.Add(this.panelTutar);
            this.Controls.Add(this.lblOdemeBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme";
            this.panelTutar.ResumeLayout(false);
            this.panelTutar.PerformLayout();
            this.panelAciklama.ResumeLayout(false);
            this.panelAciklama.PerformLayout();
            this.panelTarih.ResumeLayout(false);
            this.panelTarih.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label     lblOdemeBaslik;
        private System.Windows.Forms.Panel     panelTutar;
        private System.Windows.Forms.Label     lblTutarEtiket;
        private System.Windows.Forms.TextBox   txtTutar;
        private System.Windows.Forms.Label     lblKalan;
        private System.Windows.Forms.Panel     panelAciklama;
        private System.Windows.Forms.Label     lblAciklama;
        private System.Windows.Forms.TextBox   txtAciklama;
        private System.Windows.Forms.Panel     panelTarih;
        private System.Windows.Forms.Label     lblTarihEtiket;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel     panelIslemler;
        private System.Windows.Forms.Label     lblIslemler;
        private System.Windows.Forms.Panel     panelIslemlerSag;
        private System.Windows.Forms.Button    btnOnay;
        private System.Windows.Forms.Button    btnKapat;
    }
}
