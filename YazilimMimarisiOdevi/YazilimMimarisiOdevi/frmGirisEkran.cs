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
    public partial class frmGirisEkran : Form
    {
        public frmGirisEkran()
        {
            InitializeComponent();
        }
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(connStr);
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veriyi okuyucu olusturuldu.
            SqlDataReader dr;

            //Kullanicinin kisi id'si ve kisi tipi id'si icin degiskenler olusturuldu.
            int kisiID = 0;
            int kisiTipiID = 0;

            //Kullanicinin isim ve sifresinin dogru olup olmadigini ve kisiID'si bulma komutu yazildi.
            cmd.CommandText = "SELECT K.KisiID, K.Isim, K.Soyisim FROM tblKisi K " +
                              "WHERE K.Isim = '" + txtIsim.Text + "' AND K.Sifre = '" + txtSifre.Text + "'";
            //Sql ile baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true (yani isim ve sifre dogru) iken calisan kosul olusturuldu.
            if(dr.Read())
            {
                //Kullanicinin kisiID'si kisiID degiskenine aktarildi.
                kisiID = Convert.ToInt32(dr["KisiID"]);
            }
            else
            {
                MessageBox.Show("Hatalı giriş yapıldı!!\nİsim ve şifrenizi kontrol ediniz.");
            }
            //Sql'e baglanti kapatildi.
            con.Close();

            //KisiID'sinden kisiTipi bulma komutu yazildi.
            cmd.CommandText = "SELECT KT.KisiTipiID FROM tblKisiTipi KT " +
                              "WHERE KT.KisiID = '" + kisiID + "'";
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //KisiTipiID'si kisiTipiID degiskenine aktarildi.
                kisiTipiID = Convert.ToInt32(dr["KisiTipiID"]);
            }
            con.Close();

            //Eger kullanici 1 tipinde (yani admin tipi) ise admin formuna giris yapildi.
            if(kisiTipiID == 1)
            {
                frmAdminEkran formAdminEkran = new frmAdminEkran();

                MessageBox.Show("Admin girişi yapılıyor.");
                //Admin formuna gidildi.
                formAdminEkran.Show();
                this.Hide();
            }
            //Eger kullanici 2 tipinde (yani diyetisyen tipi) ise diyetisyen formuna giris yapildi.
            else if(kisiTipiID == 2)
            {
                frmDiyetisyenEkran formDiyetisyenEkran = new frmDiyetisyenEkran();

                MessageBox.Show("Diyetisyen girişi yapılıyor.");
                //Diyetisyen formuna gidildi.
                formDiyetisyenEkran.Show();
                this.Hide();
            }
        }

        //Formun hareket etmesini saglayici degiskenler olusturuldu.
        bool hareket;
        int fare_x, fare_y;

        //Formun hareket etmesini saglayan fonksiyonlar olusturuldu.
        private void frmGirisEkran_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void frmGirisEkran_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void frmGirisEkran_MouseMove(object sender, MouseEventArgs e)
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
