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
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            payingService.SendBill(bill);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Payingfrm payingForm = new Payingfrm(bill);
            this.Hide();
            payingForm.Closed += (s, args) => this.Close();
            payingForm.Show();
        }
    }
}
