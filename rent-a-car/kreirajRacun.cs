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
    public partial class kreirajRacun : Form
    {
        private bool Editing { get; set; }
        public int RacunID { get; set; }

        public kreirajRacun()
        {
            InitializeComponent();
        }
        //konstruktor za uredjivanje
        public kreirajRacun(int RacunID)
        {
            InitializeComponent();
            this.RacunID = RacunID;
            this.Editing = true;
        }
    }
}
