using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimMimarisiOdevi
{
    public partial class LoginEkran : Form
    {
        public LoginEkran()
        {
            InitializeComponent();
        }

        public static SqlConnection connection = new SqlConnection(@"Data Source =.\; Initial Catalog = YazilimMimarisi; Integrated Security = True");
        private void LoginEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool hareket;
        int fare_x, fare_y;
        private void LoginEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            fare_x = e.X;
            fare_y = e.Y;
        }

        private void LoginEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DiyetisyenEkran diyetisyen_ekran = new DiyetisyenEkran();
            diyetisyen_ekran.Show();
        }

        private void LoginEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
                this.SetDesktopLocation(MousePosition.X - fare_x, MousePosition.Y - fare_y);
        }
    }
}
