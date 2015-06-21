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
    public partial class kreirajPosudba : Form
    {
        private bool Editing { get; set; }
        public int PosudbaID { get; set; }

        public kreirajPosudba()
        {
            InitializeComponent();
        }
        //konstruktor za uredjivanje
        public kreirajPosudba(int PosudbaID)
        {
            InitializeComponent();
            this.PosudbaID = PosudbaID;
            this.Editing = true;
        }
    }
}
