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
        public int kisiID { get; set; }
        public DateTime diyetBasTarih { get; set; }
        public DateTime diyetSonTarih { get; set; }
    }

    abstract class DiyetYontemiImplementor
    {
        public abstract void Uygula(DiyetTakvim takvim);
    }
    
    class AkdenizYontemiUygula : DiyetYontemiImplementor
    {
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        public override void Uygula(DiyetTakvim takvim)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            //Hastanin diyet bilgisini guncelleyen komut yazildi.
            cmd.CommandText = "UPDATE tblKisi SET DiyetID = '1' , AktifDiyet = 'True' " +
                              "WHERE KisiID = '" + takvim.kisiID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            //Hastanin diyet takvim bilgilerini olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblDiyetTakvim (KisiID, DiyetID, DiyetBasTarih, DiyetSonTarih)" +
                                                 "VALUES (@KisiID,@DiyetID,@DiyetBasTarih,@DiyetSonTarih)";
            //Hastanin diyet takvim bilgileri veritabanina aktarildi.
            cmd.Parameters.AddWithValue("KisiID", takvim.kisiID);
            cmd.Parameters.AddWithValue("DiyetID", "1");
            cmd.Parameters.AddWithValue("DiyetBasTarih", takvim.diyetBasTarih);
            cmd.Parameters.AddWithValue("DiyetSonTarih", takvim.diyetSonTarih);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    
    class GlutenFreeYontemiUygula : DiyetYontemiImplementor
    {
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        public override void Uygula(DiyetTakvim takvim)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            //Hastanin diyet bilgisini guncelleyen komut yazildi.
            cmd.CommandText = "UPDATE tblKisi SET DiyetID = '2' , AktifDiyet = 'True' " +
                              "WHERE KisiID = '" + takvim.kisiID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            //Hastanin diyet takvim bilgilerini olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblDiyetTakvim (KisiID, DiyetID, DiyetBasTarih, DiyetSonTarih)" +
                                                 "VALUES (@KisiID,@DiyetID,@DiyetBasTarih,@DiyetSonTarih)";
            //Hastanin diyet takvim bilgileri veritabanina aktarildi.
            cmd.Parameters.AddWithValue("KisiID", takvim.kisiID);
            cmd.Parameters.AddWithValue("DiyetID", "2");
            cmd.Parameters.AddWithValue("DiyetBasTarih", takvim.diyetBasTarih);
            cmd.Parameters.AddWithValue("DiyetSonTarih", takvim.diyetSonTarih);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    
    class DenizUrunleriYontemiUygula : DiyetYontemiImplementor
    {
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        public override void Uygula(DiyetTakvim takvim)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            //Hastanin diyet bilgisini guncelleyen komut yazildi.
            cmd.CommandText = "UPDATE tblKisi SET DiyetID = '3' , AktifDiyet = 'True' " +
                              "WHERE KisiID = '" + takvim.kisiID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            //Hastanin diyet takvim bilgilerini olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblDiyetTakvim (KisiID, DiyetID, DiyetBasTarih, DiyetSonTarih)" +
                                                 "VALUES (@KisiID,@DiyetID,@DiyetBasTarih,@DiyetSonTarih)";
            //Hastanin diyet takvim bilgileri veritabanina aktarildi.
            cmd.Parameters.AddWithValue("KisiID", takvim.kisiID);
            cmd.Parameters.AddWithValue("DiyetID", "3");
            cmd.Parameters.AddWithValue("DiyetBasTarih", takvim.diyetBasTarih);
            cmd.Parameters.AddWithValue("DiyetSonTarih", takvim.diyetSonTarih);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    
    class YesilliklerDunyasiYontemiUygula : DiyetYontemiImplementor
    {
        //Sql veritabanina baglanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=diyUy;Integrated Security=True";

        public override void Uygula(DiyetTakvim takvim)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            //Hastanin diyet bilgisini guncelleyen komut yazildi.
            cmd.CommandText = "UPDATE tblKisi SET DiyetID = '4' , AktifDiyet = 'True' " +
                              "WHERE KisiID = '" + takvim.kisiID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            //Hastanin diyet takvim bilgilerini olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblDiyetTakvim (KisiID, DiyetID, DiyetBasTarih, DiyetSonTarih)" +
                                                 "VALUES (@KisiID,@DiyetID,@DiyetBasTarih,@DiyetSonTarih)";
            //Hastanin diyet takvim bilgileri veritabanina aktarildi.
            cmd.Parameters.AddWithValue("KisiID", takvim.kisiID);
            cmd.Parameters.AddWithValue("DiyetID", "4");
            cmd.Parameters.AddWithValue("DiyetBasTarih", takvim.diyetBasTarih);
            cmd.Parameters.AddWithValue("DiyetSonTarih", takvim.diyetSonTarih);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    abstract class DiyetAbstraction
    {
        public DiyetYontemiImplementor _diyetYontemiImplementor { get; set; }
        public abstract void DiyetUygula(DiyetTakvim takvim);
    }

    class Diyetisyen : DiyetAbstraction
    {
        public override void DiyetUygula(DiyetTakvim takvim)
        {
            _diyetYontemiImplementor.Uygula(takvim);
        }
    }

}
