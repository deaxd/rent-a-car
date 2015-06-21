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
    public partial class kreirajZaposlenik : Form
    {
        private bool Editing { get; set; }
        public int ZaposlenikID { get; set; }

        public kreirajZaposlenik()
        {
            InitializeComponent();
        }
        //konstruktor za uredjivanje
        public kreirajZaposlenik(int ZaposlenikID)
        {
            InitializeComponent();
            this.ZaposlenikID = ZaposlenikID;
            this.Editing = true;
        }
    }
}
