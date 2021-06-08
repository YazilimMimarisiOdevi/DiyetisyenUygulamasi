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
            //Diyetisyen formu olusturuldu.
            frmDiyetisyenEkran formDiyetisyenEkran = new frmDiyetisyenEkran();
            //Veriyi okuyucu olusturuldu.
            SqlDataReader dr;

            //Sql baglantisi acildi.
            con.Open();
            //Sql ile baglanti saglandi.
            cmd.Connection = con;
            //Kullanicinin isim ve sifresinin dogru olup olmadigini sorgulama komutu yazildi.
            cmd.CommandText = "SELECT K.Isim, K.Sifre FROM tblKisi K " +
                              "WHERE K.Isim = '" + txtIsim.Text + "' AND K.Sifre = '" + txtSifre.Text + "'";
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true (yani isim ve sifre dogru) iken calisan kosul olusturuldu.
            if(dr.Read())
            {
                MessageBox.Show("Giriş yapılıyor.");
                //Diyetisyen formu acildi.
                formDiyetisyenEkran.Show();
                //Suanki form kapandi.
                this.Hide();
            }
            else
            {
                //Islem basarisiz oldugu icin ekrana bildirim atildi.
                MessageBox.Show("İsim ve şifrenizi kontrol ediniz.");
            }
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        bool hareket;
        int fare_x, fare_y;
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
            Application.Exit();
        }

    }
}
