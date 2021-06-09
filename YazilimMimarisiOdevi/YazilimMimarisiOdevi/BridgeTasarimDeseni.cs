using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiOdevi
{
    class BridgeTasarimDeseni
    {
    }

    public class DiyetTakvim
    {
        //Diyet takviminde gerekli properties olusturuldu.
        public int kisiID { get; set; }
        public int diyetID { get; set; }
        public DateTime diyetBasTarih { get; set; }
        public DateTime diyetSonTarih { get; set; }
    }

    abstract class DiyetYontemiImplementor
    {
        //Uygulayici soyut sinif olusturuldu.
        public abstract void Uygula(DiyetTakvim takvim);
    }
    
    class AkdenizYontemiUygula : DiyetYontemiImplementor
    {
        public override void Uygula(DiyetTakvim takvim)
        {
            //Akdeniz diyeti ID'si diyetID degiskenine atandi.
            takvim.diyetID = 1;
        }
    }

    class GlutenFreeYontemiUygula : DiyetYontemiImplementor
    {
        public override void Uygula(DiyetTakvim takvim)
        {
            //Gluten free diyeti ID'si diyetID degiskenine atandi.
            takvim.diyetID = 2;
        }
    }

    class DenizUrunleriYontemiUygula : DiyetYontemiImplementor
    {
        public override void Uygula(DiyetTakvim takvim)
        {
            //Deniz urunleri diyeti ID'si diyetID degiskenine atandi.
            takvim.diyetID = 3;
        }
    }
    
    class YesilliklerDunyasiYontemiUygula : DiyetYontemiImplementor
    {
        public override void Uygula(DiyetTakvim takvim)
        {
            //Yesillikler dunyasi diyeti ID'si diyetID degiskenine atandi.
            takvim.diyetID = 4;
        }
    }

    abstract class DiyetAbstraction
    {
        //Diyet soyut sinifi olusturuldu.
        //Kopru gorevi goren iki abstract sinifi baglayan kod yazildi.
        public DiyetYontemiImplementor _diyetYontemiImplementor { get; set; }
        public abstract void DiyetUygula(DiyetTakvim takvim);
    }

    class Diyetisyen : DiyetAbstraction
    {
        //Veritabanina baglanti kodu olusutruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True");
        //Veritabanina komut yazma kodu olusuturldu.
        SqlCommand cmd = new SqlCommand();
        //Veritabanindan veri okuma kodu olusturuldu.
        SqlDataReader dr;
        //Uygula fonksiyonunda kullanilan degisken olusturuldu.
        string aktifDiyet;

        //Diyetisyen tarafindan veritabanina veriyi yazdirma fonksiyonu olusturuldu.
        public override void DiyetUygula(DiyetTakvim takvim)
        {
            //Uygula fonksiyonuna override edilecek kod yazildi.
            _diyetYontemiImplementor.Uygula(takvim);
            
            //Hastanin kisiID'den aktif diyet durumunu bulan komut yazildi.
            cmd.CommandText = "SELECT K.AktifDiyet FROM tblKisi K WHERE K.KisiID = '" + takvim.kisiID + "'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql'e baglanti acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Hastanin aktif diyet durumu aktifDiyet degiskenine atandi.
                aktifDiyet = dr["AktifDiyet"].ToString();
            }
            //Sql'e baglanti kapandi.
            con.Close();

            if (aktifDiyet == "False")
            {
                //Diyet takvim bilgilerini olusturma komutu yazildi.
                cmd.CommandText = "INSERT INTO tblDiyetTakvim (KisiID, DiyetID, DiyetBasTarih, DiyetSonTarih)" +
                                                     "VALUES (@KisiID,@DiyetID,@DiyetBasTarih,@DiyetSonTarih)";

                con.Open();
                //Hastanin diyet takvimi bilgileri veritabanina aktarildi.
                cmd.Parameters.AddWithValue("KisiID", takvim.kisiID);
                cmd.Parameters.AddWithValue("DiyetID", takvim.diyetID);
                cmd.Parameters.AddWithValue("DiyetBasTarih", takvim.diyetBasTarih);
                cmd.Parameters.AddWithValue("DiyetSonTarih", takvim.diyetSonTarih);

                cmd.ExecuteNonQuery();
                con.Close();

                //Hastanin aktif diyet bilgisini yenileme komutu yazildi.
                cmd.CommandText = "UPDATE tblKisi SET DiyetID = '" + takvim.diyetID + "' , AktifDiyet = 'True'" +
                                  "WHERE KisiID = '" + takvim.kisiID + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                //Hastanin diyetID'sini yenileme komutu yazildi.
                cmd.CommandText = "UPDATE tblKisi SET DiyetID = '" + takvim.diyetID + "'" +
                                  "WHERE KisiID = '" + takvim.kisiID + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //Hastanin diyet takvimi bilgilerini yenileme komutu yazildi.
                cmd.CommandText = "UPDATE tblDiyetTakvim SET DiyetID = '" + takvim.diyetID + "' , " +
                                  "DiyetBasTarih = '" + takvim.diyetBasTarih.ToString("MM-dd-yyyy") + "' ," +
                                  "DiyetSonTarih = '" + takvim.diyetSonTarih.ToString("MM-dd-yyyy") + "' " +
                                  "WHERE KisiID = '" + takvim.kisiID + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

}
