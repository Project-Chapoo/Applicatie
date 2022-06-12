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
            timerTijd.Start();
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
                    KeukenOverzicht(employee.firstName);
                    break;
                case "Barmedewerker":
                    BarOverzicht(employee.firstName);
                    break;
                case "Eigenaar":
                    TafelOverzicht(employee);
                    break;
            }
        }
        private void TafelOverzicht(EmployeeModel employee)
        {
            TafelOverzicht tafelOverzicht = new TafelOverzicht();
            tafelOverzicht.LogedInEmployee(employee);
            this.Hide();
            tafelOverzicht.Closed += (s, args) => this.Close();
            tafelOverzicht.Show();
        }
        private void BarOverzicht(string employeeFirstName)
        {
            BarFrm barForm = new BarFrm(employeeFirstName);
            this.Hide();
            barForm.Closed += (s, args) => this.Close();
            barForm.Show();
        }
        private void KeukenOverzicht(string EmployeeFirstName)
        {
            KeukenFrm2 keukenForm = new KeukenFrm2(EmployeeFirstName);
            this.Hide();
            keukenForm.Closed += (s, args) => this.Close();
            keukenForm.Show();
        }
        private void PDA()
        {
            BedieningFrm bedieningForm = new BedieningFrm();
            this.Hide();
            bedieningForm.Closed += (s, args) => this.Close();
            bedieningForm.Show();
        }
        private void btnKassa1_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa1.Text));
        }
        private void btnKassa2_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa2.Text));
        }
        private void btnKassa3_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa3.Text));
        }
        private void btnKassa4_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa4.Text));
        }
        private void btnKassa5_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa5.Text));
        }
        private void btnKassa6_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa6.Text));
        }
        private void btnKassa7_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa7.Text));
        }
        private void btnKassa8_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa8.Text));
        }
        private void btnKassa9_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa9.Text));
        }
        private void btnKassa0_Click(object sender, EventArgs e)
        {
            Password(int.Parse(btnKassa0.Text));
        }
        private void btnKassaBack_Click(object sender, EventArgs e)
        {
            //delete laatst ingetoetste nummer
            if(txtKassaLogIn.TextLength > 0)
                txtKassaLogIn.Text = txtKassaLogIn.Text.Substring(0, txtKassaLogIn.TextLength - 1);
        }
        //count voor het heen en weer klikken
        private int count = 0;
        private void llblHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (count % 2 != 0)
                txtKassaLogIn.UseSystemPasswordChar = true;
            else
                txtKassaLogIn.UseSystemPasswordChar = false;
            count++;
        }
        private void Password(int number)
        {
            if (txtKassaLogIn.TextLength < 4)
                txtKassaLogIn.Text += number;
        }
        //Timer
        private void timerTijd_Tick(object sender, EventArgs e)
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
