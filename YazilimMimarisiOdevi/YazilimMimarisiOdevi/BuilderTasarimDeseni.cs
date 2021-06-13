using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YazilimMimarisiOdevi
{
    class BuilderTasarimDeseni
    {
    }

    public class RaporBilgisiKisisel
    {
        //Rapor bilgisi kisisel de gerekli properties olusturuldu.
        public int kisiID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string TCNo { get; set; }
        public string hastalikAdi { get; set; }
    }

    public class RaporBilgisiDiyet
    {
        //Rapor bilgisi diyet de gerekli properties olusturuldu.
        public string diyetAdi { get; set; }
        public DateTime diyetBasTarih { get; set; }
        public DateTime diyetSonTarih { get; set; }
    }

    public abstract class RaporOlusturmaTabani
    {
        //Rapor bilgi kisisel sinifi protected olusturuldu.
        protected RaporBilgisiKisisel BilgiKisisel;
        //Rapor bilgi diyet sinifi protected olusturuldu.
        protected RaporBilgisiDiyet BilgiDiyet;

        //Abstract rapor olusturma tabani sinifi olusturuldu.
        public RaporOlusturmaTabani(RaporBilgisiKisisel raporBilgisiKisisel, RaporBilgisiDiyet raporBilgisiDiyet)
        {
            BilgiKisisel = raporBilgisiKisisel;
            BilgiDiyet = raporBilgisiDiyet;
        }

        //Abstract olarak fonksiyonlar olusturuldu.
        public abstract string KisiselBilgi();
        public abstract string DiyetBilgi();
    }

    public class JSONRaporOlusturma : RaporOlusturmaTabani
    {
        public JSONRaporOlusturma(RaporBilgisiKisisel raporBilgisiKisisel, RaporBilgisiDiyet raporBilgisiDiyet) : base(raporBilgisiKisisel,raporBilgisiDiyet)
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
                              "WHERE K.KisiID = '" + BilgiKisisel.kisiID + "' AND KT.KisiTipiID = '3'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hasta bilgileri formda gosterildi.
                BilgiKisisel.isim = dr["Isim"].ToString();
                BilgiKisisel.soyisim = dr["Soyisim"].ToString();
                BilgiKisisel.TCNo = dr["TCNo"].ToString();
                BilgiKisisel.hastalikAdi = dr["HastalikAdi"].ToString();
            }
            //Sql'e baglanti kapandi.
            con.Close();

            //Hastanin kisisel bilgileri json tipine donusturuldu.
            string jsonKisisel = JsonConvert.SerializeObject(BilgiKisisel);
            return jsonKisisel;
        }
        public override string DiyetBilgi()
        {
            //Hastanin diyet bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblDiyetTakvim DT INNER JOIN tblDiyet D ON DT.DiyetID = D.DiyetID " +
                                                     "INNER JOIN tblKisiTipi KT ON DT.KisiID = KT.KisiID " +
                              "WHERE DT.KisiID = '" + BilgiKisisel.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hastanin diyet bilgileri formda gosterildi.
                BilgiDiyet.diyetAdi = dr["DiyetAdi"].ToString();
                BilgiDiyet.diyetBasTarih = Convert.ToDateTime(dr["DiyetBasTarih"]);
                BilgiDiyet.diyetSonTarih = Convert.ToDateTime(dr["DiyetSonTarih"]);
            }
            con.Close();

            //Hastanin diyet bilgileri json tipine donusturuldu.
            string jsonDiyet = JsonConvert.SerializeObject(BilgiDiyet);
            return jsonDiyet;
        }
    }

    public class HTMLRaporOlusturma : RaporOlusturmaTabani
    {
        public HTMLRaporOlusturma(RaporBilgisiKisisel raporBilgisiKisisel, RaporBilgisiDiyet raporBilgisiDiyet) : base(raporBilgisiKisisel, raporBilgisiDiyet)
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
                              "WHERE K.KisiID = '" + BilgiKisisel.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hasta bilgileri formda gosterildi.
                BilgiKisisel.isim = dr["Isim"].ToString();
                BilgiKisisel.soyisim = dr["Soyisim"].ToString();
                BilgiKisisel.TCNo = dr["TCNo"].ToString();
                BilgiKisisel.hastalikAdi = dr["HastalikAdi"].ToString();
            }
            con.Close();

            //Hastanin kisisel bilgileri icin string olusturuldu ve bilgiler yazildi.
            string kisiselStr = "****Hastanın kişisel bilgileri****\n" +
                                "Hastanın adı: " + BilgiKisisel.isim + "\n" +
                                "Hastanın soyadı: " + BilgiKisisel.soyisim + "\n" +
                                "Hastanın TC numarası: " + BilgiKisisel.TCNo + "\n" +
                                "Hastanın hastalık adı: " + BilgiKisisel.hastalikAdi + "\n\n";
            return kisiselStr;
        }
        public override string DiyetBilgi()
        { 
            //Hastanin diyet bilgilerini bulan komut yazildi.
            cmd.CommandText = "SELECT D.DiyetAdi, DT.DiyetBasTarih, DT.DiyetSonTarih " +
                              "FROM tblDiyetTakvim DT INNER JOIN tblDiyet D ON DT.DiyetID = D.DiyetID " +
                                                     "INNER JOIN tblKisiTipi KT ON DT.KisiID = KT.KisiID " +
                              "WHERE DT.KisiID = '" + BilgiKisisel.kisiID + "' AND KT.KisiTipiID = '3'";
            cmd.Connection = con;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Hastanin diyet bilgileri formda gosterildi.
                BilgiDiyet.diyetAdi = dr["DiyetAdi"].ToString();
                BilgiDiyet.diyetBasTarih = Convert.ToDateTime(dr["DiyetBasTarih"]);
                BilgiDiyet.diyetSonTarih = Convert.ToDateTime(dr["DiyetSonTarih"]);
            }
            con.Close();

            //Hastanin diyet bilgileri icin string olusturuldu ve bilgiler yazildi.
            string diyetStr = "****Hastanın diyet bilgileri****\n" +
                              "Hastanın diyet adı: " + BilgiDiyet.diyetAdi + "\n" +
                              "Hastanın diyete başlangıç tarihi: " + BilgiDiyet.diyetBasTarih.ToString("MM-dd-yyyy") + "\n" +
                              "Hastanın diyetinin bitiş tarihi: " + BilgiDiyet.diyetSonTarih.ToString("MM-dd-yyyy") + "\n\n";
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
