namespace StokTakipProgramı
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.btnUser = new System.Windows.Forms.Button();
            this.btnTema = new System.Windows.Forms.Button();
            this.btniletisim = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(66, 42);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(181, 67);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Kullanıcı Ayarları";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(66, 131);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(181, 67);
            this.btnTema.TabIndex = 1;
            this.btnTema.Text = "Tema Tercihi";
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // btniletisim
            // 
            this.btniletisim.Location = new System.Drawing.Point(66, 226);
            this.btniletisim.Name = "btniletisim";
            this.btniletisim.Size = new System.Drawing.Size(181, 67);
            this.btniletisim.TabIndex = 2;
            this.btniletisim.Text = "İletişim";
            this.btniletisim.UseVisualStyleBackColor = true;
            this.btniletisim.Click += new System.EventHandler(this.btniletisim_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(66, 319);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(181, 67);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(314, 434);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btniletisim);
            this.Controls.Add(this.btnTema);
            this.Controls.Add(this.btnUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.Button btniletisim;
        private System.Windows.Forms.Button btnGeri;
    }
}