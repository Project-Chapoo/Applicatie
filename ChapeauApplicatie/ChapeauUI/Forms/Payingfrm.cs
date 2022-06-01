﻿using ChapeauModels;
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


        public Payingfrm() // Joey this contructor for de link between forms
        {
            this.bill = payingService.GetOrder();
            InitializeComponent();
        }

        public Payingfrm(Bill bill)
        {
            this.bill = bill;
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
            // Scroll bar is 21 px wide
            txtOrder.Columns.Add("Aantal", 35);
            txtOrder.Columns.Add("Item", 104);
            txtOrder.Columns.Add("Prijs", 40);

            foreach (BillItem b in bill.billItems) 
            { 
                ListViewItem item = new ListViewItem(Convert.ToString(b.Quantity) + "x");
                item.SubItems.Add(b.Description);
                item.SubItems.Add($"€ {b.Price:0.00}");
                txtOrder.Items.Add(item);
            }

            lblTotalPrice.Text = $"Total Price: € {bill.TotalPrice:0.00}";
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            Commentfrm tf = new Commentfrm(bill);
            this.Hide();
            tf.Closed += (s, args) => this.Close();
            tf.Show();
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            // TODO: Add link to the menu form
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            // TODO: Add link to the order status form
        }
    }
}
