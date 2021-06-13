using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiOdevi
{
    public partial class frmRaporAlEkran : Form
    {
        public frmRaporAlEkran()
        {
            InitializeComponent();
        }
        //Hastanin kisi id'sini tutmak icin kisiID degiskeni olusturuldu.
        private int kisiID;

        private void btnHTMLRapor_Click(object sender, EventArgs e)
        {
            //RaporBilgisiKisisel sinifi tipinde degisken olusturuldu.
            RaporBilgisiKisisel bilgiKisisel = new RaporBilgisiKisisel();
            //RaporBilgisiDiyet sinifi tipinde degisken olusturuldu.
            RaporBilgisiDiyet bilgiDiyet = new RaporBilgisiDiyet();

            //Hastanin kisiID'sini bulma fonksiyonu cagirildi.
            HastaBilgiAl();
            //KisiID'si bulunan hastanin kisiID'si RaporBilgisi sinifindan kisiID degiskenine aktarildi.
            bilgiKisisel.kisiID = this.kisiID;

            //Rapor olusturma sinifi olusturuldu ve bilgi degiskenleri parametre olarak gonderildi.
            RaporOlusturmaTabani Olusturucu = new HTMLRaporOlusturma(bilgiKisisel, bilgiDiyet);
            //Rapor yonetici sinifi olusturuldu ve rapor olusturm sinifinin degiskeni parametre olarak gonderildi.
            RaporYoneticisi raporYoneticisi = new RaporYoneticisi(Olusturucu);

            string str;

            if (rdoRaporOnIzleme1.Checked == true)
            {
                //Kisisel bilgi yukarida, diyet bilgi asagida olucak sekilde siralama yapildi ve rapor olusturuldu.
                str = raporYoneticisi.Olustur();
            }
            else
            {
                //Diyet bilgi yukarida, kisisel bilgi asagida olucak sekilde siralama yapildi ve rapor olusturuldu.
                str = raporYoneticisi.TerstenOlustur();
            }

            //Html dosyasi olusturuldu.
            string dosyaYolu = "HTMLRapor.html";
            
            File.WriteAllText(dosyaYolu, string.Empty);
            //Dosya yazici modda acildi.
            FileStream fileStream = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
            {
                //Dosyaya yazma kodu yazildi.
                writer.WriteLine(str);
                writer.Close();
            }
            //Dosya kapandi.
            fileStream.Close();

            MessageBox.Show("Rapor HTML formatinda olusturuldu.");
        }

        private void btnJSONRapor_Click(object sender, EventArgs e)
        {
            //RaporBilgisiKisisel sinifi tipinde degisken olusturuldu.
            RaporBilgisiKisisel bilgiKisisel = new RaporBilgisiKisisel();
            //RaporBilgisiDiyet sinifi tipinde degisken olusturuldu.
            RaporBilgisiDiyet bilgiDiyet = new RaporBilgisiDiyet();

            //Hastanin kisiID'sini bulma fonksiyonu cagirildi.
            HastaBilgiAl();
            //KisiID'si bulunan hastanin kisiID'si RaporBilgisi sinifindan kisiID degiskenine aktarildi.
            bilgiKisisel.kisiID = this.kisiID;

            //Rapor olusturma sinifi olusturuldu ve bilgi degiskenleri parametre olarak gonderildi.
            RaporOlusturmaTabani Olusturucu = new JSONRaporOlusturma(bilgiKisisel, bilgiDiyet);
            //Rapor yonetici sinifi olusturuldu ve rapor olusturm sinifinin degiskeni parametre olarak gonderildi.
            RaporYoneticisi raporYoneticisi = new RaporYoneticisi(Olusturucu);

            string str;

            if (rdoRaporOnIzleme1.Checked == true)
            {
                //Kisisel bilgi yukarida, diyet bilgi asagida olucak sekilde siralama yapildi ve rapor olusturuldu.
                str = raporYoneticisi.Olustur();
            }
            else
            {
                //Diyet bilgi yukarida, kisisel bilgi asagida olucak sekilde siralama yapildi ve rapor olusturuldu.
                str = raporYoneticisi.TerstenOlustur();
            }

            //Json dosyasi olusturuldu.
            string dosyaYolu = "JSONRapor.json";

            File.WriteAllText(dosyaYolu, string.Empty);
            //Dosya yazici modda acildi.
            FileStream fileStream = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
            {
                //Dosyaya yazma kodu yazildi.
                writer.WriteLine(str);
                writer.Close();
            }
            //Dosya kapandi.
            fileStream.Close();

            MessageBox.Show("Rapor JSON formatinda olusturuldu.");
        }

        void HastaBilgiAl()
        {
            //Veritabanina baglanti kodu olusturuldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
            //Veritabanina komut yazma kodu olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veritabanindan veri okuma kodu olusturuldu.
            SqlDataReader dr;

            //TC numarasi girilen kisinin KisiID'sini bulma komutu yazildi.
            cmd.CommandText = "SELECT K.KisiID FROM tblKisi K WHERE K.TCNo = '" + txtTCNo.Text + "'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Bulunan KisiID'si kisiID degiskenine aktarildi.
                this.kisiID = Convert.ToInt32(dr["KisiID"]);
            }
            //Sql'e baglanti kapandi.
            con.Close();
        }

        //Formun hareket etmesini saglayici degiskenler olusturuldu.
        bool hareket;
        int fare_x, fare_y;

        //Formun hareket etmesini saglayan fonksiyonlar olusturuldu.
        private void frmRaporAlEkran_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void frmRaporAlEkran_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void frmRaporAlEkran_MouseMove(object sender, MouseEventArgs e)
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
