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
        private void TafelOverzicht_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Meldingen();
            LoadTableColors(); 
        }
        private void TafelNummer(int Nummer)
        {
            pnlLeeg.Hide();
            this.tafelNummer = Nummer;
            lblTafelInfo.Text = $"Tafel {Nummer}".ToString();
            UpdateTable();
        }
        private void UpdateTable()
        {
            TafelStatus();
            ButtonTafelStatus();
            OrderStatus();
        }
        private void TafelStatus()
        {
            TablesService tablesService = new TablesService();
            Tables table = tablesService.IsReserved(this.tafelNummer);
            
            string button = $"btnTafel{this.tafelNummer}";

            if (table.Reserved == true)
            {
                lblViewStatus.Text = "Bezet";
                this.Controls[button].BackColor = Color.Red;
            }
            else
            {
                lblViewStatus.Text = "Vrij";
                this.Controls[button].BackColor = Color.LightGray;
            }    
        }
        private void LoadTableColors()
        {
            TablesService tablesService = new TablesService();

            for(int i = 1; i <= 10; i++)
            {
                string button = $"btnTafel{i}";
                Tables table = tablesService.IsReserved(i);

                if (table.Reserved == true)
                {
                    this.Controls[button].BackColor = Color.Red;
                }
                else
                {
                    this.Controls[button].BackColor = Color.LightGray;
                }
            } 
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
        //Tafel vrij of bezet markeren
        private void ButtonTafelStatus()
        {
            if (lblViewStatus.Text == "Bezet")
            {
                btnVrijBezet.Text = "Vrij";
                
            }
            else 
            {
                btnVrijBezet.Text = "Bezet";
            }
        }
        private void btnVrijBezet_Click(object sender, EventArgs e)
        { 
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];

            if (btnVrijBezet.Text == "Vrij")
            {
                TafelVrij(orderTable);
            }
            else if(btnVrijBezet.Text == "Bezet")
            {
                TafelBezet(orderTable);
            }
            //UpdateTable();
        }
        private void TafelVrij(OrderStatusTable orderTable)
        {
            TablesService tablesService = new TablesService();
            if (orderTable.OrderReady == false | orderTable.OrderServed == false)
            {
                tablesService.UpdateTableStatus(this.tafelNummer, 0);
            }
        }
        private void TafelBezet(OrderStatusTable orderTable)
        {
            TablesService tablesService = new TablesService();
            tablesService.UpdateTableStatus(this.tafelNummer, 1);
        }
        //Tijd
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OverzichtTijd = DateTime.Now;
            lblTijdTafelOverzicht.Text = OverzichtTijd.ToString("HH:mm  dd-MM-yyyy");
        }
        //Naam ingelogde gebruiker
        public void LogedInEmployee(string employeeName)
        {
            lblEmployeeName.Text = (string)employeeName;
        }
        public void OrderStatus()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];

            if(orderTable.OrderReady == false && orderTable.OrderServed == false)
            {
                lblLopendeBestelling1.Show();
                lblWachtTijd1.Show();
                lblLopendeBestelling1.Text = "Keuken";
                lblWachtTijd1.Text = (DateTime.Now - orderTable.TimeOrdered).ToString(@"hh\:mm\:ss");

                lblLopendeBestelling2.Show();
                lblWachtTijd2.Show();
                lblLopendeBestelling2.Text = "Bar";
                lblWachtTijd2.Text = (DateTime.Now - orderTable.TimeOrdered).ToString(@"hh\:mm\:ss");

                cbServeren1.Hide();
                cbServeren2.Hide();
                btnGeserveerd.Hide(); 
            }
            else if(orderTable.OrderReady == true && orderTable.OrderServed == false)
            {
                lblWachtTijd1.Hide();
                lblLopendeBestelling2.Hide();
                lblWachtTijd2.Hide();

                cbServeren1.Show();
                cbServeren2.Show();
                btnGeserveerd.Show();
                lblLopendeBestelling1.Show();
                lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";

                cbServeren1.Text = "Keuken";
                cbServeren2.Text = "Bar";
            }
            else
            {
                lblLopendeBestelling1.Show();
                lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";
                lblWachtTijd1.Hide();
                lblWachtTijd2.Hide();
                lblLopendeBestelling2.Hide();
                cbServeren1.Hide();
                cbServeren2.Hide();
                btnGeserveerd.Hide();
            }
        }
        public void Meldingen()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.OrderGereed();

            List<int> gereed = new List<int>();
            foreach(OrderStatusTable table in orderStatusTables)
            {
                if (table.OrderReady == true && table.OrderServed == false)
                {
                    gereed.Add(table.TableId);
                }
            }
            MeldingenWeergeven(gereed);
        }
        private void MeldingenWeergeven(List<int> gereed)
        {
            for (int i = 0; i < gereed.Count; i++)
            {
                string label = $"lblMelding{(i + 1)}";

                if (i < 4)
                {
                    pnlMeldingen.Controls[label].Text = $"Bestelling tafel {gereed[i]} is gereed";
                }
                else
                {
                    pnlMeldingen.Controls[label].Hide();
                }
            }
        }
        public void btnGeserveerd_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            orderService.UpdateOrderServed(1, this.tafelNummer);
            orderService.UpdateOrderReady(0, this.tafelNummer);
            Meldingen();
            OrderStatus();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lblTijdTafelOverzicht_Click(object sender, EventArgs e)
        {

        }
    }
}
