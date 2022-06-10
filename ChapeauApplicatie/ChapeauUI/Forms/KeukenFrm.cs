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
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ChapeauUI.Forms
{
    public partial class KeukenFrm : Form
    {

        public KeukenFrm()
        {
            InitializeComponent();
        }

        private void KeukenFrm_Load(object sender, EventArgs e)
        {
            FIllListViews();
        }

        private void FIllListViews()
        {
            KeukenListView1.Items.Clear();
            KeukenListView2.Items.Clear();
            KeukenListView3.Items.Clear();
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = new List<OrderModel>();
            orders = keuken.GetOrderListByLatest();
            List<ListView> listviews = new List<ListView>();
            listviews.Add(KeukenListView1);
            listviews.Add(KeukenListView2);
            listviews.Add(KeukenListView3);
            for (int i = 0; i < 3;)
            {
                FillList(keuken, orders[i].OrderId, i, listviews[i]);
                i++;
            }
        }

        private void FillList(KeukenService keuken, int OrderID, int nummer, ListView listview)
        {


            listview.View = View.Details;
            foreach (KeukenItemModel keukenItem in keuken.GetOrderByID(OrderID))
            {
                ListViewItem li = new ListViewItem(keukenItem.quantity.ToString());
                li.SubItems.Add(keukenItem.Description);
                listview.Items.Add(li);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();
            try
            {
                keuken.ReadyOrder(orders[0].OrderId);
                FIllListViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There are no Orders");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();
            try
            {
                keuken.ReadyOrder(orders[1].OrderId);
                FIllListViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There are no Orders");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();
            try
            {
                keuken.ReadyOrder(orders[2].OrderId);
                FIllListViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There are no Orders");
            }
        }
    }
}
