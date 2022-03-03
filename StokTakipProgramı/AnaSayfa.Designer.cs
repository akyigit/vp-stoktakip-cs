
namespace StokTakipProgramı
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnStokTanim = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnKD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokIslem.Location = new System.Drawing.Point(397, 100);
            this.btnStokIslem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(178, 104);
            this.btnStokIslem.TabIndex = 1;
            this.btnStokIslem.Text = "STOK İŞLEMLERİ";
            this.btnStokIslem.UseVisualStyleBackColor = true;
            this.btnStokIslem.Click += new System.EventHandler(this.btnStokIslem_Click);
            // 
            // btnStokTanim
            // 
            this.btnStokTanim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStokTanim.Location = new System.Drawing.Point(585, 100);
            this.btnStokTanim.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStokTanim.Name = "btnStokTanim";
            this.btnStokTanim.Size = new System.Drawing.Size(178, 104);
            this.btnStokTanim.TabIndex = 2;
            this.btnStokTanim.Text = "STOK TANIMLAMA";
            this.btnStokTanim.UseVisualStyleBackColor = true;
            this.btnStokTanim.Click += new System.EventHandler(this.btnStokTanim_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRapor.Location = new System.Drawing.Point(585, 213);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(178, 104);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "RAPORLAR";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyar.Location = new System.Drawing.Point(397, 326);
            this.btnAyar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(178, 104);
            this.btnAyar.TabIndex = 5;
            this.btnAyar.Text = "AYARLAR";
            this.btnAyar.UseVisualStyleBackColor = true;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // btnCari
            // 
            this.btnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCari.Location = new System.Drawing.Point(397, 213);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(178, 104);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "CARİ HESAPLAR";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnKD
            // 
            this.btnKD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKD.Location = new System.Drawing.Point(585, 326);
            this.btnKD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnKD.Name = "btnKD";
            this.btnKD.Size = new System.Drawing.Size(178, 104);
            this.btnKD.TabIndex = 6;
            this.btnKD.Text = "KULLANICI GİRİŞİNE DÖN";
            this.btnKD.UseVisualStyleBackColor = true;
            this.btnKD.Click += new System.EventHandler(this.btnKD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::StokTakipProgramı.Properties.Resources.stock2;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(793, 502);
            this.Controls.Add(this.btnKD);
            this.Controls.Add(this.btnAyar);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnStokTanim);
            this.Controls.Add(this.btnStokIslem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 541);
            this.MinimumSize = new System.Drawing.Size(809, 541);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı - Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStokIslem;
        private System.Windows.Forms.Button btnStokTanim;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.Button btnCari;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKD;
    }
}

