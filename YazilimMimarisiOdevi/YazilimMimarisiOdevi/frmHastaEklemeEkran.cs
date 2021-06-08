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
        //Veritabanina baglanti kodu olusutruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
        //Veritabanina komut yazma kodu olusuturldu.
        SqlCommand cmd = new SqlCommand();
        //Veritabanindan veri okuma kodu olusturuldu.
        SqlDataReader dr;

        //Hasta ekleme formunda ortak kullanilan degiskenler olusturuldu.
        private int kisiID;
        private string hastalikID = null;

        private void frmHastaEklemeEkran_Load(object sender, EventArgs e)
        {
            //Hasta ekleme formu her acildiginda hastalik combobox'i guncelleyici fonksiyon cagirildi.
            HastalikCmbGuncelle();
        }

        void HastalikCmbGuncelle()
        {
            //Hastalik adlarini listeleyen komut yazildi.
            cmd.CommandText = "SELECT H.HastalikAdi FROM tblHastalik H";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.x
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                //Hastalik adlari combobox'a yazdirildi.
                cmbHastalik.Items.Add(dr["HastalikAdi"]);
            }
            //Sql'e baglanti kapandi.
            con.Close();
        }

        private void cmbHastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                
                //Hastanin TC numarasindan KisiID'sini bulma komutu yazildi.
                cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtTCNo.Text + "'";
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //KisiID'si bulunan hastanin KisiID'si kisiID degiskenine aktarildi.
                    this.kisiID = Convert.ToInt32(dr["KisiID"]);
                }
                con.Close();

                //Hastanin kisi tipi olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblKisiTipi (KisiTipiID, KisiTipiAdi, KisiID)" +
                                                  "VALUES (@KisiTipiID,@KisiTipiAdi,@KisiID)";
                con.Open();

                //Hastanin kisi tipi bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("KisiTipiID", "3");
                cmd.Parameters.AddWithValue("KisiTipiAdi", "Hasta");
                cmd.Parameters.AddWithValue("KisiID", this.kisiID);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Hasta ekleme islemi basari ile gerceklesti.\nDiyetisyen ekranina aktariliyorsunuz...");
                
                //Diyetisyen formuna gidildi.
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

        //Formun hareket etmesini saglayici degiskenler olusturuldu.
        bool hareket;
        int fare_x, fare_y;

        //Formun hareket etmesini saglayan fonksiyonlar olusturuldu.
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
            //Diyetisyen formuna gidildi.
            frmDiyetisyenEkran formDiyetisyenEkran = new frmDiyetisyenEkran();
            formDiyetisyenEkran.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Uygulama kapatildi.
            Application.Exit();
        }

    }
}
