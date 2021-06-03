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
    public partial class HastaEklemeEkran : Form
    {
        public HastaEklemeEkran()
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
            DiyetisyenEkran diyetisyen_ekran = new DiyetisyenEkran();
            diyetisyen_ekran.Show();
        }

        private void cdrDiyetTakvim_DateChanged(object sender, DateRangeEventArgs e)
        {        
            lblDiyetBaslangicGoster.Text = e.Start.ToLongDateString();
            lblDiyetBitisGoster.Text = e.End.ToLongDateString();    
        }
    }
}
