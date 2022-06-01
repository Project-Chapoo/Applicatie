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
using ChapeauUI.Forms;

namespace ChapeauUI
{
    public partial class TafelOverzicht : Form
    {
        private int tafelNummer;
        public TafelOverzicht()
        {
            InitializeComponent();
            
        }
        private void TafelStatus(int TafelNummer)
        {
            TablesService tablesService = new TablesService();
            Tables table = tablesService.IsReserved(TafelNummer);

            if (table.Reserved == true)
                lblViewStatus.Text = "Bezet";
            else
                lblViewStatus.Text = "Vrij";
        }
        
        private void btnKassaLogOut_Click(object sender, EventArgs e)
        {
            KassaLogin kassaLogin = new KassaLogin();
            this.Hide();
            kassaLogin.Closed += (s, args) => this.Close();
            kassaLogin.Show();
        }
        private void btnTafel1_Click(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel1.Text));
        }
        private void btnTafel2_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel2.Text));
        }
        private void btnTafel3_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel3.Text));
        }
        private void btnTafel4_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel4.Text));
        }
        private void btnTafel5_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel5.Text));
        }
        private void btnTafel6_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel6.Text));
        }
        private void btnTafel7_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel7.Text));
        }
        private void btnTafel8_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel8.Text));
        }
        private void btnTafel9_Click_1(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel9.Text));
        }
        private void btnTafel10_Click(object sender, EventArgs e)
        {
            TafelNummer(int.Parse(btnTafel10.Text));
        }
        private void btnKeukenOverzicht_Click_1(object sender, EventArgs e)
        {
            KeukenFrm keukenForm = new KeukenFrm();
            this.Hide();
            keukenForm.Closed += (s, args) => this.Close();
            keukenForm.Show();
        }
        private void btnBarOverzicht_Click_1(object sender, EventArgs e)
        {
            //form bar overzicht laten zien
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TafelNummer(int Nummer)
        {
            this.tafelNummer = Nummer;
            TafelStatus(this.tafelNummer);
            TafelStatus();
        }
        //Tafel vrij of bezet markeren
        private void TafelStatus()
        {
            if (lblViewStatus.Text == "Bezet")
            {
                btnVrijBezet.Text = "Vrij";
            }
            else if (lblViewStatus.Text == "Vrij")
            {
                btnVrijBezet.Text = "Bezet";
            }
        }
        private void btnVrijBezet_Click(object sender, EventArgs e)
        {

        }

        private void TafelOverzicht_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OverzichtTijd = DateTime.Now;
            lblTijdTafelOverzicht.Text = OverzichtTijd.ToString("HH:mm  dd-MM-yyyy");
        }

        private void lblTijdTafelOverzicht_Click(object sender, EventArgs e)
        {

        }
        public void LogedInEmployee(string employeeName)
        {
            lblEmployeeName.Text = (string)employeeName;
        }
    }
}
