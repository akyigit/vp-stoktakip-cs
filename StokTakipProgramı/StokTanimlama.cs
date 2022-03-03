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
using System.IO;
using System.Data.SqlClient;

namespace StokTakipProgramı
{
    public partial class StokTanimlama : Form
    {
        public static int idStok = 0;
        public static DateTime tarih = DateTime.Now;
        public static int viewId;

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
            var select = "Select S.Id, Tarih,S.Adi as Stok,K.Ad as Kategori,M.Adi as Marka,Ozellik,Alis,Satis from Cari.Stoklar S Left Join Sistem.Kategoriler K on K.Id=S.KategoriId Left Join Sistem.Markalar M on M.Id=S.MarkaId Where S.IsDeleted=0";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridStok.DataSource = ds.Tables[0];
        }
        public StokTanimlama()
        {
            InitializeComponent();
        }
        
        STOKTAKIPEntities db = new STOKTAKIPEntities();
        private void StokTanimlama_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

            cmbKategori.Text = "Seçiniz";
            var listKategori = db.Kategoriler.ToList();
            cmbKategori.DataSource = listKategori;
            cmbKategori.ValueMember = "Id";
            cmbKategori.DisplayMember = "Ad";
            
            cmbMarka.Text = "Seçiniz";
            var listMarka = db.Markalar.ToList();
            cmbMarka.DataSource = listMarka;
            cmbMarka.ValueMember = "Id";
            cmbMarka.DisplayMember = "Adi";
            dbSelect();
        }

        

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                Stoklar stok = new Stoklar();
                stok.Adi = txtUrunAdi.Text;
                stok.InsertDate = DateTime.Now;
                stok.Tarih = tarih.Date;
                stok.KategoriId = (int)cmbKategori.SelectedValue;
                stok.MarkaId = (int)cmbMarka.SelectedValue;
                //stok.Barkod = txtBarkod.Text.ToString();
                stok.Adet = Convert.ToInt32(txtAdet.Text);
                stok.Satis = (decimal)Convert.ToDouble(txtSatis.Text);
                stok.Alis = (decimal)Convert.ToDouble(txtAlis.Text);
                stok.IsDeleted = false;
                stok.Ozellik = txtOzellik.Text;
                db.Stoklar.Add(stok);
                db.SaveChanges();

                dbSelect();
            }
            catch
            {
                MessageBox.Show("Kayıt işlemi gerçekleştirilemiyor.");
            }
            btnTemizle_Click(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //projelerde verilerin databasede silinmesi istenmeyen bir durum olduğu için sadece IsDeleted sütununu işaretleyerek silindiğini belirtiyoruz.
            var sonuc = db.Stoklar.Where(x => x.Id == viewId).FirstOrDefault();
            sonuc.IsDeleted = true;
            db.SaveChanges();
            dbSelect();
            MessageBox.Show(" Kayıt silinmiştir.");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var stok = db.Stoklar.Where(s => s.Id == viewId).FirstOrDefault();
            try
            {
                stok.KategoriId = (int)cmbKategori.SelectedValue;
                stok.Adi = txtUrunAdi.Text;
                stok.MarkaId = (int)cmbMarka.SelectedValue;
                stok.Ozellik = txtOzellik.Text;
                stok.Adet = Convert.ToInt32(txtAdet.Text);
                stok.Alis = (decimal)Convert.ToDouble(txtAlis.Text);
                stok.Satis = (decimal)Convert.ToDouble(txtSatis.Text);
                stok.LastModify = tarih;
                db.SaveChanges();
                btnTemizle_Click(this,e);
                dbSelect();
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi");
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Clear();
            cmbKategori.Text = "Seçiniz";
            cmbMarka.Text = "Seçiniz";
            txtOzellik.Clear();
            //txtBarkod.Clear();
            txtAdet.Value = 0;
            txtAlis.Value = 0;
            txtSatis.Value = 0;
        }

        

        private void btn_Excel_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < gridStok.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = gridStok.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < gridStok.Columns.Count; i++)
                    {
                        for (int j = 0; j < gridStok.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = gridStok[i, j].Value;
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

        private void gridStok_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                viewId = Convert.ToInt32(gridStok.SelectedCells[0].Value.ToString());

                var sonuc = db.Stoklar.Where(x => x.Id == viewId).FirstOrDefault();

                cmbKategori.SelectedValue = sonuc.KategoriId;
                txtUrunAdi.Text = sonuc.Adi;
                cmbMarka.SelectedValue = sonuc.MarkaId;
                txtOzellik.Text = sonuc.Ozellik;
                txtAdet.Value = (decimal)Convert.ToDouble(sonuc.Adet);
                txtAlis.Value = (decimal)Convert.ToDouble(sonuc.Alis);
                txtSatis.Value = (decimal)Convert.ToDouble(sonuc.Satis);
            }
            catch
            {
                MessageBox.Show("Kayıt Seçilemedi.");
            }
            
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
                    foreach (DataGridViewColumn GridCol in gridStok.Columns)
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

                while (iRow <= gridStok.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = gridStok.Rows[iRow];

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

                            e.Graphics.DrawString("Günlük Tanımlanan Stoklar", new Font(gridStok.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günlük Tanımlanan Stoklar", new Font(gridStok.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(gridStok.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(gridStok.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günlük Tanımlanan Stoklar", new Font(new Font(gridStok.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in gridStok.Columns)
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
                foreach (DataGridViewColumn dgvGridCol in gridStok.Columns)
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

        private void cmbKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Insert)
            {
                AddKategori addKategori = new AddKategori();
                addKategori.Show();
            }
        }

        private void cmbMarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                AddMarka addMarka = new AddMarka();
                addMarka.Show();
            }
        }

        private void btnAddKategori_Click(object sender, EventArgs e)
        {
            AddKategori addKategori = new AddKategori();
            addKategori.Show();
            
        }

        private void btnAddMarka_Click(object sender, EventArgs e)
        {
            AddMarka addMarka = new AddMarka();
            addMarka.Show();
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            StokTanimlama_Load(this, e);

        }
    }
}
