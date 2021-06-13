using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiOdevi
{
    class BuilderTasarimDeseni
    {
    }

    public class RaporBilgisi
    {
        //Rapor bilgisinde gerekli properties olusturuldu.
        public int kisiID;
        public string isim;
        public string soyisim;
        public string TCNo;
        public string hastalikAdi;
        public string diyetAdi;
        public DateTime diyetBasTarih;
        public DateTime diyetSonTarih;
    }

    public abstract class RaporOlusturmaTabani
    {
        //Rapor bilgi sinifi protected olusturuldu.
        protected RaporBilgisi Bilgi;
        //Abstract rapor olusturma tabani sinifi olusturuldu.
        public RaporOlusturmaTabani(RaporBilgisi raporBilgisi)
        {
            Bilgi = raporBilgisi;
        }

        //Abstract olarak fonksiyonlar olusturuldu.
        public abstract string KisiselBilgi();
        public abstract string DiyetBilgi();
    }

    public class JSONRaporOlusturma : RaporOlusturmaTabani
    {
        public JSONRaporOlusturma(RaporBilgisi raporBilgisi) : base(raporBilgisi)
        {
            
        }

        //Veritabanina baglanti kodu olusutruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
        //Veritabanina komut yazma kodu olusuturldu.
        SqlCommand cmd = new SqlCommand();
        //Veritabanindan veri okuma kodu olusturuldu.
        SqlDataReader dr;

        public override string KisiselBilgi()
        {
            //Hastanin bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT K.Isim, K.Soyisim, K.TCNo, H.HastalikAdi " +
                              "FROM tblKisi K INNER JOIN tblHastalik H ON K.HastalikID = H.HastalikID " +
                                             "INNER JOIN tblKisiTipi KT ON K.KisiID = KT.KisiID " +
                              "WHERE K.KisiID = '" + Bilgi.kisiID + "' AND KT.KisiTipiID = '3'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hasta bilgileri formda gosterildi.
                Bilgi.isim = dr["Isim"].ToString();
                Bilgi.soyisim = dr["Soyisim"].ToString();
                Bilgi.TCNo = dr["TCNo"].ToString();
                Bilgi.hastalikAdi = dr["HastalikAdi"].ToString();
            }
            //Sql'e baglanti kapandi.
            con.Close();

            //Hastanin kisisel bilgileri icin string olusturuldu ve bilgiler yazildi.
            string kisiselStr = "****Hastanın kişisel bilgileri****\n" +
                                "Hastanın adı: " + Bilgi.isim + "\n" +
                                "Hastanın soyadı: " + Bilgi.soyisim + "\n" +
                                "Hastanın TC numarası: " + Bilgi.TCNo + "\n" +
                                "Hastanın hastalık adı: " + Bilgi.hastalikAdi + "\n\n";
            return kisiselStr;
        }
        public override string DiyetBilgi()
        {
            //Hastanin diyet bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblDiyetTakvim DT INNER JOIN tblDiyet D ON DT.DiyetID = D.DiyetID " +
                                                     "INNER JOIN tblKisiTipi KT ON DT.KisiID = KT.KisiID " +
                              "WHERE DT.KisiID = '" + Bilgi.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hastanin diyet bilgileri formda gosterildi.
                Bilgi.diyetAdi = dr["DiyetAdi"].ToString();
                Bilgi.diyetBasTarih = Convert.ToDateTime(dr["DiyetBasTarih"]);
                Bilgi.diyetSonTarih = Convert.ToDateTime(dr["DiyetSonTarih"]);
            }
            con.Close();

            //Hastanin diyet bilgileri icin string olusturuldu ve bilgiler yazildi.
            string diyetStr = "****Hastanın diyet bilgileri****\n" +
                              "Hastanın diyet adı: " + Bilgi.diyetAdi + "\n" +
                              "Hastanın diyete başlangıç tarihi: " + Bilgi.diyetBasTarih.ToString("MM-dd-yyyy") + "\n" +
                              "Hastanın diyetinin bitiş tarihi: " + Bilgi.diyetSonTarih.ToString("MM-dd-yyyy") + "\n\n";
            return diyetStr;
        }
    }

    public class HTMLRaporOlusturma : RaporOlusturmaTabani
    {
        public HTMLRaporOlusturma(RaporBilgisi raporBilgisi) : base(raporBilgisi)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public override string KisiselBilgi()
        {
            //Hastanin bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT K.Isim, K.Soyisim, K.TCNo, H.HastalikAdi " +
                              "FROM tblKisi K INNER JOIN tblHastalik H ON K.HastalikID = H.HastalikID " +
                                             "INNER JOIN tblKisiTipi KT ON K.KisiID = KT.KisiID " +
                              "WHERE K.KisiID = '" + Bilgi.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hasta bilgileri formda gosterildi.
                Bilgi.isim = dr["Isim"].ToString();
                Bilgi.soyisim = dr["Soyisim"].ToString();
                Bilgi.TCNo = dr["TCNo"].ToString();
                Bilgi.hastalikAdi = dr["HastalikAdi"].ToString();
            }
            con.Close();

            //Hastanin kisisel bilgileri icin string olusturuldu ve bilgiler yazildi.
            string kisiselStr = "****Hastanın kişisel bilgileri****\n" +
                                "Hastanın adı: " + Bilgi.isim + "\n" +
                                "Hastanın soyadı: " + Bilgi.soyisim + "\n" +
                                "Hastanın TC numarası: " + Bilgi.TCNo + "\n" +
                                "Hastanın hastalık adı: " + Bilgi.hastalikAdi + "\n\n";
            return kisiselStr;
        }
        public override string DiyetBilgi()
        { 
            //Hastanin diyet bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblDiyetTakvim DT INNER JOIN tblDiyet D ON DT.DiyetID = D.DiyetID " +
                                                     "INNER JOIN tblKisiTipi KT ON DT.KisiID = KT.KisiID " +
                              "WHERE DT.KisiID = '" + Bilgi.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hastanin diyet bilgileri formda gosterildi.
                Bilgi.diyetAdi = dr["DiyetAdi"].ToString();
                Bilgi.diyetBasTarih = Convert.ToDateTime(dr["DiyetBasTarih"]);
                Bilgi.diyetSonTarih = Convert.ToDateTime(dr["DiyetSonTarih"]);
            }
            con.Close();

            //Hastanin diyet bilgileri icin string olusturuldu ve bilgiler yazildi.
            string diyetStr = "****Hastanın diyet bilgileri****\n" +
                              "Hastanın diyet adı: " + Bilgi.diyetAdi + "\n" +
                              "Hastanın diyete başlangıç tarihi: " + Bilgi.diyetBasTarih.ToString("MM-dd-yyyy") + "\n" +
                              "Hastanın diyetinin bitiş tarihi: " + Bilgi.diyetSonTarih.ToString("MM-dd-yyyy") + "\n\n";
            return diyetStr;
        }
    }

    public class RaporYoneticisi
    {
        //Rapor yoneticisi sinifi rapor olusturma tabani sinifina baglandi.
        private RaporOlusturmaTabani RaporOlusturucu;
        public RaporYoneticisi(RaporOlusturmaTabani raporOlusturucu)
        {
            RaporOlusturucu = raporOlusturucu;
        }

        //Siralama fonksiyonu olusturuldu.
        public string Olustur()
        {
            string sirala = RaporOlusturucu.KisiselBilgi();
            sirala += RaporOlusturucu.DiyetBilgi();
            return sirala;
        }

        //Tersten siralama fonksiyonu olusturuldu.
        public string TerstenOlustur()
        {
            string sirala = RaporOlusturucu.DiyetBilgi();
            sirala += RaporOlusturucu.KisiselBilgi();
            return sirala;
        }
    }
}
