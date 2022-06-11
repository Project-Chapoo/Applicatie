﻿using System;
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
using ChapeauUI.Forms;

namespace ChapeauUI
{
    public partial class PDAOrdering_Joey : Form
    {
        private int tableID = 0;
        private enum Tafelnummer 
        {
           tafel1 = 1,
           tafel2 = 2,
           tafel3 = 3,
           tafel4 = 4,
           tafel5 = 5,
           tafel6 = 6,
           tafel7 = 7,
           tafel8 = 8,
           tafel9 = 9,
           tafel10 = 10,
        }    

        private string commentaar;
        private DateTime tijd = DateTime.Now;
        private int menuItemID = 0;
        private OrderItemsService orderItemsService = new OrderItemsService();

        public PDAOrdering_Joey()
        {
            InitializeComponent();
        }

        public PDAOrdering_Joey(int tableID)
        {
            this.tableID = tableID;
        }

        private void HideAllPanels()
        {
            pnlTableSelection.Hide();
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


        private void OrderOrAddQuantity()
        {
            List<OrderItems> orderItemsList = orderItemsService.GetOrderItemsPerTable(tableID);
            foreach (OrderItems item in orderItemsList)
            {
                if (item.MenuItemID == menuItemID)
                {
                    orderItemsService.QuantityAdd(tableID, menuItemID);
                    return;
                }
            }
            orderItemsService.AddOrderItem(tableID, menuItemID);
        }

        private void PDAOrdering_Joey_Load(object sender, EventArgs e)
        {
            showPanel("TableSelection");
        }

        private void showPanel(string panelName)
        {
            switch (panelName)
            {
               case "TableSelection":
                    HideAllPanels();
                    pnlTableSelection.Show();
                    break;
                case "pnlOrderOrPayment":
                    HideAllPanels();
                    pnlOrderOrPayment.Show();
                    break;
                case "CourseChoosing":
                    HideAllPanels();
                    pnlCourseChoosing.Show();
                    break;
                case "Lunch":
                    HideAllPanels();
                    pnlLunch.Show();
                    break;
                case "Diner":
                    HideAllPanels();
                    pnlDiner.Show();
                    break;
                case "Dranken":
                    HideAllPanels();
                    pnlDranken.Show();
                    break;
                case "Opmerkingen":
                    HideAllPanels();
                    pnlOpmerkingen.Show();
                    break;
                case "LunchVoorgerechten":
                    HideAllPanels();
                    pnlLunchVoorgerechten.Show();
                    break;
                case "LunchHoofdgerechten":
                    HideAllPanels();
                    pnlLunchHoofdgerechten.Show();
                    break;
                case "LunchNagerechten":
                    HideAllPanels();
                    pnlLunchNagerechten.Show();
                    break;
                case "ConfirmOrder":
                    HideAllPanels();
                    pnlConfirmOrder.Show();
                    break;
                case "btnDinervoorgerechten":
                    HideAllPanels();
                    pnlDinerVoorgerechten.Show();
                    break;
                case "DinerTussengerechten":
                    HideAllPanels();
                    pnlDinerTussengerechten.Show();
                    break;
                case "DinerHoofdgerechten":
                    HideAllPanels();
                    pnlDinerHoofdgerechten.Show();
                    break;
                case "DinerNagerechten":
                    HideAllPanels();
                    pnlDinerNagerechten.Show();
                    break;
                case "Frisdranken":
                    HideAllPanels();
                    pnlFrisdranken.Show();
                    break;
                case "Bieren":
                    HideAllPanels();
                    pnlBieren.Show();
                    break;
                case "Wijnen":
                    HideAllPanels();
                    pnlWijnen.Show();
                    break;
                case "GedestilleerdeDranken":
                    HideAllPanels();
                    pnlGedestilleerdeDranken.Show();
                    break;
                case "KoffieThee":
                    HideAllPanels();
                    pnlKoffieThee.Show();
                    break;
                default:
                    break;
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");            
            tableID = (int)Tafelnummer.tafel1;
            SetTextLabelsToCorrectTable();
        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {           
            showPanel("CourseChoosing");
        }

        private void btnHertenstoofpot_Click(object sender, EventArgs e)
        {
            menuItemID = 4;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnKabeljauw_Click(object sender, EventArgs e)
        {
            menuItemID = 5;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnLinguini_Click(object sender, EventArgs e)
        {
            menuItemID = 6;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
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
            tableID = (int)Tafelnummer.tafel2;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel3;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel4;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel5;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel6;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel7;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel8;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel9;
            SetTextLabelsToCorrectTable();
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            showPanel("pnlOrderOrPayment");
            tableID = (int)Tafelnummer.tafel10;
            SetTextLabelsToCorrectTable();
        }

        private void btnGoBackToCourseChoosingFromConfirmOrder_Click(object sender, EventArgs e)
        {
            showPanel("CourseChoosing");
        }

        private void btnLunchSteakTartaar_Click(object sender, EventArgs e)
        {
            menuItemID = 1;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnLunchPatéFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 2;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnLunchVissoep_Click(object sender, EventArgs e)
        {
            menuItemID = 3;
            OrderOrAddQuantity();
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
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnMadeleine_Click(object sender, EventArgs e)
        {
            menuItemID = 8;
            OrderOrAddQuantity();
            showPanel("Lunch");
        }

        private void btnBoerenKaas_Click(object sender, EventArgs e)
        {
            menuItemID = 9;
            OrderOrAddQuantity();
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
        }

        private void btnDinerNagerechten_Click(object sender, EventArgs e)
        {
            showPanel("DinerNagerechten");
        }

        private void btnDinerKalfstartaar_Click(object sender, EventArgs e)
        {
            menuItemID = 10;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 11;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerKrabZalmKoekjes_Click(object sender, EventArgs e)
        {
            menuItemID = 12;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerTussengerechtVissoep_Click(object sender, EventArgs e)
        {
            menuItemID = 13;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerTussengerechtConsomméFazant_Click(object sender, EventArgs e)
        {
            menuItemID = 14;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerHoofdgerechtKabeljauw_Click(object sender, EventArgs e)
        {
            menuItemID = 15;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerHoofdgerechtenHertenbiefstuk_Click(object sender, EventArgs e)
        {
            menuItemID = 17;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerNagerechtenCaféSurprise_Click(object sender, EventArgs e)
        {
            menuItemID = 18;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerNagerechtenCherryBaby_Click(object sender, EventArgs e)
        {
            menuItemID = 19;
            OrderOrAddQuantity();
            showPanel("Diner");
        }

        private void btnDinerNagerechtenFromage_Click(object sender, EventArgs e)
        {
            menuItemID = 20;
            OrderOrAddQuantity();
            showPanel("Diner");
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

            orderService.NewestOrder(IDtable);
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
            OrderItemsService orderItemsService = new OrderItemsService();
            List<OrderItems> orderItemsList = orderItemsService.GetOrderItemsPerTable(tableID);
            OrderItems items = new OrderItems();
            try
            {                
                int selectedItem = int.Parse(lstviewOrder.SelectedItems[0].SubItems[3].Text);
                int quantityCheck = int.Parse(lstviewOrder.SelectedItems[0].SubItems[1].Text);
                if (quantityCheck == 1) 
                {
                     MessageBox.Show("Verwijder het item in plaats van het aantal 0 maken.");
                }
                else 
                {
                    orderItemsService.RemoveItem(selectedItem);
                }
                lstViewOrderedItems();
            }
            catch (Exception)
            {
                if (lstviewOrder.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteer eerst een gerecht wat u wilt verminderen.");
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
            OrderOrAddQuantity();
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
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnSpaGroen_Click(object sender, EventArgs e)
        {
            menuItemID = 22;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            menuItemID = 24;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnColaLight_Click(object sender, EventArgs e)
        {
            menuItemID = 23;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnSisi_Click(object sender, EventArgs e)
        {
            menuItemID = 25;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnTonic_Click(object sender, EventArgs e)
        {
            menuItemID = 26;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnBitterLemon_Click(object sender, EventArgs e)
        {
            menuItemID = 27;
            OrderOrAddQuantity();
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
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnCappuchino_Click(object sender, EventArgs e)
        {
            menuItemID = 43;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            menuItemID = 44;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnThee_Click(object sender, EventArgs e)
        {
            menuItemID = 45;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnBackFromGedestilleerdeDranken_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnJongeJenever_Click(object sender, EventArgs e)
        {
            menuItemID = 37;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            menuItemID = 38;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            menuItemID = 39;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnVieux_Click(object sender, EventArgs e)
        {
            menuItemID = 40;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnBerenburg_Click(object sender, EventArgs e)
        {
            menuItemID = 41;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnBackFromWijnen_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnGlasWitteWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 33;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnFlesWitteWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 32;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnGlasRodeWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 35;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnFlesRodeWijn_Click(object sender, EventArgs e)
        {
            menuItemID = 34;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnChampagne_Click(object sender, EventArgs e)
        {
            menuItemID = 36;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnBackFromBieren_Click(object sender, EventArgs e)
        {
            showPanel("Dranken");
        }

        private void btnHertogJan_Click(object sender, EventArgs e)
        {
            menuItemID = 28;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnDuvel_Click(object sender, EventArgs e)
        {
            menuItemID = 29;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnKriek_Click(object sender, EventArgs e)
        {
            menuItemID = 30;
            OrderOrAddQuantity();
            showPanel("Dranken");
        }

        private void btnLeffeTripel_Click(object sender, EventArgs e)
        {
            menuItemID = 31;
            OrderOrAddQuantity();
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

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            TablesService tableService = new TablesService();
            List<Tables> orderList = tableService.GetTables();
            tableService.ReserveTable(tableID);

            MessageBox.Show($"Tafel {tableID} is gereserveerd.");
            showPanel("pnlOrderOrPayment");
        }
        //lelijke code
        private void SetTextLabelsToCorrectTable()
        {
            lblTableNumber.Text = $"Tafel: {tableID}";
            lblTableBieren.Text = $"Tafel: {tableID}";
            lblTableFrisdranken.Text = $"Tafel: {tableID}";
            lblTableGedesilleerdeDranken.Text = $"Tafel: {tableID}";
            lblTableKoffieThee.Text = $"Tafel: {tableID}";
            lblTableWijnen.Text = $"Tafel: {tableID}";
            lblTableDranken.Text = $"Tafel: {tableID}";
            lblTableDinerVoorgerechten.Text = $"Tafel: {tableID}";
            lblTableDinerTussengerechten.Text = $"Tafel: {tableID}";
            lblTableDinerHoofdgerechten.Text = $"Tafel: {tableID}";
            lblTableDinerNagerechten.Text = $"Tafel: {tableID}";
            lblTableDiner.Text = $"Tafel: {tableID}";
            lblTableLunchVoorgerechten.Text = $"Tafel: {tableID}";
            lblTableLunchHoofdgerechten.Text = $"Tafel: {tableID}";
            lblTableLunchNagerechten.Text = $"Tafel: {tableID}";
            lblTableLunch.Text = $"Tafel: {tableID}";
            lblTableCourseChoosing.Text = $"Tafel: {tableID}";
            lblTableComments.Text = $"Tafel: {tableID}";
            lblTableOrderOrPayment.Text = $"Tafel: {tableID}";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payingfrm payingFrm = new Payingfrm(tableID);
            this.Hide();
            payingFrm.Closed += (s, args) => this.Close();
            payingFrm.Show();
        }
    }
}





       
    
    