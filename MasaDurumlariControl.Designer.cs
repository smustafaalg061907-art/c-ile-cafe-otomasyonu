namespace CafeOtomasyonu
{
    partial class MasaDurumlariControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelMasalar = new System.Windows.Forms.Panel();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.panelSagButonlar = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.btnRezervEt = new System.Windows.Forms.Button();
            this.btnYenileListele = new System.Windows.Forms.Button();
            this.panelAlt.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.panelbtn.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1365, 62);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Masa Durumları";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMasalar
            // 
            this.panelMasalar.AutoScroll = true;
            this.panelMasalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMasalar.Location = new System.Drawing.Point(0, 62);
            this.panelMasalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelMasalar.Size = new System.Drawing.Size(1365, 485);
            this.panelMasalar.TabIndex = 0;
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panelAlt.Controls.Add(this.panelSagButonlar);
            this.panelAlt.Controls.Add(this.panelbtn);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 547);
            this.panelAlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(1365, 68);
            this.panelAlt.TabIndex = 2;
            // 
            // panelSagButonlar
            // 
            this.panelSagButonlar.BackColor = System.Drawing.Color.Gray;
            this.panelSagButonlar.Controls.Add(this.btnKapat);
            this.panelSagButonlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Location = new System.Drawing.Point(1232, 0);
            this.panelSagButonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSagButonlar.Name = "panelSagButonlar";
            this.panelSagButonlar.Size = new System.Drawing.Size(133, 68);
            this.panelSagButonlar.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(11, 16);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(112, 34);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "✖  Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.Gray;
            this.panelbtn.Controls.Add(this.lblIslemler);
            this.panelbtn.Controls.Add(this.btnSiparis);
            this.panelbtn.Controls.Add(this.btnMasaAc);
            this.panelbtn.Controls.Add(this.btnRezervEt);
            this.panelbtn.Controls.Add(this.btnYenileListele);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbtn.Location = new System.Drawing.Point(0, 0);
            this.panelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(1365, 68);
            this.panelbtn.TabIndex = 1;
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblIslemler.Location = new System.Drawing.Point(11, 5);
            this.lblIslemler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(65, 20);
            this.lblIslemler.TabIndex = 0;
            this.lblIslemler.Text = "İşlemler";
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparis.FlatAppearance.BorderSize = 0;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiparis.ForeColor = System.Drawing.Color.White;
            this.btnSiparis.Location = new System.Drawing.Point(11, 25);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(120, 34);
            this.btnSiparis.TabIndex = 1;
            this.btnSiparis.Text = "✚  Sipariş";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnMasaAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasaAc.FlatAppearance.BorderSize = 0;
            this.btnMasaAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaAc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMasaAc.ForeColor = System.Drawing.Color.White;
            this.btnMasaAc.Location = new System.Drawing.Point(141, 25);
            this.btnMasaAc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(120, 34);
            this.btnMasaAc.TabIndex = 2;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = false;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnRezervEt
            // 
            this.btnRezervEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRezervEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervEt.FlatAppearance.BorderSize = 0;
            this.btnRezervEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervEt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRezervEt.ForeColor = System.Drawing.Color.White;
            this.btnRezervEt.Location = new System.Drawing.Point(272, 25);
            this.btnRezervEt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezervEt.Name = "btnRezervEt";
            this.btnRezervEt.Size = new System.Drawing.Size(120, 34);
            this.btnRezervEt.TabIndex = 3;
            this.btnRezervEt.Text = "Rezerv Et";
            this.btnRezervEt.UseVisualStyleBackColor = false;
            this.btnRezervEt.Click += new System.EventHandler(this.btnRezervEt_Click);
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnYenileListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenileListele.FlatAppearance.BorderSize = 0;
            this.btnYenileListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenileListele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenileListele.ForeColor = System.Drawing.Color.White;
            this.btnYenileListele.Location = new System.Drawing.Point(403, 25);
            this.btnYenileListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYenileListele.Name = "btnYenileListele";
            this.btnYenileListele.Size = new System.Drawing.Size(153, 34);
            this.btnYenileListele.TabIndex = 4;
            this.btnYenileListele.Text = "↺  Yenile/Listele";
            this.btnYenileListele.UseVisualStyleBackColor = false;
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            // 
            // MasaDurumlariControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMasalar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAlt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasaDurumlariControl";
            this.Size = new System.Drawing.Size(1365, 615);
            this.panelAlt.ResumeLayout(false);
            this.panelSagButonlar.ResumeLayout(false);
            this.panelbtn.ResumeLayout(false);
            this.panelbtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label   lblBaslik;
        private System.Windows.Forms.Panel   panelMasalar;
        private System.Windows.Forms.Panel   panelAlt;
        private System.Windows.Forms.Panel   panelbtn;
        private System.Windows.Forms.Panel   panelSagButonlar;
        private System.Windows.Forms.Label   lblIslemler;
        private System.Windows.Forms.Button  btnSiparis;
        private System.Windows.Forms.Button  btnMasaAc;
        private System.Windows.Forms.Button  btnRezervEt;
        private System.Windows.Forms.Button  btnYenileListele;
        private System.Windows.Forms.Button  btnKapat;
    }
}
