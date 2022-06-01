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
        private string commentaar;
        private DateTime tijd = DateTime.Now;
        private int menuItemID;


        public PDAOrdering_Joey()
        {
            InitializeComponent();
        }

        private void HideAllPanels()
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
            pnlCourseChoosing.Hide();
            pnlOrderReview.Hide();
            pnlConfirmOrder.Hide();
            pnlDinerVoorgerechten.Hide();
            pnlDinerTussengerechten.Hide();
            pnlDinerHoofdgerechten.Hide();
            pnlDinerNagerechten.Hide();
            pnlGedestilleerdeDranken.Hide();
            pnlFrisdranken.Hide();
            pnlKoffieThee.Hide();
            pnlBieren.Hide();
            pnlWijnen.Hide();
        }

        private void OrderItem()
        {
            OrderItemsService orderItemsService = new OrderItemsService();
            orderItemsService.AddOrderItem(tableID, menuItemID);
        }


        private void PDAOrdering_Joey_Load(object sender, EventArgs e)
        {
            showPanel("TableSelection");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "TableSelection")
            {
                HideAllPanels();                
                pnlTableSelection.Show();
            }
            else if (panelName == "pnlOrderOrPayment")
            {
                HideAllPanels();
                pnlOrderOrPayment.Show();
            }
            else if (panelName == "CourseChoosing")
            {
                HideAllPanels();
                pnlCourseChoosing.Show();
            }
            else if (panelName == "Lunch")
            {
                HideAllPanels();
                pnlLunch.Show();
            }
            else if (panelName == "Diner")
            {
                HideAllPanels();
                pnlDiner.Show();
            }
            else if (panelName == "Dranken")
            {
                HideAllPanels();
                pnlDranken.Show();
            }
            else if (panelName == "Opmerkingen")
            {
                HideAllPanels();
                pnlOpmerkingen.Show();
            }
            else if (panelName == "LunchVoorgerechten")
            {
                HideAllPanels();
                pnlLunchVoorgerechten.Show();
            }
            else if (panelName == "LunchHoofdgerechten")
            {
                HideAllPanels();
                pnlLunchHoofdgerechten.Show();
            }
            else if (panelName == "LunchNagerechten")
            {
                HideAllPanels();
                pnlLunchNagerechten.Show();
            }
            else if ((panelName == "ConfirmOrder"))
            {
                HideAllPanels();
                pnlConfirmOrder.Show();
            }
            else if (panelName == "btnDinervoorgerechten")
            {
                HideAllPanels();
                pnlDinerVoorgerechten.Show();
            }
            else if (panelName == "DinerTussengerechten")
            {
                HideAllPanels();
                pnlDinerTussengerechten.Show();
            }
            else if (panelName == "DinerHoofdgerechten")
            {
                HideAllPanels();
                pnlDinerHoofdgerechten.Show();
            }
            else if (panelName == "DinerNagerechten")
            {
                HideAllPanels();
                pnlDinerNagerechten.Show();
            }
            else if (panelName == "Frisdranken")
            {
                HideAllPanels();
                pnlFrisdranken.Show();
            }
            else if (panelName == "Bieren")
            {
                HideAllPanels();
                pnlBieren.Show();
            }
            else if (panelName == "Wijnen")
            {
                HideAllPanels();
                pnlWijnen.Show();
            }
            else if (panelName == "GedestilleerdeDranken")
            {
                HideAllPanels();
                pnlGedestilleerdeDranken.Show();
            }
            else if (panelName == "KoffieThee")
            {
                HideAllPanels();
                pnlKoffieThee.Show();
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = 1;
            
        }
        
        private void btnOrdering_Click(object sender, EventArgs e)
        {
            // if methode == null
            //maak nieuwe order
            
            showPanel("CourseChoosing");
        }

        private void btnHertenstoofpot_Click(object sender, EventArgs e)
        {
            menuItemID = 4;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnKabeljauw_Click(object sender, EventArgs e)
        {
            menuItemID = 5;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnLinguini_Click(object sender, EventArgs e)
        {
            menuItemID = 6;
            OrderItem();
            showPanel("Lunch");
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
            menuItemID = 1;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnLunchPatéFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 2;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnLunchVissoep_Click(object sender, EventArgs e)
        {
            menuItemID = 3;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showPanel("ConfirmOrder");
            lstViewOrderedItems();
        }

        private void btnTaart_Click(object sender, EventArgs e)
        {
            menuItemID = 7;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnMadeleine_Click(object sender, EventArgs e)
        {
            menuItemID = 8;
            OrderItem();
            showPanel("Lunch");
        }

        private void btnBoerenKaas_Click(object sender, EventArgs e)
        {
            menuItemID = 9;
            OrderItem();
            showPanel("Lunch");
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
            menuItemID = 10;
            OrderItem();
            showPanel("Diner");
        }

        private void btnDinerFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 11;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerKrabZalmKoekjes_Click(object sender, EventArgs e)
        {
            menuItemID = 12;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerTussengerechtVissoep_Click(object sender, EventArgs e)
        {
            menuItemID = 13;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerTussengerechtConsomméFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 14;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerHoofdgerechtKabeljauw_Click(object sender, EventArgs e)
        {
            menuItemID = 15;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerHoofdgerechtenHertenbiefstuk_Click(object sender, EventArgs e)
        {
            menuItemID = 17;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerNagerechtenCaféSurprise_Click(object sender, EventArgs e)
        {
            menuItemID = 18;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerNagerechtenCherryBaby_Click(object sender, EventArgs e)
        {
            menuItemID = 19;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnDinerNagerechtenFromage_Click(object sender, EventArgs e)
        {
            menuItemID = 20;
            OrderItem();
            showPanel("Diner");
            //add to order
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order is verstuurd naar de keuken/Bar");

            

            showPanel("TableSelection");
            int IDtable = tableID;

            OrderService orderService = new OrderService();
            orderService.ConfirmOrder(IDtable, commentaar);

            txtBoxOpmerking.Text = "";
            commentaar = "";
            lblGemaakteOpmerkingen.Text = "Er is nog geen commentaar";

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
                li.SubItems.Add(orderItem.Quantity.ToString());
                li.SubItems.Add(orderItem.Description.ToString());
                li.SubItems.Add(orderItem.OrderItemID.ToString());                
                lstviewOrder.Items.Add(li);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {           
            OrderItemsService orderItemsService = new OrderItemsService();


            string message = "Weet je zeker dat je de gehele bestelling wilt verwijderen?";
            string title = "Bestelling verwijderen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                orderItemsService.VerwijderOrder(tableID);
            }
            else
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

        private void BtnBackToLunch_Click_1(object sender, EventArgs e)
        {
            showPanel("Lunch");
        }

        private void btnBackToLunchFromNagerechten_Click(object sender, EventArgs e)
        {
            showPanel("Lunch");
        }

        private void btnBackToLunchFromVoorgerechten_Click(object sender, EventArgs e)
        {
            showPanel("Lunch");
        }

        private void btnGoBackToDinerCourseChoosingFromVoorgerechten_Click(object sender, EventArgs e)
        {
            showPanel("Diner");
        }

        private void btnGoBackToDinerCourses_Click(object sender, EventArgs e)
        {
            showPanel("Diner");
        }

        private void btnGoBackToDinerCoursesFromDinerHoofdgerechten_Click(object sender, EventArgs e)
        {
            showPanel("Diner");
        }

        private void btnDinerHoofdgerechtenOssenhaas_Click_1(object sender, EventArgs e)
        {
            menuItemID = 16;
            OrderItem();
            showPanel("Diner");
        }

        private void btnGoBackToDinerCoursesFromNagerechten_Click(object sender, EventArgs e)
        {
            showPanel("Diner");
        }

        private void btnFrisdranken_Click(object sender, EventArgs e)
        {
            showPanel("Frisdranken");
        }

        private void btnBieren_Click(object sender, EventArgs e)
        {
            showPanel("Bieren");
        }

        private void btnWijnen_Click(object sender, EventArgs e)
        {
            showPanel("Wijnen");
        }

        private void btnGedestilleerdeDranken_Click(object sender, EventArgs e)
        {
            showPanel("GedestilleerdeDranken");
        }

        private void btnKoffieThee_Click(object sender, EventArgs e)
        {
            showPanel("KoffieThee");
        }

        private void btnBackToCourseChoosingFromDrinks_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnSpaRood_Click(object sender, EventArgs e)
        {
            menuItemID = 21;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnSpaGroen_Click(object sender, EventArgs e)
        {
            menuItemID = 22;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            menuItemID = 24;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnColaLight_Click(object sender, EventArgs e)
        {
            menuItemID = 23;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnSisi_Click(object sender, EventArgs e)
        {
            menuItemID = 25;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnTonic_Click(object sender, EventArgs e)
        {
            menuItemID = 26;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBitterLemon_Click(object sender, EventArgs e)
        {
            menuItemID = 27;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBackToDrinksFromFrisdranken_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }    

        private void btnGoBackFromKoffieThee_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnKoffie_Click(object sender, EventArgs e)
        {
            menuItemID = 42;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnCappuchino_Click(object sender, EventArgs e)
        {
            menuItemID = 43;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            menuItemID = 44;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnThee_Click(object sender, EventArgs e)
        {
            menuItemID = 45;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBackFromGedestilleerdeDranken_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnJongeJenever_Click(object sender, EventArgs e)
        {
            menuItemID = 37;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            menuItemID = 38;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            menuItemID = 39;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnVieux_Click(object sender, EventArgs e)
        {
            menuItemID = 40;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBerenburg_Click(object sender, EventArgs e)
        {
            menuItemID = 41;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBackFromWijnen_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnGlasWitteWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 33;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnFlesWitteWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 32;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnGlasRodeWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 35;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnFlesRodeWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 34;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnChampagne_Click(object sender, EventArgs e)
        {
            menuItemID = 36;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBackFromBieren_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnHertogJan_Click(object sender, EventArgs e)
        {
            menuItemID = 28;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnDuvel_Click(object sender, EventArgs e)
        {
            menuItemID = 29;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnKriek_Click(object sender, EventArgs e)
        {
            menuItemID = 30;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnLeffeTripel_Click(object sender, EventArgs e)
        {
            menuItemID = 31;
            OrderItem();
            showPanel("Dranken");
        }

        private void btnBackFromOpmerkingen_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            commentaar = txtBoxOpmerking.Text;

            lblGemaakteOpmerkingen.Text = "" + commentaar;
        }
    }
}





       
    
    