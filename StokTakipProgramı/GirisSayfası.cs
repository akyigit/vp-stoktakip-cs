using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipProgramı
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
            init_Data();
            txtSifre.PasswordChar = '*';
            this.AcceptButton = btnLogin;
        }
        string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True";
        int count = 0;

        void GuvenlikKodu()
        {
            Random rndm = new Random();
            string guvenlikKodu = "";
            string harfler = "QWERTYUIOPASDFGHJKZXCVBNM1234567890";

            for (int i = 0; i < 4; i++)
            {
                guvenlikKodu += harfler[rndm.Next(harfler.Length)];
            }
            lblKod.Text = guvenlikKodu;
        }
        private void GirisSayfası_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtKullanici.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            //{
            //    btnLogin.Enabled = false;
            //}
            //else
            //{
            //    btnLogin.Enabled = true;
            //}
            
            GuvenlikKodu();

        }
        private void save_Data()
        {
            if (rdHatirla.Checked)
            {
                Properties.Settings.Default.UserName = txtKullanici.Text;
                Properties.Settings.Default.Password = txtSifre.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void init_Data()
        {
            if (Properties.Settings.Default.UserName!=string.Empty)
            {
                if (Properties.Settings.Default.Remember==true)
                {
                    txtKullanici.Text = Properties.Settings.Default.UserName;
                    txtSifre.Text = Properties.Settings.Default.Password;
                    rdHatirla.Checked = true;

                }
                else
                {
                    txtKullanici.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string kontrol = "select * from Sistem.Kullanicilar where IsDeleted=0 and Ad='" + txtKullanici.Text + "' and Sifre = '" + txtSifre.Text + "'";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand com = new SqlCommand(kontrol, conn);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read()==true && txtKod.Text==lblKod.Text)
                {
                    save_Data();
                    string workingDirectory = Environment.CurrentDirectory;
                    string logFile = (workingDirectory + "\\Log.txt");
                    //File.SetAttributes(logFile, FileAttributes.Normal);
                    FileStream giris = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
                    StreamWriter streamWriter = new StreamWriter(giris);
                    string hata = "Kullanıcı: " + txtKullanici.Text + " Tarih:" + DateTime.Now.ToString() + "  BAŞARILI GİRİŞ.";
                    streamWriter.WriteLine(hata);
                    streamWriter.Flush();
                    streamWriter.Close();
                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı, parolayı veya kodu yanlış girdiniz. \nTekrar deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string workingDirectory = Environment.CurrentDirectory;
                    string logFile = (workingDirectory + "\\Log.txt");
                    //File.SetAttributes(logFile, FileAttributes.Normal);
                    FileStream giris = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
                    StreamWriter streamWriter = new StreamWriter(giris);
                    string hata = "Kullanıcı: " + txtKullanici.Text + " Tarih:" + DateTime.Now.ToString() + "  HATALI GİRİŞ.";
                    streamWriter.WriteLine(hata);
                    streamWriter.Flush();
                    streamWriter.Close();

                    txtKullanici.Clear();
                    txtSifre.Clear();
                    count += 1;
                    if (count >= 3)
                    {
                        txtKullanici.ReadOnly = true;
                        txtSifre.ReadOnly = true;
                        btnLogin.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı sorunu yaşanmaktadır. Lütfen daha sonra tekrar deneyiniz.");
            }

        }

        private void infobox_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void GirisSayfasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
