using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgramı
{
    public partial class Raporlar : Form
    {

        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        public Raporlar()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
        private void dbIslemKontrol()
        {
            var select = "Select I.Id,I.Tarih,SI.Islem,HesapAdi,S.Adi as Urun,I.SatisFiyat,I.Kdv,I.VergisizFiyat,I.Tutar,I.Aciklama,Case When I.IsDeleted=1 then 'Iptal' Else 'Kayıt' end as Durum from Cari.Islemler I Left Join Sistem.Islem SI on SI.Id =I.Islem Left Join Cari.Hesaplar H on H.Id=I.HesapId Left Join Cari.Stoklar S on S.Id =I.UrunId";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridRapor.DataSource = ds.Tables[0];
        }
        private void dbKasaDurum()
        {
            var select = "Select SI.Islem as Durum,Sum(Case When I.Islem=1 then Tutar else Tutar*-1 end) as Miktar from Cari.Islemler I Left Join Sistem.Islem SI on SI.Id =I.Islem Group by SI.Islem Union all  Select 'TOPLAM',Sum(Tutar) from ( Select Case When Islem=1 then Tutar Else Tutar*-1 end as Tutar from Cari.Islemler )T";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridRapor.DataSource = ds.Tables[0];
        }
        private void dbStokDurum()
        {
            var select = "Select S.Adi as StokAdi, S.Ozellik, Sum(Case When I.Islem=1 then I.Adet else I.Adet*-1 end) as Adet,Avg(SatisFiyat) as SatisFiyat from Cari.Islemler I Left Join Cari.Stoklar S on S.Id =I.UrunId group by S.Adi,S.Ozellik";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridRapor.DataSource = ds.Tables[0];
        }
        private void dbKarAnaliz()
        {
            var select = "Select I.Id as IslemId,S.Adi as Stok,H.HesapAdi as Musteri,(I.SatisFiyat-S.Alis) as Kar,I.Tarih from Cari.Islemler I Left Join Cari.Stoklar S on S.Id =I.UrunId Left Join Cari.Hesaplar H on H.Id=I.HesapId";
            var conn = new SqlConnection(connString);
            var adapter = new SqlDataAdapter(select, conn);

            var commandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            gridRapor.DataSource = ds.Tables[0];
        }
        private void Raporlar_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }

    
        private void btnIslemKontrol_Click(object sender, EventArgs e)
        {
            dbIslemKontrol();
        }

        private void btnKasaDurum_Click(object sender, EventArgs e)
        {
            dbKasaDurum();
        }

        private void btnStokDurum_Click(object sender, EventArgs e)
        {
            dbStokDurum();
        }

        private void btnKarAnaliz_Click(object sender, EventArgs e)
        {
            dbKarAnaliz();
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
                    for (int i = 0; i < gridRapor.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = gridRapor.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < gridRapor.Columns.Count; i++)
                    {
                        for (int j = 0; j < gridRapor.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = gridRapor[i, j].Value;
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
                    foreach (DataGridViewColumn GridCol in gridRapor.Columns)
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

                while (iRow <= gridRapor.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = gridRapor.Rows[iRow];

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

                            e.Graphics.DrawString("Günlük Stok İşlemleri", new Font(gridRapor.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günlük Stok İşlemleri", new Font(gridRapor.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(gridRapor.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(gridRapor.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Günlük Stok İşlemleri", new Font(new Font(gridRapor.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in gridRapor.Columns)
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
                foreach (DataGridViewColumn dgvGridCol in gridRapor.Columns)
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
    }
}
