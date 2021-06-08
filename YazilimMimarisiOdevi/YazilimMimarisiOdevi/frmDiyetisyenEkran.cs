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
    public partial class frmDiyetisyenEkran : Form
    {
        public frmDiyetisyenEkran()
        {
            InitializeComponent();
        }

        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";
        
        private int kisiID;
        private string diyetID = null;
        private DateTime diyetBasTarih;
        private DateTime diyetSonTarih;

        private void frmDiyetisyenEkran_Load(object sender, EventArgs e)
        {
            DiyetCmbGuncelle();
        }

        void DiyetCmbGuncelle()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //Diyet adlarini listeleyen komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi FROM tblDiyet D";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Diyet adlari combobox'a aktarildi.
                cmbDiyet.Items.Add(dr["DiyetAdi"]);
            }
            con.Close();
        }

        private void cmbDiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //Secilen diyet tipinin id'sini bulan komut yazildi.
            cmd.CommandText = "SELECT D.DiyetID FROM tblDiyet D WHERE D.DiyetAdi = '" + cmbDiyet.Text + "'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Secilen diyet tipinin id'si diyetID degiskenine akratildi.
                this.diyetID = dr["DiyetID"].ToString();
            }
            con.Close();
        }

        private void btnHastayiGoster_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //TC numarasi girilen kisinin KisiID'sini bulma komutu yazildi.
            cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtTCNo.Text + "'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Bulunan KisiID'si kisiID degiskenine aktarildi.
                this.kisiID = Convert.ToInt32(dr["KisiID"]);
            }
            con.Close();

            con.Open();
            //Hastanin diyet takvimi bilgilerini bulma komutu yazildi.
            cmd.CommandText = "SELECT K.Isim, K.Soyisim, K.TCNo, H.HastalikAdi, D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblKisi K INNER JOIN tblHastalik H ON K.HastalikID = H.HastalikID " +
                                             "INNER JOIN tblDiyet D ON K.DiyetID = D.DiyetID " +
                                             "INNER JOIN tblDiyetTakvim DT ON K.KisiID = DT.KisiID " +
                              "WHERE K.KisiID = '" + this.kisiID + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //Hastanin diyet takvimi bilgileri formda gosterildi.
                lblIsimGoster.Text = dr["Isim"].ToString();
                lblSoyisimGoster.Text = dr["Soyisim"].ToString();
                lblTCNoGoster.Text = dr["TCNo"].ToString();
                lblHastalikGoster.Text = dr["HastalikAdi"].ToString();
                lblAktifDiyetGoster.Text = dr["DiyetAdi"].ToString();
                lblDiyetBaslangicDegeri.Text = dr["DiyetBasTarih"].ToString();
                lblDiyetBitisDegeri.Text = dr["DiyetSonTarih"].ToString();
            }
            con.Close();
        }

        private void btnHastayiGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //TC numarasi girilen hastanin KisiID'sini bulma komutu yazildi.
            cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtGuncellemeTCNo.Text + "'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Bulunan KisiID'si kisiID degiskenine aktarildi.
                this.kisiID = Convert.ToInt32(dr["KisiID"]);
            }
            con.Close();

            con.Open();
            //KisiID'sinden aktif diyet bulan komut yazildi.
            cmd.CommandText = "SELECT K.AktifDiyet FROM tblKisi K WHERE K.KisiID = '" + this.kisiID + "'";
            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                //Hastanin aktif diyeti yok ise calisan komut yazildi.
                if (dr["AktifDiyet"].ToString() == "False")
                {
                    //Hastanin diyet bilgilerini guncelleyip forma yazdiran fonksiyon cagirildi.
                    DiyetBilgileriGuncelle();
                }
            }
            con.Close();

            con.Open();
            //Hastanin guncellenen diyet bilgilerini bulma komutu yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblDiyetTakvim DT INNER JOIN tblDiyet D ON DT.DiyetID = D.DiyetID " +
                              "WHERE DT.KisiID = '" + this.kisiID + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Hastanin diyet bilgileri formda gosterildi.
                lblAktifDiyetGoster.Text = dr["DiyetAdi"].ToString();
                lblDiyetBaslangicDegeri.Text = dr["DiyetBasTarih"].ToString();
                lblDiyetBitisDegeri.Text = dr["DiyetSonTarih"].ToString();
            }
            con.Close();
        }

        void DiyetBilgileriGuncelle()
        {
            DiyetAbstraction diyetAbstraction = new Diyetisyen();
            if (this.diyetID == "1")
            {
                diyetAbstraction._diyetYontemiImplementor = new AkdenizYontemiUygula();
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if(this.diyetID == "2")
            {
                diyetAbstraction._diyetYontemiImplementor = new GlutenFreeYontemiUygula();
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if (this.diyetID == "3")
            {
                diyetAbstraction._diyetYontemiImplementor = new DenizUrunleriYontemiUygula();
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if(this.diyetID == "4")
            {
                diyetAbstraction._diyetYontemiImplementor = new YesilliklerDunyasiYontemiUygula();
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
        }

        private void cdrDiyetTakvim_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Formda CDR'dan tarih sectikce guncellenen ve ilgili degiskene atanan kodlar yazildi.
            this.diyetBasTarih = Convert.ToDateTime(e.Start.ToLongDateString());
            this.diyetSonTarih = Convert.ToDateTime(e.End.ToLongDateString());
        }

        private void btnHastaEkleme_Click(object sender, EventArgs e)
        {
            //Hasta ekleme ekranina gidildi.
            frmHastaEklemeEkran formHastaEklemeEkran = new frmHastaEklemeEkran();
            formHastaEklemeEkran.Show();
            this.Hide();
        }


        bool hareket;
        int fare_x, fare_y;
        private void DiyetisyenEkran_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void DiyetisyenEkran_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void DiyetisyenEkran_MouseMove(object sender, MouseEventArgs e)
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
