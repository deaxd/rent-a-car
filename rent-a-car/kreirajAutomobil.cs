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
    public partial class kreirajAutomobil : Form
    {
        private bool Editing { get; set; }
        public int  AutomobilID { get; set; }

        public kreirajAutomobil()
        {
            InitializeComponent();
        }
        //konstruktor za uredjivanje
        public kreirajAutomobil(int AutomobilID)
        {
            InitializeComponent();
            this.AutomobilID = AutomobilID;
            this.Editing = true;
        }
    }
}
