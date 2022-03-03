using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace StokTakipProgramı
{
    public partial class StokIslemleri : Form
    {
        public static int viewId;
        public static string islem;
        public static string hesap;
        public static string barkodNo;
        public static DateTime tarih = DateTime.Now;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;


        public StokIslemleri()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
        private void dbSelect()
        {
            var select = "Select I.Id, SI.Islem,H.HesapAdi,S.Adi as UrunAdi,I.Adet,I.Tarih,I.Aciklama,I.SatisFiyat,I.Kdv,VergisizFiyat,Tutar from Cari.Islemler I Left Join Cari.Hesaplar H on H.Id=I.HesapId Left Join Cari.Stoklar S on S.Id = I.UrunId Left Join Sistem.Islem SI on SI.Id=I.Islem Where I.IsDeleted=0 and I.Tarih=Convert(date,getdate())";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridIslem.DataSource = ds.Tables[0];
        }
        STOKTAKIPEntities db = new STOKTAKIPEntities();

        private void StokIslemleri_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

            pickerTarih.Value = tarih.Date;

            var listIslem = db.Islem.ToList();
            cmbIslem.DataSource = listIslem;
            cmbIslem.ValueMember = "Id";
            cmbIslem.DisplayMember = "Islem1";

            var listUrunler = db.Stoklar.ToList();
            cmbUrunAdi.DataSource = listUrunler;
            cmbUrunAdi.ValueMember = "Id";
            cmbUrunAdi.DisplayMember = "Adi";

            var listHesaplar = db.Hesaplar.ToList();
            cmbCariHesap.DataSource = listHesaplar;
            cmbCariHesap.ValueMember = "Id";
            cmbCariHesap.DisplayMember = "HesapAdi";

            dbSelect();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Islemler islem = new Islemler();
            var islemId = db.Islemler.Max(i => i.Id);

            if (string.IsNullOrWhiteSpace(txtKdvTutar.Text))
            {
                MessageBox.Show("Satış Fiyatı Girilmeden kayıt yapılamaz.");
            }
            else
            {
                try
                {
                    islem.Tarih = pickerTarih.Value.Date;
                    islem.InsertDate = DateTime.Now;
                    islem.Islem = (int)cmbIslem.SelectedValue;
                    islem.HesapId = (int)cmbCariHesap.SelectedValue; //
                    islem.UrunId = (int)cmbUrunAdi.SelectedValue; //
                    islem.Adet = Convert.ToInt32(txtAdet.Text);
                    islem.SatisFiyat = (decimal)Convert.ToDouble(txtSatisFiyati.Text);
                    islem.Kdv = (decimal)Convert.ToDouble(txtKdvTutar.Text);
                    islem.VergisizFiyat = (decimal)Convert.ToDouble(txtVergisizFiyat.Text);
                    islem.Tutar = (decimal)Convert.ToDouble(txtTopl.Text);
                    islem.IsDeleted = false;
                    islem.Aciklama = txtAciklama.Text;
                    db.Islemler.Add(islem);
                    db.SaveChanges();

                    dbSelect();
                    btnTemizle_Click(this, e);
                }
                catch
                {
                    MessageBox.Show("İşlem gerçekleştirilemiyor.");
                }
                
            }   
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //projelerde verilerin databasede silinmesi istenmeyen bir durum olduğu için sadece IsDeleted sütununu işaretleyerek silindiğini belirtiyoruz.
            if (viewId ==0)
            {
                MessageBox.Show("Lütfen kayıt seçiniz.");
            }
            else
            {
                var sonuc = db.Islemler.Where(x => x.Id == viewId).FirstOrDefault();
                sonuc.IsDeleted = true;
                db.SaveChanges();
                dbSelect();
                MessageBox.Show(" Kayıt silinmiştir.");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var sonuc = db.Islemler.Where(x => x.Id == viewId).FirstOrDefault() ;
            try
            {
                sonuc.Islem = (int)cmbIslem.SelectedValue;
                sonuc.HesapId = (int)cmbCariHesap.SelectedValue;
                sonuc.UrunId = (int)cmbUrunAdi.SelectedValue;
                sonuc.Adet = Convert.ToInt32(txtAdet.Text);
                sonuc.SatisFiyat = (decimal)Convert.ToDouble(txtSatisFiyati.Text);
                sonuc.Kdv = (decimal)Convert.ToDouble(txtKdvTutar.Text);
                sonuc.VergisizFiyat = (decimal)Convert.ToDouble(txtVergisizFiyat.Text);
                sonuc.Tutar = (decimal)Convert.ToDouble(txtTopl.Text);
                sonuc.Aciklama = txtAciklama.Text;
                sonuc.LastModify = tarih;
                db.SaveChanges();
                btnTemizle_Click(this, e);
                dbSelect();
            }
            catch
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;
            cmbCariHesap.SelectedIndex = 0;
            //txtBarkod.Clear();
            txtVergisizFiyat.Clear();
            txtKdvTutar.Clear();
            txtSatisFiyati.Value = 0;
            txtAdet.Value = 0;
            cmbUrunAdi.SelectedIndex = 0;
            txtAciklama.Clear();
            txtTopl.Clear();
        }

        private void txtSatis_Leave(object sender, EventArgs e)
        {
            /*float satis = (float)Convert.ToDouble(txtSatis.Text);
            float satisKdv = (float)Convert.ToDouble(txtSatis.Text) *18 / 100;
            float adet = (float)Convert.ToDouble(txtAdet.Text);
            //float toplamtutar = (float)Convert.ToDouble(txtToplamTutar.Text);

            txtKdvTutar.Text = satisKdv.ToString();
            txtToplamTutar.Text = Convert.ToString(adet * (satis + satisKdv));
            //txtKdvTutar.Text = Convert.ToString(toplamtutar - satis);
            //txtSatis.Text = Convert.ToString(adet * (toplamtutar / 1.18));*/

        }

        private void txtSatisFiyati_Leave(object sender, EventArgs e)
        {
            float vergisiz = (float)Convert.ToDouble(txtSatisFiyati.Text) / 1.18f;
            float satisfiyati = (float)Convert.ToDouble(txtSatisFiyati.Text);
            float adet = (float)Convert.ToDouble(txtAdet.Text);

            txtVergisizFiyat.Text = vergisiz.ToString();
            txtKdvTutar.Text = Convert.ToString(satisfiyati - vergisiz);
            txtTopl.Text = Convert.ToString(adet * satisfiyati); 
        }

        private void txtAdet_ValueChanged(object sender, EventArgs e)
        {
            float adet = (float)Convert.ToDouble(txtAdet.Text);
            float satisfiyati = (float)Convert.ToDouble(txtSatisFiyati.Text);
            txtTopl.Text = Convert.ToString(adet * satisfiyati);
        }

        private void txtAdet_Leave(object sender, EventArgs e)
        {
            float adet = (float)Convert.ToDouble(txtAdet.Text);
            float satisfiyati = (float)Convert.ToDouble(txtSatisFiyati.Text);
            txtTopl.Text = Convert.ToString(adet * satisfiyati);
        }

        private void txtAdet_MouseClick(object sender, MouseEventArgs e)
        {
            float adet = (float)Convert.ToDouble(txtAdet.Text);
            float satisfiyati = (float)Convert.ToDouble(txtSatisFiyati.Text);
            txtTopl.Text = Convert.ToString(adet * satisfiyati);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument;
            onizleme.ShowDialog();
        }


        private void gridIslem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                viewId = Convert.ToInt32(gridIslem.SelectedCells[0].Value.ToString());

                var sonuc = db.Islemler.Where(x => x.Id == viewId).FirstOrDefault();

                cmbIslem.SelectedValue = sonuc.Islem;
                cmbCariHesap.SelectedValue = sonuc.HesapId;
                cmbUrunAdi.SelectedValue = sonuc.UrunId;
                txtAdet.Value = (decimal)Convert.ToDouble(sonuc.Adet);
                txtSatisFiyati.Value = (decimal)Convert.ToDouble(sonuc.SatisFiyat);
                txtKdvTutar.Text = sonuc.Kdv.ToString();
                txtVergisizFiyat.Text = sonuc.VergisizFiyat.ToString();
                txtTopl.Text = sonuc.Tutar.ToString();
                txtAciklama.Text = sonuc.Aciklama.ToString();
            }
            catch
            {
                MessageBox.Show("Kayıt Seçilemedi.");
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in gridIslem.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= gridIslem.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = gridIslem.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Günün Stok İşlemleri", new Font(gridIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günün Stok İşlemleri", new Font(gridIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(gridIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(gridIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günün Stok İşlemleri", new Font(new Font(gridIslem.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in gridIslem.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in gridIslem.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Microsoft Excel referansını projeye ekleyerek daha kolay bir şekilde verileri export edebiliyoruz.

            try
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Bu işlem, veri yoğunluğuna göre uzun sürebilir. Devam etmek istiyor musunuz?", "Excel Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                    uyg.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                    Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                    for (int i = 0; i < gridIslem.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = gridIslem.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < gridIslem.Columns.Count; i++)
                    {
                        for (int j = 0; j < gridIslem.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = gridIslem[i, j].Value;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem tamamlanmadan pencereyi kapattınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
