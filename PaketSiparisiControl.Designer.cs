namespace CafeOtomasyonu
{
    partial class PaketSiparisiControl
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
            this.panelGroupBar = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblGroupBy = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelAltDusuk = new System.Windows.Forms.Panel();
            this.panelSagButonlar = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelSolButonlar = new System.Windows.Forms.Panel();
            this.btnYeniSiparis = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.panelGroupBar.SuspendLayout();
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
            this.lblBaslik.Text = "Paket Siparişleri";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGroupBar
            // 
            this.panelGroupBar.BackColor = System.Drawing.Color.Gray;
            this.panelGroupBar.Controls.Add(this.lblSearchIcon);
            this.panelGroupBar.Controls.Add(this.lblGroupBy);
            this.panelGroupBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroupBar.Location = new System.Drawing.Point(0, 68);
            this.panelGroupBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGroupBar.Name = "panelGroupBar";
            this.panelGroupBar.Size = new System.Drawing.Size(1467, 43);
            this.panelGroupBar.TabIndex = 1;
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchIcon.Location = new System.Drawing.Point(2600, 9);
            this.lblSearchIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(33, 22);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "🔍";
            // 
            // lblGroupBy
            // 
            this.lblGroupBy.AutoSize = true;
            this.lblGroupBy.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupBy.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupBy.Location = new System.Drawing.Point(11, 12);
            this.lblGroupBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupBy.Name = "lblGroupBy";
            this.lblGroupBy.Size = new System.Drawing.Size(370, 20);
            this.lblGroupBy.TabIndex = 1;
            this.lblGroupBy.Text = "Gruplamak istediğiniz sütun başlığını buraya sürükleyin";
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
            this.dataGridView.Location = new System.Drawing.Point(0, 111);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1467, 522);
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
            this.panelSagButonlar.Controls.Add(this.btnSil);
            this.panelSagButonlar.Controls.Add(this.btnKapat);
            this.panelSagButonlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Location = new System.Drawing.Point(1200, 31);
            this.panelSagButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSagButonlar.Name = "panelSagButonlar";
            this.panelSagButonlar.Size = new System.Drawing.Size(267, 74);
            this.panelSagButonlar.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSil.Location = new System.Drawing.Point(7, 12);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 43);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "🗑 Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(133, 12);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 43);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelSolButonlar
            // 
            this.panelSolButonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSolButonlar.Controls.Add(this.btnYeniSiparis);
            this.panelSolButonlar.Controls.Add(this.btnDurumDegistir);
            this.panelSolButonlar.Controls.Add(this.btnYenile);
            this.panelSolButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Location = new System.Drawing.Point(0, 31);
            this.panelSolButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSolButonlar.Name = "panelSolButonlar";
            this.panelSolButonlar.Size = new System.Drawing.Size(1467, 74);
            this.panelSolButonlar.TabIndex = 1;
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYeniSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniSiparis.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnYeniSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniSiparis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeniSiparis.Location = new System.Drawing.Point(13, 12);
            this.btnYeniSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(167, 43);
            this.btnYeniSiparis.TabIndex = 0;
            this.btnYeniSiparis.Text = "🏍️ Yeni Sipariş";
            this.btnYeniSiparis.UseVisualStyleBackColor = false;
            this.btnYeniSiparis.Click += new System.EventHandler(this.btnYeniSiparis_Click);
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDurumDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurumDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumDegistir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDurumDegistir.Location = new System.Drawing.Point(193, 12);
            this.btnDurumDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(187, 43);
            this.btnDurumDegistir.TabIndex = 1;
            this.btnDurumDegistir.Text = "♼ Durum Değiştir";
            this.btnDurumDegistir.UseVisualStyleBackColor = false;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenile.Location = new System.Drawing.Point(393, 12);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(187, 43);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "🔄 Yenile-Listele";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
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
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // PaketSiparisiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGroupBar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAltDusuk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaketSiparisiControl";
            this.Size = new System.Drawing.Size(1467, 738);
            this.Load += new System.EventHandler(this.PaketSiparisiControl_Load);
            this.panelGroupBar.ResumeLayout(false);
            this.panelGroupBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelAltDusuk.ResumeLayout(false);
            this.panelSagButonlar.ResumeLayout(false);
            this.panelSolButonlar.ResumeLayout(false);
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelGroupBar;
        private System.Windows.Forms.Label lblGroupBy;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        
        private System.Windows.Forms.Panel panelSagButonlar;
        private System.Windows.Forms.Panel panelSolButonlar;
        
        private System.Windows.Forms.Button btnYeniSiparis;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}
