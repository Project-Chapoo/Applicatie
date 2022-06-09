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
    public partial class KassaLogin : Form
    {
        public KassaLogin()
        {
            InitializeComponent();
            txtKassaLogIn.UseSystemPasswordChar = true;
        }
        private void KassaLogin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void btnKassaEnter_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            string loginPassword = txtKassaLogIn.Text;

            if(loginPassword.Length < 4)
            {
                WrongPassword();
            }
            else if(loginPassword.Length == 4)
            {
                EmployeeModel employee = employeeService.CheckEmployeeLogIn(loginPassword);
                CheckPassword(employee);
            }
        }
        private void CheckPassword(EmployeeModel employee)
        {
            if (employee == null)
            {
                WrongPassword();
            }
            else
            {
                CheckEmployeeFunction(employee);
                //weg halen?
                MessageBox.Show($"Welkom {employee.firstName}");
                
            }
        }
        private void WrongPassword()
        {
            MessageBox.Show($"Verkeerd wachtwoord, probeer het opnieuw!");
            txtKassaLogIn.Clear();
        }
        private void CheckEmployeeFunction(EmployeeModel employee)
        {
            switch(employee.employeeFunction)
            {
                case "Bediening":
                    PDA();
                    break;
                case "Kok":
                    KeukenOverzicht();
                    break;
                case "Barmedewerker":
                    BarOverzicht();
                    break;
                case "Eigenaar":
                    TafelOverzicht(employee);
                    break;
            }
        }
        private void TafelOverzicht(EmployeeModel employee)
        {
            TafelOverzicht tafelOverzicht = new TafelOverzicht();
            tafelOverzicht.LogedInEmployee(employee.firstName);
            this.Hide();
            tafelOverzicht.Closed += (s, args) => this.Close();
            tafelOverzicht.Show();
        }
        private void BarOverzicht()
        {
            //mist nog
        }
        private void KeukenOverzicht()
        {
            KeukenFrm keukenForm = new KeukenFrm();
            this.Hide();
            keukenForm.Closed += (s, args) => this.Close();
            keukenForm.Show();
        }
        private void PDA()
        {
            PDAOrdering_Joey pda = new PDAOrdering_Joey();
            this.Hide();
            pda.Closed += (s, args) => this.Close();
            pda.Show();
        }
        private void btnKassa1_Click(object sender, EventArgs e)
        {
            if(txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 1;
        }
        private void btnKassa2_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 2;
        }
        private void btnKassa3_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 3;
        }
        private void btnKassa4_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 4;
        }
        private void btnKassa5_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 5;
        }
        private void btnKassa6_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 6;
        }
        private void btnKassa7_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 7;
        }
        private void btnKassa8_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 8;
        }
        private void btnKassa9_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 9;
        }
        private void btnKassa0_Click(object sender, EventArgs e)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += 0;
        }
        private void btnKassaBack_Click(object sender, EventArgs e)
        {
            //delete laatst ingetoetste nummer
            if(txtKassaLogIn.TextLength > 0)
                txtKassaLogIn.Text = txtKassaLogIn.Text.Substring(0, txtKassaLogIn.TextLength - 1);
        }
        
        //count voor het heen en weer klikken
        private int count = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (count % 2 != 0)
                txtKassaLogIn.UseSystemPasswordChar = true;
            else
                txtKassaLogIn.UseSystemPasswordChar = false;
            count++;
        }
        //Timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime OverzichtTijd = DateTime.Now;
            lblTime.Text = OverzichtTijd.ToString("HH:mm:ss  dd-MM-yyyy");
            
        }


        private void panelTafelOverzicht_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKassaLogIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
