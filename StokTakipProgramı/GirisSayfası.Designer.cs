
namespace StokTakipProgramı
{
    partial class GirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdHatirla = new System.Windows.Forms.RadioButton();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblKodGiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(276, 81);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(93, 20);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblParola.ForeColor = System.Drawing.Color.Black;
            this.lblParola.Location = new System.Drawing.Point(276, 138);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(42, 20);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Şifre";
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.Color.White;
            this.txtKullanici.ForeColor = System.Drawing.Color.Black;
            this.txtKullanici.Location = new System.Drawing.Point(415, 78);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullanici.MaxLength = 20;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(144, 26);
            this.txtKullanici.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(415, 132);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(144, 26);
            this.txtSifre.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(255, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 3;
            this.lblError.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Transparent;
            this.infoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBox.Image = global::StokTakipProgramı.Properties.Resources.info;
            this.infoBox.Location = new System.Drawing.Point(215, 234);
            this.infoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(33, 31);
            this.infoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoBox.TabIndex = 10;
            this.infoBox.TabStop = false;
            this.infoBox.Click += new System.EventHandler(this.infobox_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = global::StokTakipProgramı.Properties.Resources.icon1;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Location = new System.Drawing.Point(12, -15);
            this.logoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(243, 302);
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(501, 250);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(58, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdHatirla
            // 
            this.rdHatirla.AutoSize = true;
            this.rdHatirla.Location = new System.Drawing.Point(277, 256);
            this.rdHatirla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdHatirla.Name = "rdHatirla";
            this.rdHatirla.Size = new System.Drawing.Size(109, 24);
            this.rdHatirla.TabIndex = 3;
            this.rdHatirla.TabStop = true;
            this.rdHatirla.Text = "Beni Hatırla";
            this.rdHatirla.UseVisualStyleBackColor = true;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(276, 191);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(37, 20);
            this.lblKod.TabIndex = 11;
            this.lblKod.Text = "Kod";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(475, 185);
            this.txtKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(84, 26);
            this.txtKod.TabIndex = 2;
            // 
            // lblKodGiris
            // 
            this.lblKodGiris.AutoSize = true;
            this.lblKodGiris.Location = new System.Drawing.Point(412, 189);
            this.lblKodGiris.Name = "lblKodGiris";
            this.lblKodGiris.Size = new System.Drawing.Size(41, 20);
            this.lblKodGiris.TabIndex = 13;
            this.lblKodGiris.Text = "Kod:";
            // 
            // GirisSayfasi
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 309);
            this.Controls.Add(this.lblKodGiris);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.rdHatirla);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.logoBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı - Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisSayfasi_FormClosing);
            this.Load += new System.EventHandler(this.GirisSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox infoBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdHatirla;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblKodGiris;
    }
}