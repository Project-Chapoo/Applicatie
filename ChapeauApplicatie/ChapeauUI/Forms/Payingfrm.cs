using ChapeauModels;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class Payingfrm : Form
    {
        private Bill bill;
        private PayingService payingService = new PayingService();

        public Payingfrm(int orderID) // Joey this contructor for de link between forms
        {
            this.bill = payingService.GetOrder(orderID);
            InitializeComponent();
        }

        public Payingfrm(Bill bill)
        {
            this.bill = bill;
            InitializeComponent();
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            Tipfrm tipForm = new Tipfrm(bill, bill.TotalPrice);
            this.Hide();
            tipForm.Closed += (s, args) => this.Close();
            tipForm.Show();
        }

        private void Payingfrm_Load(object sender, EventArgs e)
        {
            bill.BTWPrice = payingService.CalculateBTW(bill);

            // Scroll bar is 21 px wide
            txtOrder.Columns.Add("Aantal", 39);
            txtOrder.Columns.Add("Item", 96);
            txtOrder.Columns.Add("Prijs", 47);

            foreach (BillItem b in bill.billItems) 
            { 
                ListViewItem item = new ListViewItem(Convert.ToString(b.Quantity) + "x");
                item.SubItems.Add(b.Description);
                item.SubItems.Add($"€ {b.Price:0.00}");
                txtOrder.Items.Add(item);
            }

            lblTotalPrice.Text = $"Totale prijs: € {bill.TotalPrice:0.00}";
            lblBTW.Text = $"BTW: € {bill.BTWPrice:0.00}";
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            Commentfrm commentForm = new Commentfrm(bill);
            this.Hide();
            commentForm.Closed += (s, args) => this.Close();
            commentForm.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentOptionsfrm paymentOptionsForm = new PaymentOptionsfrm(bill);
            this.Hide();
            paymentOptionsForm.Closed += (s, args) => this.Close();
            paymentOptionsForm.Show();
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            PDAOrdering_Joey p = new PDAOrdering_Joey(bill.TableID);
            this.Hide();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            // TODO: Add link to the order status form
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payingfrm payingfrm = new Payingfrm(bill.OrderID);
            this.Hide();
            payingfrm.Closed += (s, args) => this.Close();
            payingfrm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PDAOrdering_Joey p = new PDAOrdering_Joey(bill.TableID);
            this.Hide();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }
    }
}
