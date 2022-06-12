using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class BedieningFrm : Form
    {
        public BedieningFrm()
        {
            InitializeComponent();
        }

        private void btnTafelOverzicht_Click(object sender, EventArgs e)
        {
            TafelOverzicht tafelOverzicht = new TafelOverzicht();
            this.Hide();
            tafelOverzicht.Closed += (s, args) => this.Close();
            tafelOverzicht.Show();
        }
        private void btnBestellingOpnemen_Click(object sender, EventArgs e)
        {
            PDAOrdering_Joey PDAOrdering = new PDAOrdering_Joey();
            this.Hide();
            PDAOrdering.Closed += (s, args) => this.Close();
            PDAOrdering.Show();
        }
    }
}
