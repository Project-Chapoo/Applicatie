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
            timer2.Start();
            timer4.Start();
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
        private void LoadTableColors()
        {
            TablesService tablesService = new TablesService();

            for (int i = 1; i <= 10; i++)
            {
                string button = $"btnTafel{i}";
                Tables table = tablesService.IsGereserveerd(i);

                if (table.Reserved == true)
                {
                    this.Controls[button].BackColor = Color.Red;
                }
                else if (table.Reserved == false)
                {
                    this.Controls[button].BackColor = Color.Gray;
                }
            }
        }
        //Naam ingelogde gebruiker
        public void LogedInEmployee(string employeeName)
        {
            lblEmployeeName.Text = (string)employeeName;
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
                TafelVrij(orderTable);
            }
            else if(btnVrijBezet.Text == "Bezet")
            {
                TafelBezet(orderTable);
            }
            UpdateTable();
        }
        private void TafelVrij(OrderStatusTable orderTable)
        {
            TablesService tablesService = new TablesService();
            //aanpassen checken of er geen bestellingen staat
            if (TableOrderExists() == false)
            {
                tablesService.UpdateTableStatus(this.tafelNummer, 0);
            }
            else
            {
                MessageBox.Show("Deze tafel heeft nog een bestelling open staan");
            }
        }
        private void TafelBezet(OrderStatusTable orderTable)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OverzichtTijd = DateTime.Now;
            lblTijdTafelOverzicht.Text = OverzichtTijd.ToString("HH:mm:ss  dd-MM-yyyy");
        }
        
        public void OrderStatus()
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];

            TablesService tablesService = new TablesService();
            Tables table = tablesService.IsGereserveerd(this.tafelNummer);

            if (table.Reserved == true)
            {
                //aanpassen kijken of er wel een bestelling is
                if (TableOrderExists() == true)
                {
                    HidePanels();
                    lblLopendeBestelling1.Show();
                    lblWachtTijd1.Show();

                    lblLopendeBestelling2.Show();
                    lblWachtTijd2.Show();

                    lblLopendeBestelling3.Show();
                    lblWachtTijd3.Show();

                    TableOrder();

                }
                else if (orderTable.OrderReady == true)
                {
                    HidePanels();

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
                    HidePanels();
                    lblLopendeBestelling1.Show();
                    lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";
                }
            }
            else
            {
                HidePanels();
                lblLopendeBestelling1.Show();
                lblLopendeBestelling1.Text = "Er zijn geen lopende \nbestellingen voor deze tafel";
            }

        }
        private void HidePanels()
        {
            lblWachtTijd1.Hide();
            lblWachtTijd2.Hide();
            lblWachtTijd3.Hide();
            lblLopendeBestelling2.Hide();
            lblLopendeBestelling3.Hide();
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
            OrderStatus();
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
        private void TableOrder()
        {
            TableOrderService tableOrderService = new TableOrderService();
            List<TableOrder> tableOrder = tableOrderService.TableOrders(this.tafelNummer);

            List<string> orderCategory = new List<string>();
            if(TableOrderExists() == true)
            {
                foreach(TableOrder order in tableOrder)
                {
                    if(orderCategory.Contains(order.category) == false && (order.menuId == 1 | order.menuId == 2))
                    {
                        orderCategory.Add(order.category);
                    }
                    else if(orderCategory.Contains("Dranken") == false && order.menuId == 3)
                    {
                        orderCategory.Add("Dranken");
                    }
                }
            }
            LopendeBestellingen(orderCategory);

        }
        private void LopendeBestellingen(List<string> orderCategory)
        {
            OrderService orderService = new OrderService();
            List<OrderStatusTable> orderStatusTables = orderService.BestellingPerTafel(this.tafelNummer);
            OrderStatusTable orderTable = orderStatusTables[0];

            for (int i = 0; i < orderCategory.Count; i++)
            {
                string label = $"lblLopendeBestelling{(i + 1)}";
                string labelTijd = $"lblWachtTijd{(i + 1)}";

                if (i < 4)
                {
                    pnlLopendeBestellingen.Controls[label].Text = $"{orderCategory[i]}";
                    pnlLopendeBestellingen.Controls[labelTijd].Text = (DateTime.Now - orderTable.TimeOrdered).ToString(@"hh\:mm\:ss");
                }
                else
                {
                    pnlLopendeBestellingen.Controls[label].Hide();
                    pnlLopendeBestellingen.Controls[labelTijd].Hide();
                }
            }
        }
        private void GereedBestelling()
        {

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            Meldingen();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lblTijdTafelOverzicht_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //LoadTableColors();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
