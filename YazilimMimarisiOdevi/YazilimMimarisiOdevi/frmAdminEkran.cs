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

namespace YazilimMimarisiOdevi
{
    public partial class frmAdminEkran : Form
    {
        public frmAdminEkran()
        {
            InitializeComponent();
        }
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        private void btnDiyetisyenEkleme_Click(object sender, EventArgs e)
        {
            //Veritabanina baglanti kodu olusturuldu.
            SqlConnection con = new SqlConnection(connStr);
            //Veritabanina komut yazma kodu olusuturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veritabanindan veri okuma kodu olusturuldu.
            SqlDataReader dr;
            
            //Diyetisyenin kisiID degiskeni olusturuldu.
            int kisiID = 0;

            try
            {
                //Diyetisyenin bilgilerini olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblKisi (Isim, Soyisim, TCNo, Sifre)" +
                                              "VALUES (@Isim,@Soyisim,@TCNo,@Sifre)";
                //Sql'e baglanti saglandi.
                cmd.Connection = con;
                //Sql'e baglanti acildi.
                con.Open();

                //Diyetisyenin bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("Isim", txtIsim.Text);
                cmd.Parameters.AddWithValue("Soyisim", txtSoyisim.Text);
                cmd.Parameters.AddWithValue("TCNo", txtTCNo.Text);
                cmd.Parameters.AddWithValue("Sifre", txtSifre.Text);
                //Komut calistirildi.
                cmd.ExecuteNonQuery();
                //Sql'e baglanti kapatildi.
                con.Close();

                //Diyetisyenin TC numarasindan KisiID'sini bulma komutu yazildi.
                cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtTCNo.Text + "'";
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //KisiID'si bulunan diyetisyenin KisiID'si kisiID degiskenine aktarildi.
                    kisiID = Convert.ToInt32(dr["KisiID"]);
                }
                con.Close();

                //Diyetisyenin kisi tipi olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblKisiTipi (KisiTipiID, KisiTipiAdi, KisiID)" +
                                                  "VALUES (@KisiTipiID,@KisiTipiAdi,@KisiID)";
                con.Open();

                //Diyetisyenin kisi tipi bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("KisiTipiID", "2");
                cmd.Parameters.AddWithValue("KisiTipiAdi", "Diyetisyen");
                cmd.Parameters.AddWithValue("KisiID", kisiID);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Diyetisyen ekleme islemi basari ile gerceklesti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Diyetisyen ekleme islemi sirasinda bir hata ile karsilasildi.\nError: " + ex.Message);
                throw ex;
            }
        }

        //Formun hareket etmesini saglayici degiskenler olusturuldu.
        bool hareket;
        int fare_x, fare_y;

        //Formun hareket etmesini saglayan fonksiyonlar olusturuldu.
        private void frmAdminEkran_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void frmAdminEkran_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void frmAdminEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
                this.SetDesktopLocation(MousePosition.X - fare_x, MousePosition.Y - fare_y);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Uygulama kapatildi.
            Application.Exit();
        }
    }
}
