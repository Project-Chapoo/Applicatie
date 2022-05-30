using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using ChapeauModels;

namespace ChapeauUI
{
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();
        }
        private void btnTafel1_Click(object sender, EventArgs e)
        {
            TablesService tablesService = new TablesService();

            bool gereserveerd = tablesService.Reserved(int.Parse(btnTafel1.Text));
            //tijdelijk
            MessageBox.Show(gereserveerd.ToString());

            TafelStatus(gereserveerd);
            
        }
        private void TafelStatus(bool gereserveerd)
        {
            if (gereserveerd == true)
                lblViewStatus.Text = "Gereserveerd";
            else
                lblViewStatus.Text = "Vrij";
        }
        private void btnKeukenOverzicht_Click(object sender, EventArgs e)
        {
            //form keuken overzicht laten zien
        }
        private void btnBarOverzicht_Click(object sender, EventArgs e)
        {
            //form bar overzicht laten zien
        }

        private void btnKassaLogOut_Click(object sender, EventArgs e)
        {
            KassaLogin kassaLogin = new KassaLogin();
            this.Hide();
            kassaLogin.Closed += (s, args) => this.Close();
            kassaLogin.Show();
        }
    }
}
