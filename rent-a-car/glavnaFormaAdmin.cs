using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class glavnaFormaAdmin : Form
    {
        public glavnaFormaAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glavnaFormaAdmin.ActiveForm.Close();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            kreirajPosudba posudba = new kreirajPosudba();
            posudba.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            kreirajRacun racun = new kreirajRacun();
            racun.Show();
        }

        private void dodajNoviAutomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kreirajAutomobil automobil = new kreirajAutomobil();
            automobil.Show();
        }

        private void dodajNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kreirajKlijent klijent = new kreirajKlijent();
            klijent.Show();
        }

        private void dodajNovogZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kreirajZaposlenik zaposlenik = new kreirajZaposlenik();
            zaposlenik.Show();
        }
    }
}
