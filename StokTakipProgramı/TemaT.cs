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
    internal class TemaT
    {
        public static Color tema;
        public static Color font;
        SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;");
        //string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
        public void TemaDegistir()
        {
            SqlCommand cmd = new SqlCommand("SELECT TEMA FROM Temalar WHERE ID='1'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var d = reader["TEMA"].ToString();
                if (d == "2")
                {

                   font = Color.Black;

                    tema = Color.WhiteSmoke;
                }
                else if (d == "1")
                {

                    
                        font = Color.WhiteSmoke;

                    tema = Color.DimGray;
                }
            }


            con.Close();
        }
    }
}
