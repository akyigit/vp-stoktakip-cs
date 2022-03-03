
namespace StokTakipProgramı
{
    partial class StokIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokIslemleri));
            this.lblHesap = new System.Windows.Forms.Label();
            this.lblVergisizFiyat = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.cmbCariHesap = new System.Windows.Forms.ComboBox();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.txtVergisizFiyat = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.stokislemleribg = new System.Windows.Forms.PictureBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.lblIslem = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblListe = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.lblTopl = new System.Windows.Forms.Label();
            this.txtTopl = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.NumericUpDown();
            this.txtSatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pickerTarih = new System.Windows.Forms.DateTimePicker();
            this.gridIslem = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.sTOKTAKIPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOKTAKIPDataSet = new StokTakipProgramı.STOKTAKIPDataSet();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stokislemleribg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKTAKIPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKTAKIPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Location = new System.Drawing.Point(44, 72);
            this.lblHesap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(38, 13);
            this.lblHesap.TabIndex = 1;
            this.lblHesap.Text = "Hesap";
            // 
            // lblVergisizFiyat
            // 
            this.lblVergisizFiyat.AutoSize = true;
            this.lblVergisizFiyat.Location = new System.Drawing.Point(331, 153);
            this.lblVergisizFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVergisizFiyat.Name = "lblVergisizFiyat";
            this.lblVergisizFiyat.Size = new System.Drawing.Size(68, 13);
            this.lblVergisizFiyat.TabIndex = 3;
            this.lblVergisizFiyat.Text = "Vergisiz Fiyat";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(331, 114);
            this.lblKDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(52, 13);
            this.lblKDV.TabIndex = 4;
            this.lblKDV.Text = "%18 KDV";
            // 
            // cmbCariHesap
            // 
            this.cmbCariHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCariHesap.FormattingEnabled = true;
            this.cmbCariHesap.Location = new System.Drawing.Point(132, 70);
            this.cmbCariHesap.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCariHesap.Name = "cmbCariHesap";
            this.cmbCariHesap.Size = new System.Drawing.Size(116, 21);
            this.cmbCariHesap.TabIndex = 2;
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Location = new System.Drawing.Point(420, 106);
            this.txtKdvTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.ReadOnly = true;
            this.txtKdvTutar.Size = new System.Drawing.Size(116, 20);
            this.txtKdvTutar.TabIndex = 8;
            // 
            // txtVergisizFiyat
            // 
            this.txtVergisizFiyat.Location = new System.Drawing.Point(420, 145);
            this.txtVergisizFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtVergisizFiyat.Name = "txtVergisizFiyat";
            this.txtVergisizFiyat.ReadOnly = true;
            this.txtVergisizFiyat.Size = new System.Drawing.Size(116, 20);
            this.txtVergisizFiyat.TabIndex = 9;
            this.txtVergisizFiyat.Leave += new System.EventHandler(this.txtSatis_Leave);
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(331, 73);
            this.lblSatisFiyati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyati.TabIndex = 18;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(331, 36);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 31;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(44, 189);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 32;
            this.lblTarih.Text = "Tarih";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(420, 28);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(379, 20);
            this.txtAciklama.TabIndex = 6;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(216, 222);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKayit.Size = new System.Drawing.Size(112, 42);
            this.btnKayit.TabIndex = 13;
            this.btnKayit.Text = "Kayıt Ekle";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(334, 222);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 42);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(452, 222);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 42);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Kayıt Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // stokislemleribg
            // 
            this.stokislemleribg.Image = global::StokTakipProgramı.Properties.Resources._999;
            this.stokislemleribg.Location = new System.Drawing.Point(700, 11);
            this.stokislemleribg.Name = "stokislemleribg";
            this.stokislemleribg.Size = new System.Drawing.Size(506, 325);
            this.stokislemleribg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stokislemleribg.TabIndex = 38;
            this.stokislemleribg.TabStop = false;
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(132, 33);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(116, 21);
            this.cmbIslem.TabIndex = 1;
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.ForeColor = System.Drawing.Color.Black;
            this.lblIslem.Location = new System.Drawing.Point(44, 35);
            this.lblIslem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(31, 13);
            this.lblIslem.TabIndex = 39;
            this.lblIslem.Text = "İşlem";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(44, 112);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 40;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(569, 222);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTemizle.Size = new System.Drawing.Size(112, 42);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(22, 271);
            this.lblListe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(63, 13);
            this.lblListe.TabIndex = 43;
            this.lblListe.Text = "İşlem Listesi";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(44, 148);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 46;
            this.lblAdet.Text = "Adet";
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(132, 106);
            this.cmbUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(116, 21);
            this.cmbUrunAdi.TabIndex = 3;
            // 
            // lblTopl
            // 
            this.lblTopl.AutoSize = true;
            this.lblTopl.Location = new System.Drawing.Point(331, 189);
            this.lblTopl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopl.Name = "lblTopl";
            this.lblTopl.Size = new System.Drawing.Size(70, 13);
            this.lblTopl.TabIndex = 47;
            this.lblTopl.Text = "Toplam Tutar";
            // 
            // txtTopl
            // 
            this.txtTopl.Location = new System.Drawing.Point(420, 186);
            this.txtTopl.Margin = new System.Windows.Forms.Padding(2);
            this.txtTopl.Name = "txtTopl";
            this.txtTopl.ReadOnly = true;
            this.txtTopl.Size = new System.Drawing.Size(116, 20);
            this.txtTopl.TabIndex = 10;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(132, 142);
            this.txtAdet.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(116, 20);
            this.txtAdet.TabIndex = 4;
            this.txtAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAdet.Click += new System.EventHandler(this.txtAdet_ValueChanged);
            this.txtAdet.Leave += new System.EventHandler(this.txtAdet_Leave);
            this.txtAdet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdet_MouseClick);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.DecimalPlaces = 2;
            this.txtSatisFiyati.Location = new System.Drawing.Point(420, 67);
            this.txtSatisFiyati.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(116, 20);
            this.txtSatisFiyati.TabIndex = 7;
            this.txtSatisFiyati.Leave += new System.EventHandler(this.txtSatisFiyati_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(687, 222);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(112, 42);
            this.btnPrint.TabIndex = 48;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pickerTarih
            // 
            this.pickerTarih.Location = new System.Drawing.Point(132, 180);
            this.pickerTarih.Margin = new System.Windows.Forms.Padding(2);
            this.pickerTarih.Name = "pickerTarih";
            this.pickerTarih.Size = new System.Drawing.Size(116, 20);
            this.pickerTarih.TabIndex = 5;
            this.pickerTarih.Value = new System.DateTime(2022, 1, 25, 1, 13, 10, 0);
            // 
            // gridIslem
            // 
            this.gridIslem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIslem.Location = new System.Drawing.Point(24, 292);
            this.gridIslem.Margin = new System.Windows.Forms.Padding(2);
            this.gridIslem.Name = "gridIslem";
            this.gridIslem.ReadOnly = true;
            this.gridIslem.RowHeadersVisible = false;
            this.gridIslem.RowHeadersWidth = 51;
            this.gridIslem.RowTemplate.Height = 24;
            this.gridIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIslem.Size = new System.Drawing.Size(1182, 327);
            this.gridIslem.TabIndex = 51;
            this.gridIslem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridIslem_CellMouseClick);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // sTOKTAKIPDataSet
            // 
            this.sTOKTAKIPDataSet.DataSetName = "STOKTAKIPDataSet";
            this.sTOKTAKIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(805, 222);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcel.Size = new System.Drawing.Size(112, 42);
            this.btnExcel.TabIndex = 52;
            this.btnExcel.Text = "Excel Oluştur";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // StokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1230, 643);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gridIslem);
            this.Controls.Add(this.pickerTarih);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtTopl);
            this.Controls.Add(this.lblTopl);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.txtVergisizFiyat);
            this.Controls.Add(this.txtKdvTutar);
            this.Controls.Add(this.cmbCariHesap);
            this.Controls.Add(this.lblKDV);
            this.Controls.Add(this.lblVergisizFiyat);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.stokislemleribg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı - Stok İşlemleri";
            this.Load += new System.EventHandler(this.StokIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokislemleribg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKTAKIPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKTAKIPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Label lblVergisizFiyat;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.ComboBox cmbCariHesap;
        private System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.TextBox txtVergisizFiyat;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox stokislemleribg;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.Label lblTopl;
        private System.Windows.Forms.TextBox txtTopl;
        private System.Windows.Forms.NumericUpDown txtAdet;
        private System.Windows.Forms.NumericUpDown txtSatisFiyati;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker pickerTarih;
        private System.Windows.Forms.DataGridView gridIslem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.BindingSource sTOKTAKIPDataSetBindingSource;
        private STOKTAKIPDataSet sTOKTAKIPDataSet;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.Button btnExcel;
    }
}