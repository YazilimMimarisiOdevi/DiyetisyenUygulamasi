using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.Hide();
            frmDiyetisyenEkran diyetisyen_ekran = new frmDiyetisyenEkran();
            diyetisyen_ekran.Show();
        }


    }
}
