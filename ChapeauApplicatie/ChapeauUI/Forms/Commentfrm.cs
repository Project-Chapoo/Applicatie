using ChapeauModels;
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
    public partial class Commentfrm : Form
    {
        Bill bill;
        public Commentfrm(Bill bill)
        {
            InitializeComponent();
            btnAddComment.Enabled = false;
            this.bill = bill;
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            bill.Comment = (string)txtComment.Text;
            OpenPreviousFormWithComment();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Payingfrm payingForm = new Payingfrm(bill);
            this.Hide();
            payingForm.Closed += (s, args) => this.Close();
            payingForm.Show();
        }

        private void OpenPreviousFormWithComment()
        {
            Payingfrm payingForm = new Payingfrm(bill);
            this.Hide();
            payingForm.Closed += (s, args) => this.Close();
            payingForm.Show();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            btnAddComment.Enabled = true;
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            // TODO: Add link to the menu form
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            // TODO: Add link to the order status form
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payingfrm payingForm = new Payingfrm(bill);
            this.Hide();
            payingForm.Closed += (s, args) => this.Close();
            payingForm.Show();
        }
    }
}
