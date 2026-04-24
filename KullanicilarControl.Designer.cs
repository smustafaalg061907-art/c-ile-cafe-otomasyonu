namespace CafeOtomasyonu
{
    partial class KullanicilarControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblGroupText = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnRoller = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelIslemlerSag = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Kullanıcılar";
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
            this.panelGroup.TabIndex = 2;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(0, 98);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1365, 576);
            this.dataGridView.TabIndex = 0;
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.Gray;
            this.panelIslemler.Controls.Add(this.lblIslemler);
            this.panelIslemler.Controls.Add(this.btnYeni);
            this.panelIslemler.Controls.Add(this.btnGuncelle);
            this.panelIslemler.Controls.Add(this.btnRoller);
            this.panelIslemler.Controls.Add(this.btnKaydet);
            this.panelIslemler.Controls.Add(this.panelIslemlerSag);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 674);
            this.panelIslemler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1365, 64);
            this.panelIslemler.TabIndex = 1;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location = new System.Drawing.Point(22, 5);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(22, 20);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(133, 34);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "✚  Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(166, 20);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(147, 34);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "✎  Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnRoller
            // 
            this.btnRoller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.btnRoller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoller.FlatAppearance.BorderSize = 0;
            this.btnRoller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoller.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoller.ForeColor = System.Drawing.Color.White;
            this.btnRoller.Location = new System.Drawing.Point(323, 20);
            this.btnRoller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoller.Name = "btnRoller";
            this.btnRoller.Size = new System.Drawing.Size(133, 34);
            this.btnRoller.TabIndex = 3;
            this.btnRoller.Text = "👤  Roller";
            this.btnRoller.UseVisualStyleBackColor = false;
            this.btnRoller.Click += new System.EventHandler(this.btnRoller_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(467, 20);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "💾  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
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
            this.panelIslemlerSag.TabIndex = 5;
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
            // KullanicilarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KullanicilarControl";
            this.Size = new System.Drawing.Size(1365, 738);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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

        #endregion

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Panel          panelGroup;
        private System.Windows.Forms.Label          lblGroupText;
        private System.Windows.Forms.Label          lblSearch;
        private System.Windows.Forms.DataGridView   dataGridView;
        private System.Windows.Forms.Panel          panelIslemler;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnYeni;
        private System.Windows.Forms.Button         btnGuncelle;
        private System.Windows.Forms.Button         btnRoller;
        private System.Windows.Forms.Button         btnKaydet;
        private System.Windows.Forms.Panel          panelIslemlerSag;
        private System.Windows.Forms.Button         btnKapat;
    }
}
