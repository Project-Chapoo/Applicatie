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
        private EmployeeModel employee;

        public TafelOverzicht()
        {
            InitializeComponent();
        }
        private void TafelOverzicht_Load(object sender, EventArgs e)
        {
            timerTijd.Start();
            timerUpdate.Start();
            Meldingen();
            HidePanels();
            LoadTableColors();
            Function();
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
            LoadTableColors();
            Meldingen();
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {   
            Meldingen();
        }
        private void LoadTableColors()
        {
            TableOrderService tableOrderService = new TableOrderService();
            
            for (int i = 1; i <= 10; i++)
            {
                List<TableOrder> tableOrder = tableOrderService.TableOrders(i);

                string button = $"btnTafel{i}";

                if (tableOrder.Count == 0)
                {
                    this.Controls[button].BackColor = Color.Gray;
                }
                else if(tableOrder.Count > 0)
                {
                    this.Controls[button].BackColor = Color.Red;
                }
            }
        }
        //Naam ingelogde gebruiker weergeven
        public void LogedInEmployee(EmployeeModel employee)
        {
            this.employee = employee;
            lblEmployeeName.Text = employee.firstName;
        }
        private void Function()
        {
            if(employee.employeeFunction == "Bediening")
            {
                btnKeukenOverzicht.Enabled = false;
                btnBarOverzicht.Enabled = false;
            }
            else
            {
                btnKeukenOverzicht.Enabled = true;
                btnBarOverzicht.Enabled = true;
            }
        }
        //Uitloggen
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
            KeukenFrm2 keukenForm = new KeukenFrm2(employee.firstName);
            this.Hide();
            keukenForm.Closed += (s, args) => this.Close();
            keukenForm.Show();
        }
        private void btnBarOverzicht_Click_1(object sender, EventArgs e)
        {
            BarFrm barForm = new BarFrm(employee.firstName);
            this.Hide();
            barForm.Closed += (s, args) => this.Close();
            barForm.Show();
        }
        
        //Tafel vrij of bezet markeren
        private void ButtonTafelStatus()
        {
            //veranderd tekst in knop
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
                TafelVrij();
            }
            else if(btnVrijBezet.Text == "Bezet")
            {
                TafelBezet();
            }
            UpdateTable();
        }
        private void TafelVrij()
        {
            TablesService tablesService = new TablesService();
            //Kijken of er geen bestellingen staat
            if (TableOrderExists() == false)
            {
                tablesService.UpdateTableStatus(this.tafelNummer, 0);
            }
            else
            {
                MessageBox.Show("Deze tafel heeft nog een bestelling open staan");
            }
        }
        private void TafelBezet()
        {
            TablesService tablesService = new TablesService();
            tablesService.UpdateTableStatus(this.tafelNummer, 1);
        }
        private void TafelStatus()
        {
            TablesService tablesService = new TablesService();
            Tables table = tablesService.IsGereserveerd(this.tafelNummer);

            string button = $"btnTafel{this.tafelNummer}";

            if (table.Reserved == true)
            {
                lblViewStatus.Text = "Bezet";
                this.Controls[button].BackColor = Color.Red;
            }
            else
            {
                lblViewStatus.Text = "Vrij";
                this.Controls[button].BackColor = Color.Gray;
            }
        }
        //Tijd
        private void timerTijd_Tick(object sender, EventArgs e)
        {
            DateTime OverzichtTijd = DateTime.Now;
            lblTijdTafelOverzicht.Text = OverzichtTijd.ToString("HH:mm:ss  dd-MM-yyyy");
        }
        private void HidePanels()
        {
            lblWachtTijd1.Hide();
            lblWachtTijd2.Hide();
            lblWachtTijd3.Hide();
            lblWachtTijd4.Hide();
            lblLopendeBestelling2.Hide();
            lblLopendeBestelling3.Hide();
            lblLopendeBestelling4.Hide();
            cbServeren1.Hide();
            cbServeren2.Hide();
            btnGeserveerd.Hide();
        }
        public void Meldingen()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.OrderGereed();

            List<int> gereed = new List<int>();
            foreach(OrderStatusTable table in orderStatusTables)
            {
                if (table.orderReady == true && table.orderServed == false)
                {
                    gereed.Add(table.tableId);
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
                    pnlMeldingen.Controls[label].Text = $"Bestelling tafel {gereed[i]} gereed";
                }
                else
                {
                    pnlMeldingen.Controls[label].Hide();
                }
            }
        }
        private bool TableOrderExists()
        {
            TableOrderService tableOrderService = new TableOrderService();
            List<TableOrder> tableOrder = tableOrderService.TableOrders(this.tafelNummer);
            if(tableOrder.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Order statussen van tafels bepalen
        private void OrderStatus()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];

            TablesService tablesService = new TablesService();
            Tables table = tablesService.IsGereserveerd(this.tafelNummer);
            HidePanels();

            if (table.Reserved == true)
            {
                //Kijken of er een bestelling is
                if (TableOrderExists() == true)
                {
                    LopendeBestellingen();
                }
                if (orderTable.orderReady == true)
                {
                    GereedBestelling();
                }
            }
            else
            {
                lblLopendeBestelling1.Show();
                lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";
            }
        }
        //Lopende bestellingen
        private void LopendeBestellingen()
        {
            TableOrderService tableOrderService = new TableOrderService();
            List<TableOrder> tableOrder = tableOrderService.TableOrders(this.tafelNummer);

            List<string> orderCategory = new List<string>();
            foreach (TableOrder order in tableOrder)
            {
                if (order.readyOrderItem == false)
                {
                    if (orderCategory.Contains(order.category) == false && (order.menuId == 1 | order.menuId == 2))
                    {
                        orderCategory.Add(order.category);
                    }
                    else if (orderCategory.Contains("Dranken") == false && order.menuId == 3)
                    {
                        orderCategory.Add("Dranken");
                    }
                }
                else
                {
                    lblLopendeBestelling1.Show();
                    lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";
                }
            }
            LopendeBestellingenWeergeven(orderCategory);
        }
        private void LopendeBestellingenWeergeven(List<string> orderCategory)
        {
            //Tijd ophalen van de lopende bestelling
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];
            HidePanels();

            for (int i = 0; i < orderCategory.Count; i++)
            {
                string label = $"lblLopendeBestelling{(i + 1)}";
                string labelTijd = $"lblWachtTijd{(i + 1)}";

                if (i < 4)
                {
                    pnlLopendeBestellingen.Controls[label].Show();
                    pnlLopendeBestellingen.Controls[labelTijd].Show();
                    pnlLopendeBestellingen.Controls[label].Text = $"{orderCategory[i]}";
                    pnlLopendeBestellingen.Controls[labelTijd].Text = (DateTime.Now - orderTable.timeOrdered).ToString(@"hh\:mm\:ss");
                }
            }
        }
        //Bestellingen klaar voor serveren
        public void btnGeserveerd_Click(object sender, EventArgs e)
        {
            GereedBestelling();
            OrderStatus();
            Meldingen();
        }
        private void GereedBestelling()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable order = orderStatusTables[0];

            List<string> nogServeren = new List<string>();
            if (order.orderReady == true)
            {
                if (order.kitchenServed == false)
                {
                    nogServeren.Add("Keuken");
                }
                if (order.barServed == false)
                {
                    nogServeren.Add("Bar");
                }
                Geserveerd(nogServeren);
            }
        }
        private void Geserveerd(List<string> nogServeren)
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable order = orderStatusTables[0];

            if (cbServeren1.Checked && cbServeren1.Text == "Keuken")
            {
                orderService.UpdateKitchenServed(1, this.tafelNummer);
                nogServeren.Remove("Keuken");
            }
            if(cbServeren1.Checked && cbServeren1.Text == "Bar")
            {
                orderService.UpdateBarServed(1, this.tafelNummer);
                nogServeren.Remove("Bar");
            }
            if(cbServeren2.Checked)
            {
                orderService.UpdateBarServed(1, this.tafelNummer);
                nogServeren.Remove("Bar");
            }

            if(order.barServed == true && order.kitchenServed == true)
            {
                orderService.UpdateOrderServed(1, this.tafelNummer);
                orderService.UpdateOrderReady(0, this.tafelNummer);
                orderService.UpdateBarServed(0, this.tafelNummer);
                orderService.UpdateKitchenServed(0, this.tafelNummer);
                cbServeren1.Checked = false;
                cbServeren2.Checked = false;
            }
            NogServeren(nogServeren);
        }
        private void NogServeren(List<string> nogServeren)
        {
            HidePanels();
            btnGeserveerd.Show();

            for (int i = 0; i < nogServeren.Count; i++)
            {
                string checkBox = $"cbServeren{(i + 1)}";
                if (i < 3)
                {
                    pnlKlaarVoorServeren.Controls[checkBox].Show();
                    pnlKlaarVoorServeren.Controls[checkBox].Text = $"{nogServeren[i]}";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lblTijdTafelOverzicht_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
