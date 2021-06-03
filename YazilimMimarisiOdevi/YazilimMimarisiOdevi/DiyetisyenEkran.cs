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
    public partial class DiyetisyenEkran : Form
    {
        public DiyetisyenEkran()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnHastaEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaEklemeEkran hasta_ekleme = new HastaEklemeEkran();
            hasta_ekleme.Show();
        }

        private void DiyetisyenEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
                this.SetDesktopLocation(MousePosition.X - fare_x, MousePosition.Y - fare_y);
        }
    }
}
