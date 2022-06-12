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
        private string employeeName;
        public BedieningFrm(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }

        private void btnTafelOverzicht_Click(object sender, EventArgs e)
        {
            TafelOverzicht tafelOverzicht = new TafelOverzicht();
            tafelOverzicht.LogedInEmployee(employeeName);
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
