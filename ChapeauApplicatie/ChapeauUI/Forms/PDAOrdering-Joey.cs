using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModels;
using ChapeauService;
using ChapeauDAL;


namespace ChapeauUI
{
    public partial class PDAOrdering_Joey : Form
    {
        private int tableID = 0;

        private List<OrderItems> OrderedItems = new List<OrderItems>();

        public void addToOrder(OrderItems orderedItems)
        {
            OrderedItems.Add(orderedItems);
        }

        void HidePanels()
        {
            pnlOrderOrPayment.Hide();
            pnlLunch.Hide();
            pnlDiner.Hide();
            pnlDranken.Hide();
            pnlLunchHoofdgerechten.Hide();
            pnlLunchNagerechten.Hide();
            pnlLunchVoorgerechten.Hide();
            pnlOpmerkingen.Hide();
            pnlOrderOrPayment.Hide();
            pnlOrderReview.Hide();
            pnlTableSelection.Hide();
            pnlCourseChoosing.Hide();
            pnlConfirmOrder.Hide();
            pnlDinerTussengerechten.Hide();
            pnlDinerHoofdgerechten.Hide();
            pnlDinerNagerechten.Hide();
        }





        public PDAOrdering_Joey()
        {
            InitializeComponent();
        }

        private void PDAOrdering_Joey_Load(object sender, EventArgs e)
        {
            showPanel("TableSelection");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "TableSelection")
            {
                //hide other panels
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlCourseChoosing.Hide();
                pnlOrderReview.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();


                // show tableSelection
                pnlTableSelection.Show();
            }
            else if (panelName == "pnlOrderOrPayment")
            {
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Show();
                pnlCourseChoosing.Hide();
                pnlTableSelection.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "CourseChoosing")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Show();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "Lunch")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Show();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "Diner")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Show();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "Dranken")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Show();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();


            }
            else if (panelName == "Opmerkingen")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Show();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "LunchVoorgerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Show();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "LunchHoofdgerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Show();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "LunchNagerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Show();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if ((panelName == "ConfirmOrder"))
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Show();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();

            }
            else if (panelName == "btnDinervoorgerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerVoorgerechten.Show();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();
            }
            else if (panelName == "DinerTussengerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Show();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Hide();
            }
            else if (panelName == "DinerHoofdgerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Show();
                pnlDinerNagerechten.Hide();
            }
            else if (panelName == "DinerNagerechten")
            {
                pnlOrderOrPayment.Hide();
                pnlLunch.Hide();
                pnlDiner.Hide();
                pnlDranken.Hide();
                pnlLunchHoofdgerechten.Hide();
                pnlLunchNagerechten.Hide();
                pnlLunchVoorgerechten.Hide();
                pnlOpmerkingen.Hide();
                pnlOrderOrPayment.Hide();
                pnlOrderReview.Hide();
                pnlTableSelection.Hide();
                pnlCourseChoosing.Hide();
                pnlConfirmOrder.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerVoorgerechten.Hide();
                pnlDinerTussengerechten.Hide();
                pnlDinerHoofdgerechten.Hide();
                pnlDinerNagerechten.Show();

            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnHertenstoofpot_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnKabeljauw_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnLinguini_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //if tijd != 14:00 - 17:00 messagebox.show("Je kan geen lunch meer bestellen, dit kan alleen tussen 14:00 en 17:00");
            //else
            showPanel("Lunch");
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            showPanel("Diner");
        }

        private void btnDranken_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnOpmerkingen_Click(object sender, EventArgs e)
        {
            showPanel("Opmerkingen");
        }

        private void btnLunchVoorgerechten_Click(object sender, EventArgs e)
        {
            showPanel("LunchVoorgerechten");
        }

        private void btnLunchHoofdgerechten_Click(object sender, EventArgs e)
        {
            showPanel("LunchHoofdgerechten");
        }

        private void btnLunchNagerechten_Click(object sender, EventArgs e)
        {
            showPanel("LunchNagerechten");
        }

        private void btnBackToLunch_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnGoBackToOrderOrPayment_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
        }

        private void btnGoBackToTableSelection_Click(object sender, EventArgs e)
        {
            showPanel("TableSelection");
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 2;
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 3;
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 4;
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 5;
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 6;
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 7;
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 8;
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 9;
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 10;
        }

        private void btnGoBackToCourseChoosingFromConfirmOrder_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnLunchSteakTartaar_Click(object sender, EventArgs e)
        {            
            OrderItemsService orderItemsService = new OrderItemsService();
            orderItemsService.LunchSteak(tableID);
           /* MenuItemService menuItemService = new MenuItemService();
            menuItemService.LunchSteak();*/
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnLunchPatéFazant_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnLunchVissoep_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showPanel("ConfirmOrder");
            lstViewOrderedItems();
        }

        private void btnTaart_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            MessageBox.Show("Taart is toegevoegd aan bestelling");
            //add to order
        }

        private void btnMadeleine_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Madeleine is toegevoegd aan bestelling");

            showPanel("CourseChoosing");

            //add to order
        }

        private void btnBoerenKaas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boerenkaas is toegevoegd aan bestelling");
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnGoBackToCourseChoosingFromDinerSelection_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnDinerVoorgerechten_Click(object sender, EventArgs e)
        {
            showPanel("btnDinervoorgerechten");
        }

        private void btnTussengerechten_Click(object sender, EventArgs e)
        {
            showPanel("DinerTussengerechten");
        }

        private void btnDinerHoofdgerechten_Click(object sender, EventArgs e)
        {
            showPanel("DinerHoofdgerechten");
            //add to order
        }

        private void btnDinerNagerechten_Click(object sender, EventArgs e)
        {
            showPanel("DinerNagerechten");
            //add to order
        }

        private void btnDinerKalfstartaar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tartaar is toegevoegd aan bestelling");
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerFazant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fazant is toegevoegd aan bestelling");
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerKrabZalmKoekjes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Krab-zalm koekjes zijn toegevoegd aan bestelling");
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerTussengerechtVissoep_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerTussengerechtConsomméFazant_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerHoofdgerechtKabeljauw_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerHoofdgerechtenOssenhaas_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerHoofdgerechtenHertenbiefstuk_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerNagerechtenCaféSurprise_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerNagerechtenCherryBaby_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnDinerNagerechtenFromage_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
            //add to order
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order is verstuurd naar de keuken/Bar");

            showPanel("TableSelection");
            int IDtable = tableID;

            OrderService orderService = new OrderService();
            orderService.ConfirmOrder(IDtable);

            //OrderItemsService orderItemsService = new OrderItemsService();
            //orderItemsService.LunchSteak();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {                
                int selectedOrderItemID = int.Parse(lstviewOrder.SelectedItems[0].SubItems[3].Text);
                OrderItemsService orderItemsService = new OrderItemsService();
                orderItemsService.AddItem(selectedOrderItemID);
                lstViewOrderedItems();
            }
            catch (Exception)
            {
                if (lstviewOrder.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteer eerst een gerecht wat u wilt toevoegen");
                }
            }
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {                
                int selectedItem = int.Parse(lstviewOrder.SelectedItems[0].SubItems[3].Text);
                OrderItemsService orderItemsService = new OrderItemsService();
                orderItemsService.RemoveItem(selectedItem);
                lstViewOrderedItems();
            }
            catch (Exception)
            {
                if (lstviewOrder.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteer eerst een gerecht wat u wilt verminderen");
                };
            }            
        }

        private void lstViewOrderedItems()
        {
            OrderItemsService orderItemsService = new OrderItemsService();
            List<OrderItems> orderItemsList = orderItemsService.GetOrderItemsPerTable(tableID);
            lstviewOrder.Items.Clear();
            lstviewOrder.View = View.Details;
            foreach (OrderItems orderItem in orderItemsList)
            {
                ListViewItem li = new ListViewItem(orderItem.TableID.ToString());
                li.SubItems.Add(orderItem.quantity.ToString());
                li.SubItems.Add(orderItem.description.ToString());
                li.SubItems.Add(orderItem.OrderItemID.ToString());                
                lstviewOrder.Items.Add(li);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {           
            OrderItemsService orderItemsService = new OrderItemsService();
            
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je de gehele bestelling wilt verwijderen?",MessageBoxButtons.YesNo.ToString());
            if (dialogResult == DialogResult.Yes)
            {
                orderItemsService.VerwijderOrder(tableID);
            }
            else if (dialogResult == DialogResult.No)
            {
                showPanel("ConfirmOrder");           
            }
            lstViewOrderedItems();           
        }

        private void btnVerwijderItem_Click(object sender, EventArgs e)
        {
            string message = "Weet je zeker dat je dit item wilt verwijderen?";
            string title = "Item verwijderen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedOrderItemID = int.Parse(lstviewOrder.SelectedItems[0].SubItems[3].Text);
                    OrderItemsService orderItemsService = new OrderItemsService();
                    orderItemsService.VerwijderItem(selectedOrderItemID);
                    lstViewOrderedItems();
                }
                catch (Exception)
                {
                    if (lstviewOrder.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Selecteer eerst een gerecht wat u wilt verwijderen");
                    };                    
                }
            }
            else
            {
                showPanel("ConfirmOrder");  
            }

            
           
            }
        }
    }





       
    
    