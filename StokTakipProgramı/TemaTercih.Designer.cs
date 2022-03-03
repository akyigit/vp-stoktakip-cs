namespace StokTakipProgramı
{
    partial class TemaTercih
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemaTercih));
            this.pbTema2 = new System.Windows.Forms.PictureBox();
            this.pbTema1 = new System.Windows.Forms.PictureBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnKoyu = new System.Windows.Forms.Button();
            this.btnAcik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTema2
            // 
            this.pbTema2.Image = global::StokTakipProgramı.Properties.Resources.white_smoke;
            this.pbTema2.Location = new System.Drawing.Point(182, 54);
            this.pbTema2.Name = "pbTema2";
            this.pbTema2.Size = new System.Drawing.Size(84, 56);
            this.pbTema2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTema2.TabIndex = 1;
            this.pbTema2.TabStop = false;
            // 
            // pbTema1
            // 
            this.pbTema1.Image = global::StokTakipProgramı.Properties.Resources.dim_gray;
            this.pbTema1.Location = new System.Drawing.Point(98, 54);
            this.pbTema1.Name = "pbTema1";
            this.pbTema1.Size = new System.Drawing.Size(84, 56);
            this.pbTema1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTema1.TabIndex = 0;
            this.pbTema1.TabStop = false;
            // 
            // btnTamam
            // 
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTamam.Location = new System.Drawing.Point(137, 147);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(90, 24);
            this.btnTamam.TabIndex = 18;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnKoyu
            // 
            this.btnKoyu.Location = new System.Drawing.Point(120, 71);
            this.btnKoyu.Name = "btnKoyu";
            this.btnKoyu.Size = new System.Drawing.Size(38, 24);
            this.btnKoyu.TabIndex = 20;
            this.btnKoyu.Text = "seç";
            this.btnKoyu.UseVisualStyleBackColor = true;
            this.btnKoyu.Click += new System.EventHandler(this.btnKoyu_Click);
            // 
            // btnAcik
            // 
            this.btnAcik.Location = new System.Drawing.Point(205, 71);
            this.btnAcik.Name = "btnAcik";
            this.btnAcik.Size = new System.Drawing.Size(38, 24);
            this.btnAcik.TabIndex = 21;
            this.btnAcik.Text = "seç";
            this.btnAcik.UseVisualStyleBackColor = true;
            this.btnAcik.Click += new System.EventHandler(this.btnAcik_Click);
            // 
            // TemaTercih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnTamam;
            this.ClientSize = new System.Drawing.Size(362, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btnAcik);
            this.Controls.Add(this.btnKoyu);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.pbTema1);
            this.Controls.Add(this.pbTema2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemaTercih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tema Tercihi";
            this.Load += new System.EventHandler(this.TemaTercih_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTema2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTema1;
        private System.Windows.Forms.PictureBox pbTema2;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnKoyu;
        private System.Windows.Forms.Button btnAcik;
    }
}