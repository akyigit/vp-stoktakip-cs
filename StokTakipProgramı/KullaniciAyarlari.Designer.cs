
namespace StokTakipProgramı
{
    partial class KullaniciAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAyarlari));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.btnTema = new StokTakipProgramı.Toggle.dnzToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(272, 127);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 34);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Kullanıcı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(272, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 32);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Kullanıcı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(272, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 32);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Kullanıcı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(140, 94);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(92, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(140, 55);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(92, 20);
            this.txtKullanici.TabIndex = 1;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(46, 98);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(46, 58);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(64, 13);
            this.lblKullanici.TabIndex = 11;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // gridKullanici
            // 
            this.gridKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKullanici.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(23, 185);
            this.gridKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.ReadOnly = true;
            this.gridKullanici.RowHeadersVisible = false;
            this.gridKullanici.RowHeadersWidth = 51;
            this.gridKullanici.RowTemplate.Height = 24;
            this.gridKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKullanici.Size = new System.Drawing.Size(370, 233);
            this.gridKullanici.TabIndex = 29;
            this.gridKullanici.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridKullanici_CellMouseClick);
            // 
            // btnTema
            // 
            this.btnTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTema.Location = new System.Drawing.Point(446, 4);
            this.btnTema.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnTema.Name = "btnTema";
            this.btnTema.OffBackColor = System.Drawing.Color.LightGray;
            this.btnTema.OffToggleColor = System.Drawing.Color.DimGray;
            this.btnTema.OnBackColor = System.Drawing.Color.DarkGray;
            this.btnTema.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.btnTema.Size = new System.Drawing.Size(45, 22);
            this.btnTema.TabIndex = 27;
            this.btnTema.UseVisualStyleBackColor = true;
            // 
            // KullaniciAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(419, 461);
            this.Controls.Add(this.gridKullanici);
            this.Controls.Add(this.btnTema);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.KulaniciAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanici;
        private Toggle.dnzToggleButton btnTema;
        private System.Windows.Forms.DataGridView gridKullanici;
    }
}