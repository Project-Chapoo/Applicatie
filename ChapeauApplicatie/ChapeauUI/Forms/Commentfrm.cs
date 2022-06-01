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
            Payingfrm pf = new Payingfrm(bill);
            this.Hide();
            pf.Closed += (s, args) => this.Close();
            pf.Show();
        }

        private void OpenPreviousFormWithComment()
        {
            Payingfrm pf = new Payingfrm(bill);
            this.Hide();
            pf.Closed += (s, args) => this.Close();
            pf.Show();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            btnAddComment.Enabled = true;
        }
    }
}
