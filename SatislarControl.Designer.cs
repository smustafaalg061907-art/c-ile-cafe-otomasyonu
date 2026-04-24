namespace CafeOtomasyonu
{
    partial class SatislarControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblGroupText = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelOzet = new System.Windows.Forms.Panel();
            this.lblKayit = new System.Windows.Forms.Label();
            this.lblOzetTutar = new System.Windows.Forms.Label();
            this.lblOzetIndirim = new System.Windows.Forms.Label();
            this.lblOzetOdenen = new System.Windows.Forms.Label();
            this.lblOzetKalan = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnSiparisDetaylari = new System.Windows.Forms.Button();
            this.btnOdemeHareketleri = new System.Windows.Forms.Button();
            this.btnYenileListele = new System.Windows.Forms.Button();
            this.panelIslemlerSag = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelOzet.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1365, 66);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Satışlar";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGroup
            // 
            this.panelGroup.BackColor = System.Drawing.Color.Gray;
            this.panelGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroup.Controls.Add(this.lblSearch);
            this.panelGroup.Controls.Add(this.lblGroupText);
            this.panelGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroup.Location = new System.Drawing.Point(0, 66);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(1365, 32);
            this.panelGroup.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(1328, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(35, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupText
            // 
            this.lblGroupText.AutoSize = true;
            this.lblGroupText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupText.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupText.Location = new System.Drawing.Point(8, 6);
            this.lblGroupText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupText.Name = "lblGroupText";
            this.lblGroupText.Size = new System.Drawing.Size(331, 19);
            this.lblGroupText.TabIndex = 1;
            this.lblGroupText.Text = "Drag a column header here to group by that column";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView.Location = new System.Drawing.Point(0, 98);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1365, 540);
            this.dataGridView.TabIndex = 0;
            // 
            // panelOzet
            // 
            this.panelOzet.BackColor = System.Drawing.Color.Gray;
            this.panelOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOzet.Controls.Add(this.lblKayit);
            this.panelOzet.Controls.Add(this.lblOzetTutar);
            this.panelOzet.Controls.Add(this.lblOzetIndirim);
            this.panelOzet.Controls.Add(this.lblOzetOdenen);
            this.panelOzet.Controls.Add(this.lblOzetKalan);
            this.panelOzet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOzet.Location = new System.Drawing.Point(0, 638);
            this.panelOzet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOzet.Name = "panelOzet";
            this.panelOzet.Size = new System.Drawing.Size(1365, 36);
            this.panelOzet.TabIndex = 1;
            // 
            // lblKayit
            // 
            this.lblKayit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblKayit.Location = new System.Drawing.Point(13, 0);
            this.lblKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(147, 37);
            this.lblKayit.TabIndex = 0;
            this.lblKayit.Text = "Kayıt: 0";
            this.lblKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOzetTutar
            // 
            this.lblOzetTutar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOzetTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblOzetTutar.Location = new System.Drawing.Point(173, 0);
            this.lblOzetTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOzetTutar.Name = "lblOzetTutar";
            this.lblOzetTutar.Size = new System.Drawing.Size(173, 37);
            this.lblOzetTutar.TabIndex = 1;
            this.lblOzetTutar.Text = "Tutar=₺0,00";
            this.lblOzetTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOzetIndirim
            // 
            this.lblOzetIndirim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOzetIndirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblOzetIndirim.Location = new System.Drawing.Point(360, 0);
            this.lblOzetIndirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOzetIndirim.Name = "lblOzetIndirim";
            this.lblOzetIndirim.Size = new System.Drawing.Size(133, 37);
            this.lblOzetIndirim.TabIndex = 2;
            this.lblOzetIndirim.Text = "₺0,00";
            this.lblOzetIndirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOzetOdenen
            // 
            this.lblOzetOdenen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOzetOdenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblOzetOdenen.Location = new System.Drawing.Point(507, 0);
            this.lblOzetOdenen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOzetOdenen.Name = "lblOzetOdenen";
            this.lblOzetOdenen.Size = new System.Drawing.Size(133, 37);
            this.lblOzetOdenen.TabIndex = 3;
            this.lblOzetOdenen.Text = "₺0,00";
            this.lblOzetOdenen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOzetKalan
            // 
            this.lblOzetKalan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOzetKalan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblOzetKalan.Location = new System.Drawing.Point(653, 0);
            this.lblOzetKalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOzetKalan.Name = "lblOzetKalan";
            this.lblOzetKalan.Size = new System.Drawing.Size(133, 37);
            this.lblOzetKalan.TabIndex = 4;
            this.lblOzetKalan.Text = "₺0,00";
            this.lblOzetKalan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Controls.Add(this.btnSiparisDetaylari);
            this.panelIslemler.Controls.Add(this.btnOdemeHareketleri);
            this.panelIslemler.Controls.Add(this.btnYenileListele);
            this.panelIslemler.Controls.Add(this.panelIslemlerSag);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 674);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1365, 64);
            this.panelIslemler.TabIndex = 2;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.White;
            this.lblIslemler.Location = new System.Drawing.Point(11, 5);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // btnSiparisDetaylari
            // 
            this.btnSiparisDetaylari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSiparisDetaylari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisDetaylari.FlatAppearance.BorderSize = 0;
            this.btnSiparisDetaylari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisDetaylari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiparisDetaylari.ForeColor = System.Drawing.Color.White;
            this.btnSiparisDetaylari.Location = new System.Drawing.Point(17, 20);
            this.btnSiparisDetaylari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisDetaylari.Name = "btnSiparisDetaylari";
            this.btnSiparisDetaylari.Size = new System.Drawing.Size(187, 34);
            this.btnSiparisDetaylari.TabIndex = 1;
            this.btnSiparisDetaylari.Text = "🧾  Sipariş Detayları";
            this.btnSiparisDetaylari.UseVisualStyleBackColor = false;
            this.btnSiparisDetaylari.Click += new System.EventHandler(this.btnSiparisDetaylari_Click);
            // 
            // btnOdemeHareketleri
            // 
            this.btnOdemeHareketleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.btnOdemeHareketleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeHareketleri.FlatAppearance.BorderSize = 0;
            this.btnOdemeHareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeHareketleri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOdemeHareketleri.ForeColor = System.Drawing.Color.White;
            this.btnOdemeHareketleri.Location = new System.Drawing.Point(214, 20);
            this.btnOdemeHareketleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
            this.btnOdemeHareketleri.Size = new System.Drawing.Size(187, 34);
            this.btnOdemeHareketleri.TabIndex = 2;
            this.btnOdemeHareketleri.Text = "▶  Ödeme Hareketleri";
            this.btnOdemeHareketleri.UseVisualStyleBackColor = false;
            this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnYenileListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenileListele.FlatAppearance.BorderSize = 0;
            this.btnYenileListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenileListele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenileListele.ForeColor = System.Drawing.Color.White;
            this.btnYenileListele.Location = new System.Drawing.Point(411, 20);
            this.btnYenileListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYenileListele.Name = "btnYenileListele";
            this.btnYenileListele.Size = new System.Drawing.Size(173, 34);
            this.btnYenileListele.TabIndex = 3;
            this.btnYenileListele.Text = "↺  Yenile-Listele";
            this.btnYenileListele.UseVisualStyleBackColor = false;
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            // 
            // panelIslemlerSag
            // 
            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Controls.Add(this.btnKapat);
            this.panelIslemlerSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Location = new System.Drawing.Point(1218, 0);
            this.panelIslemlerSag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemlerSag.Name = "panelIslemlerSag";
            this.panelIslemlerSag.Size = new System.Drawing.Size(147, 64);
            this.panelIslemlerSag.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(13, 15);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 34);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "✖  Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // SatislarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelOzet);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SatislarControl";
            this.Size = new System.Drawing.Size(1365, 738);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelOzet.ResumeLayout(false);
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private static void KurIslemButon(System.Windows.Forms.Button btn, string name,
            string text, System.Drawing.Color renk, int x, int y, int w)
        {
            btn.BackColor = renk;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font      = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location  = new System.Drawing.Point(x, y);
            btn.Name      = name;
            btn.Size      = new System.Drawing.Size(w, 28);
            btn.Text      = text;
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
        }

        private static void KurOzetLabel(System.Windows.Forms.Label lbl, string name,
            string text, int x, int y, int w)
        {
            lbl.AutoSize  = false;
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lbl.Location  = new System.Drawing.Point(x, y);
            lbl.Name      = name;
            lbl.Size      = new System.Drawing.Size(w, 30);
            lbl.Text      = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        #endregion

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Panel          panelGroup;
        private System.Windows.Forms.Label          lblGroupText;
        private System.Windows.Forms.Label          lblSearch;
        private System.Windows.Forms.DataGridView   dataGridView;
        private System.Windows.Forms.Panel          panelOzet;
        private System.Windows.Forms.Label          lblKayit;
        private System.Windows.Forms.Label          lblOzetTutar;
        private System.Windows.Forms.Label          lblOzetIndirim;
        private System.Windows.Forms.Label          lblOzetOdenen;
        private System.Windows.Forms.Label          lblOzetKalan;
        private System.Windows.Forms.Panel          panelIslemler;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnSiparisDetaylari;
        private System.Windows.Forms.Button         btnOdemeHareketleri;
        private System.Windows.Forms.Button         btnYenileListele;
        private System.Windows.Forms.Panel          panelIslemlerSag;
        private System.Windows.Forms.Button         btnKapat;
    }
}
