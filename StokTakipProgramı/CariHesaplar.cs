using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipProgramı
{
    public partial class CariHesaplar : Form
    {
        public static int idHesap = 0;
        public static int viewId;
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

        string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
        private void dbSelect()
        {
            try
            {
                var select = "Select Id,HesapAdi,HesapTuru,Telefon,Adres from Cari.Hesaplar Where IsDeleted=0 ";
                var conn = new SqlConnection(connString);
                var adapter = new SqlDataAdapter(select, conn);

                var commandBuilder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                gridHesap.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Kayıt Alınamadı");
            }
        }
        public CariHesaplar()
        {
            InitializeComponent();
        }

        STOKTAKIPEntities db = new STOKTAKIPEntities();
        private void CariHesaplar_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

            cmbHesapTuru.Text = "Seçiniz";

            cmbHesapTuru.Items.Add("Müşteri");
            cmbHesapTuru.Items.Add("Toptancı");
            cmbHesapTuru.Items.Add("Mağaza");

            txtCariTelefon.MaxLength = 11;

            dbSelect();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            try
            {
                Hesaplar hesaplar = new Hesaplar();
                hesaplar.HesapAdi = txtCariHesap.Text;
                hesaplar.HesapTuru = cmbHesapTuru.Text;
                hesaplar.Telefon = txtCariTelefon.Text;
                hesaplar.Adres = txtCariAdres.Text;
                hesaplar.InsertDate = tarih;
                hesaplar.IsDeleted = false;
                db.Hesaplar.Add(hesaplar);
                db.SaveChanges();

                dbSelect();


            }
            catch
            {
                //MessageBox.Show("İşleminiz şu anda gerekleştirilemiyor.");
            }


            btnTemizle_Click(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //projelerde verilerin databasede silinmesi istenmeyen bir durum olduğu için sadece IsDeleted sütununu işaretleyerek silindiğini belirtiyoruz.
            var sonuc = db.Hesaplar.Where(x => x.Id == viewId).FirstOrDefault();
            sonuc.IsDeleted = true;
            db.SaveChanges();
            MessageBox.Show(" Kayıt silinmiştir.");
            dbSelect();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            try
            {
                var hesaplar = db.Hesaplar.Where(x => x.Id == viewId).FirstOrDefault();

                hesaplar.HesapAdi = txtCariHesap.Text;
                hesaplar.HesapTuru = cmbHesapTuru.Text;
                hesaplar.Telefon = txtCariTelefon.Text;
                hesaplar.Adres = txtCariAdres.Text;
                hesaplar.InsertDate = tarih;
                hesaplar.IsDeleted = false;
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
            txtCariHesap.Clear();
            cmbHesapTuru.Text = "Seçiniz";
            txtCariAdres.Clear();
            txtCariTelefon.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                    foreach (DataGridViewColumn GridCol in gridHesap.Columns)
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

                while (iRow <= gridHesap.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = gridHesap.Rows[iRow];

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

                            e.Graphics.DrawString("Cari Hesaplar", new Font(gridHesap.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Cari Hesaplar", new Font(gridHesap.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(gridHesap.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(gridHesap.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Cari Hesaplar", new Font(new Font(gridHesap.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in gridHesap.Columns)
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

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in gridHesap.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
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
                    for (int i = 0; i < gridHesap.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = gridHesap.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < gridHesap.Columns.Count; i++)
                    {
                        for (int j = 0; j < gridHesap.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = gridHesap[i, j].Value;
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

        private void gridHesap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                viewId = Convert.ToInt32(gridHesap.SelectedCells[0].Value.ToString());

                var hesap = db.Hesaplar.Where(x => x.Id == viewId).FirstOrDefault();

                txtCariHesap.Text = hesap.HesapAdi;
                cmbHesapTuru.SelectedValue = hesap.HesapTuru;
                txtCariTelefon.Text = hesap.Telefon;
                txtCariAdres.Text = hesap.Adres;

            }
            catch
            {
                MessageBox.Show("Kayıt Seçilemedi");
            }
        }
    }
}
