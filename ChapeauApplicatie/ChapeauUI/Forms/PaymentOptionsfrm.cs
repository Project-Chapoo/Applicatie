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
    public partial class PaymentOptionsfrm : Form
    {
        private Bill bill;
        private PayingService payingService = new PayingService();

        public PaymentOptionsfrm(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void btnCardPayment_Click(object sender, EventArgs e)
        {
            payingService.SendBill(bill);
            this.Close();
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            payingService.SendBill(bill);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Payingfrm payingForm = new Payingfrm(bill);
            this.Hide();
            payingForm.Closed += (s, args) => this.Close();
            payingForm.Show();
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
    }
}
