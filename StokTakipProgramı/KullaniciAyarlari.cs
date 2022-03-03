using System;
using System.Collections.Generic;
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
    public partial class KullaniciAyarlari : Form
    {
        public static int userId = 0;
        public static string kullaniciadi;
        public static string sifre;
        public static string tematercih;
        public static int viewId;

        public KullaniciAyarlari()
        {
            InitializeComponent();
        }

        STOKTAKIPEntities db = new STOKTAKIPEntities();
        string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
     
        private void dbSelect()
        {
            try
            {
                var select = "Select K.Id, Ad, Sifre from Sistem.Kullanicilar K Where IsDeleted=0";
                //var list = db.Kullanicilar.Where(x => x.IsDeleted == false).ToList();
                var conn = new SqlConnection(connString);
                var adapter = new SqlDataAdapter(select, conn);

                var commandBuilder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                
                gridKullanici.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Kullanıcılar Gösterilemiyor.");
            }
            
        }
        private void KulaniciAyarlari_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

            

            dbSelect();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar user = new Kullanicilar();
            user.Id = userId;
            user.Ad = txtKullanici.Text.ToString();
            user.Sifre = txtSifre.Text.ToString();
            user.IsDeleted = false;
            db.Kullanicilar.Add(user);
            db.SaveChanges();
            dbSelect();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //projelerde verilerin databasede silinmesi istenmeyen bir durum olduğu için sadece IsDeleted sütununu işaretleyerek silindiğini belirtiyoruz.
            var sonuc = db.Kullanicilar.Where(x => x.Id == viewId).FirstOrDefault();
            sonuc.IsDeleted = true;
            db.SaveChanges();
            MessageBox.Show(" Kayıt silinmiştir.");
            dbSelect();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var user = db.Kullanicilar.Where(x => x.Id == viewId).FirstOrDefault();
            try
            {
                user.Ad = txtKullanici.Text;
                user.Sifre = txtSifre.Text;
                db.SaveChanges();
                dbSelect();
            }
            catch
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
            }
        }


        private void gridKullanici_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                viewId = Convert.ToInt32(gridKullanici.SelectedCells[0].Value.ToString());
                var user = db.Kullanicilar.Where(x => x.Id == viewId).FirstOrDefault();

                txtKullanici.Text = user.Ad;
                txtSifre.Text = user.Sifre;
            }
            catch
            {
                MessageBox.Show("Kayıt Seçilemedi.");
            }
        }

       
    }
}
