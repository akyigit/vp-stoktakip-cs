
namespace StokTakipProgramı
{
    partial class CariHesaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariHesaplar));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblHesapTuru = new System.Windows.Forms.Label();
            this.lblCariHesap = new System.Windows.Forms.Label();
            this.cmbHesapTuru = new System.Windows.Forms.ComboBox();
            this.txtCariHesap = new System.Windows.Forms.TextBox();
            this.txtCariAdres = new System.Windows.Forms.TextBox();
            this.pbxHesap = new System.Windows.Forms.PictureBox();
            this.txtCariTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gridHesap = new System.Windows.Forms.DataGridView();
            this.btnTema = new StokTakipProgramı.Toggle.dnzToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Location = new System.Drawing.Point(175, 304);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 39);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(417, 304);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(115, 39);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(48, 304);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(115, 39);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt Ekle";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(44, 181);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(44, 234);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 9;
            this.lblAdres.Text = "Adres";
            // 
            // lblHesapTuru
            // 
            this.lblHesapTuru.AutoSize = true;
            this.lblHesapTuru.Location = new System.Drawing.Point(44, 127);
            this.lblHesapTuru.Name = "lblHesapTuru";
            this.lblHesapTuru.Size = new System.Drawing.Size(83, 17);
            this.lblHesapTuru.TabIndex = 8;
            this.lblHesapTuru.Text = "Hesap Türü";
            // 
            // lblCariHesap
            // 
            this.lblCariHesap.AutoSize = true;
            this.lblCariHesap.Location = new System.Drawing.Point(44, 70);
            this.lblCariHesap.Name = "lblCariHesap";
            this.lblCariHesap.Size = new System.Drawing.Size(73, 17);
            this.lblCariHesap.TabIndex = 7;
            this.lblCariHesap.Text = "Hesap Adı";
            // 
            // cmbHesapTuru
            // 
            this.cmbHesapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesapTuru.FormattingEnabled = true;
            this.cmbHesapTuru.Location = new System.Drawing.Point(175, 117);
            this.cmbHesapTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHesapTuru.Name = "cmbHesapTuru";
            this.cmbHesapTuru.Size = new System.Drawing.Size(259, 24);
            this.cmbHesapTuru.TabIndex = 2;
            // 
            // txtCariHesap
            // 
            this.txtCariHesap.Location = new System.Drawing.Point(175, 62);
            this.txtCariHesap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariHesap.Name = "txtCariHesap";
            this.txtCariHesap.Size = new System.Drawing.Size(259, 22);
            this.txtCariHesap.TabIndex = 1;
            // 
            // txtCariAdres
            // 
            this.txtCariAdres.Location = new System.Drawing.Point(175, 231);
            this.txtCariAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariAdres.Name = "txtCariAdres";
            this.txtCariAdres.Size = new System.Drawing.Size(465, 22);
            this.txtCariAdres.TabIndex = 4;
            // 
            // pbxHesap
            // 
            this.pbxHesap.Image = global::StokTakipProgramı.Properties.Resources.stock4;
            this.pbxHesap.Location = new System.Drawing.Point(517, 22);
            this.pbxHesap.Margin = new System.Windows.Forms.Padding(4);
            this.pbxHesap.Name = "pbxHesap";
            this.pbxHesap.Size = new System.Drawing.Size(393, 361);
            this.pbxHesap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHesap.TabIndex = 23;
            this.pbxHesap.TabStop = false;
            // 
            // txtCariTelefon
            // 
            this.txtCariTelefon.Location = new System.Drawing.Point(175, 172);
            this.txtCariTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariTelefon.Mask = "(999) 000-0000";
            this.txtCariTelefon.Name = "txtCariTelefon";
            this.txtCariTelefon.Size = new System.Drawing.Size(259, 22);
            this.txtCariTelefon.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Location = new System.Drawing.Point(296, 304);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 39);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Kayıt Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(537, 304);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(115, 39);
            this.btnYazdir.TabIndex = 26;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(657, 304);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 39);
            this.btnExcel.TabIndex = 27;
            this.btnExcel.Text = "Excel Oluştur";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gridHesap
            // 
            this.gridHesap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHesap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridHesap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHesap.Location = new System.Drawing.Point(48, 390);
            this.gridHesap.Name = "gridHesap";
            this.gridHesap.ReadOnly = true;
            this.gridHesap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridHesap.RowHeadersVisible = false;
            this.gridHesap.RowHeadersWidth = 51;
            this.gridHesap.RowTemplate.Height = 24;
            this.gridHesap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHesap.Size = new System.Drawing.Size(843, 272);
            this.gridHesap.TabIndex = 28;
            this.gridHesap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridHesap_CellMouseClick);
            // 
            // btnTema
            // 
            this.btnTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTema.Location = new System.Drawing.Point(1013, 9);
            this.btnTema.Margin = new System.Windows.Forms.Padding(4);
            this.btnTema.MinimumSize = new System.Drawing.Size(60, 27);
            this.btnTema.Name = "btnTema";
            this.btnTema.OffBackColor = System.Drawing.Color.LightGray;
            this.btnTema.OffToggleColor = System.Drawing.Color.DimGray;
            this.btnTema.OnBackColor = System.Drawing.Color.DarkGray;
            this.btnTema.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.btnTema.Size = new System.Drawing.Size(84, 34);
            this.btnTema.TabIndex = 22;
            this.btnTema.UseVisualStyleBackColor = true;
            // 
            // CariHesaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(941, 699);
            this.Controls.Add(this.gridHesap);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtCariTelefon);
            this.Controls.Add(this.btnTema);
            this.Controls.Add(this.txtCariAdres);
            this.Controls.Add(this.txtCariHesap);
            this.Controls.Add(this.cmbHesapTuru);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblHesapTuru);
            this.Controls.Add(this.lblCariHesap);
            this.Controls.Add(this.pbxHesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CariHesaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı - Cari Hesaplar";
            this.Load += new System.EventHandler(this.CariHesaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblHesapTuru;
        private System.Windows.Forms.Label lblCariHesap;
        private System.Windows.Forms.ComboBox cmbHesapTuru;
        private System.Windows.Forms.TextBox txtCariHesap;
        private System.Windows.Forms.TextBox txtCariAdres;
        private Toggle.dnzToggleButton btnTema;
        private System.Windows.Forms.PictureBox pbxHesap;
        private System.Windows.Forms.MaskedTextBox txtCariTelefon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView gridHesap;
    }
}