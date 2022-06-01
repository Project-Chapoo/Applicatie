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
        private PayingService payingService = new PayingService();
        private Bill bill;

        public Payingfrm(Bill bill)
        {
            this.bill = bill;
            InitializeComponent();
        }

        public Payingfrm()
        {
            this.bill = payingService.GetOrder();
            InitializeComponent();
        }

        public Payingfrm(Bill bill, double tip)
        {
            this.bill = bill;
            this.bill = payingService.AddTip(bill, tip);
            InitializeComponent();
        }



        private void btnAddTip_Click(object sender, EventArgs e)
        {
            Tipfrm tf = new Tipfrm(bill, bill.TotalPrice);
            this.Hide();
            tf.Closed += (s, args) => this.Close();
            tf.Show();
        }

        private void Payingfrm_Load(object sender, EventArgs e)
        {
            txtOrder.Columns.Add("Quantity", 69);
            txtOrder.Columns.Add("Item", 124);
            txtOrder.Columns.Add("Price", 69);

            // euro character =  €

            foreach (BillItem b in bill.billItems) 
            { 
                ListViewItem item = new ListViewItem(Convert.ToString(b.Quantity) + "x");
                item.SubItems.Add(b.Description);
                item.SubItems.Add($"€ {b.Price:0.00}");
                txtOrder.Items.Add(item);
            }

            lblTotalPrice.Text = $"Total Price: € {bill.TotalPrice:0.00}";
        }
    }
}
