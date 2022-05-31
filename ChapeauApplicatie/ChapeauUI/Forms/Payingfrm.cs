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
        private double tip;
        
        public Payingfrm()
        {
            InitializeComponent();
        }

        public Payingfrm(double tip)
        {
            InitializeComponent();
            this.tip = tip;
            // Add method that adds the tip to the bill Items
        }



        private void btnAddTip_Click(object sender, EventArgs e)
        {
            Tipfrm tf = new Tipfrm(5);
            this.Hide();
            tf.Closed += (s, args) => this.Close();
            tf.Show();
        }

        private void Payingfrm_Load(object sender, EventArgs e)
        {
            PayingService payingService = new PayingService();
            Bill bill = payingService.GetBill();
            
            foreach (BillItem b in bill.billItems) 
            { 
                ListViewItem item = new ListViewItem(Convert.ToString(b.Quantity) + "x");
                item.SubItems.Add(b.Description);
                item.SubItems.Add(Convert.ToString(b.Price));
                txtOrder.Items.Add(item);
            }
        }
    }
}
