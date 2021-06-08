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
        //Veritabanina baglanti kodu olusutruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
        //Veritabanina komut yazma kodu olusuturldu.
        SqlCommand cmd = new SqlCommand();
        //Veritabanindan veri okuma kodu olusturuldu.
        SqlDataReader dr;

        //Diyetisyen formunda ortak kullanilan degiskenler olusturuldu.
        private int kisiID;
        private string diyetID = null;
        private DateTime diyetBasTarih;
        private DateTime diyetSonTarih;

        private void frmDiyetisyenEkran_Load(object sender, EventArgs e)
        {
            //Diyetisyen formu her acildiginda diyet combobox'i guncelleyici fonksiyon cagirildi.
            DiyetCmbGuncelle();
        }

        void DiyetCmbGuncelle()
        {
            //Diyet adlarini listeleyen komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi FROM tblDiyet D";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Diyet adlari combobox'a aktarildi.
                cmbDiyet.Items.Add(dr["DiyetAdi"]);
            }
            //Sql'e baglanti kapandi.
            con.Close();
        }

        private void cmbDiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //Hastanin bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT K.Isim, K.Soyisim, K.TCNo, H.HastalikAdi " +
                              "FROM tblKisi K INNER JOIN tblHastalik H ON K.HastalikID = H.HastalikID " +
                              "WHERE K.KisiID = '" + this.kisiID + "'";
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                //Hasta bilgileri formda gosterildi.
                lblIsimGoster.Text = dr["Isim"].ToString();
                lblSoyisimGoster.Text = dr["Soyisim"].ToString();
                lblTCNoGoster.Text = dr["TCNo"].ToString();
                lblHastalikGoster.Text = dr["HastalikAdi"].ToString();
            }
            con.Close();

            con.Open();
            //Hastanin diyet bilgilerini bulan komut yazildi.
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

        private void btnHastayiGuncelle_Click(object sender, EventArgs e)
        {
            //Hastanin TC numarasindan kisiID'sini bulan komut yazildi.
            cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtGuncellemeTCNo.Text + "'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                //Hastanin KisiID'si kisiID degiskenine aktarildi.
                this.kisiID = Convert.ToInt32(dr["KisiID"]);
            }
            con.Close();

            //Diyet takvimini olusturma ve bridge tasarim desenini uygulayan fonksiyon cagirildi.
            DiyetTakvimiOlustur();
            MessageBox.Show("Hastanin diyet bilgileri yenilendi.");
        }

        void DiyetTakvimiOlustur()
        {
            //Diyetin olusturuldugu abstract sinif cagirildi.
            DiyetAbstraction diyetAbstraction = new Diyetisyen();
            
            //DiyetID'sine gore hangi diyetin uygulanacagini belirleyen sorgular yazildi.
            if (this.diyetID == "1")
            {
                //Abstract siniftan implementor sinifa erisim saglayan kod yazildi.
                diyetAbstraction._diyetYontemiImplementor = new AkdenizYontemiUygula();
                //Diyet uygula fonksiyonu gerekli bilgileri alarak override edilmeye gonderildi. 
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if(this.diyetID == "2")
            {
                //Abstract siniftan implementor sinifa erisim saglayan kod yazildi.
                diyetAbstraction._diyetYontemiImplementor = new GlutenFreeYontemiUygula();
                //Diyet uygula fonksiyonu gerekli bilgileri alarak override edilmeye gonderildi. 
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if (this.diyetID == "3")
            {
                //Abstract siniftan implementor sinifa erisim saglayan kod yazildi.
                diyetAbstraction._diyetYontemiImplementor = new DenizUrunleriYontemiUygula();
                //Diyet uygula fonksiyonu gerekli bilgileri alarak override edilmeye gonderildi. 
                diyetAbstraction.DiyetUygula(new DiyetTakvim
                {
                    kisiID = this.kisiID,
                    diyetBasTarih = this.diyetBasTarih,
                    diyetSonTarih = this.diyetSonTarih
                });
            }
            else if(this.diyetID == "4")
            {
                //Abstract siniftan implementor sinifa erisim saglayan kod yazildi.
                diyetAbstraction._diyetYontemiImplementor = new YesilliklerDunyasiYontemiUygula();
                //Diyet uygula fonksiyonu gerekli bilgileri alarak override edilmeye gonderildi. 
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
            //Hasta ekleme formuna gidildi.
            frmHastaEklemeEkran formHastaEklemeEkran = new frmHastaEklemeEkran();
            formHastaEklemeEkran.Show();
            this.Hide();
        }
        
        //Formun hareket etmesini saglayici degiskenler olusturuldu.
        bool hareket;
        int fare_x, fare_y;

        //Formun hareket etmesini saglayan fonksiyonlar olusturuldu.
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
            //Uygulama kapatildi.
            Application.Exit();
        }
    }
}
