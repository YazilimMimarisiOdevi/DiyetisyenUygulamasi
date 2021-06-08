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
    public partial class frmHastaEklemeEkran : Form
    {
        public frmHastaEklemeEkran()
        {
            InitializeComponent();
        }

        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        private int kisiID;
        private string hastalikID = null;

        private void frmHastaEklemeEkran_Load(object sender, EventArgs e)
        {
            HastalikCmbGuncelle();
        }

        void HastalikCmbGuncelle()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //Hastalik adlarini listeleyen komut yazildi.
            cmd.CommandText = "SELECT H.HastalikAdi FROM tblHastalik H";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                //Hastalik adlari combobox'a yazdirildi.
                cmbHastalik.Items.Add(dr["HastalikAdi"]);
            }
            con.Close();
        }

        private void cmbHastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //Secilen hastalik tipinin id'sini bulan komut yazildi.
            cmd.CommandText = "SELECT H.HastalikID FROM tblHastalik H WHERE H.HastalikAdi = '" + cmbHastalik.Text + "'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                //Secilen hastalik tipinin id'si hastalikID degiskenine akratildi.
                this.hastalikID = dr["HastalikID"].ToString();
            }
            con.Close();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                //Hastanin bilgilerini olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblKisi (Isim, Soyisim, TCNo, HastalikID, AktifDiyet)" +
                                              "VALUES (@Isim,@Soyisim,@TCNo,@HastalikID,@AktifDiyet)";
                cmd.Connection = con;
                con.Open();
                //Hastanin bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("Isim", txtIsim.Text);
                cmd.Parameters.AddWithValue("Soyisim", txtSoyisim.Text);
                cmd.Parameters.AddWithValue("TCNo", txtTCNo.Text);
                cmd.Parameters.AddWithValue("HastalikID", this.hastalikID);
                cmd.Parameters.AddWithValue("AktifDiyet", "False");

                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                //Hastanin TC numarasindan KisiID'sini bulma komutu yazildi.
                cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtTCNo.Text + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //KisiID'si bulunan hastanin KisiID'si kisiID degiskenine aktarildi.
                    this.kisiID = Convert.ToInt32(dr["KisiID"]);
                }
                con.Close();

                con.Open();
                //Hastanin kisi tipi olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblKisiTipi (KisiTipiID, KisiTipiAdi, KisiID)" +
                                                  "VALUES (@KisiTipiID,@KisiTipiAdi,@KisiID)";
                //Hastanin kisi tipi bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("KisiTipiID", "3");
                cmd.Parameters.AddWithValue("KisiTipiAdi", "Hasta");
                cmd.Parameters.AddWithValue("KisiID", this.kisiID);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Hasta ekleme islemi basari ile gerceklesti.\nDiyetisyen ekranina aktariliyorsunuz...");
                frmDiyetisyenEkran formDiyetisyenEkran = new frmDiyetisyenEkran();
                formDiyetisyenEkran.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta ekleme islemi sairasinda bir hata ile karsilasildi.\nError: " + ex.Message);
                throw ex;
            }
        }

        bool hareket;
        int fare_x, fare_y;
        private void HastaEklemeEkran_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void HastaEklemeEkran_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void HastaEklemeEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
                this.SetDesktopLocation(MousePosition.X - fare_x, MousePosition.Y - fare_y);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmDiyetisyenEkran formDiyetisyenEkran = new frmDiyetisyenEkran();
            formDiyetisyenEkran.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
