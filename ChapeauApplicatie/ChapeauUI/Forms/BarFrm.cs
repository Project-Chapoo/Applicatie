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
    public partial class BarFrm : Form
    {
        public BarFrm()
        {
            InitializeComponent();
        }

        private void BarFrm_Load(object sender, EventArgs e)
        {
            FIllListViews();
        }
        private void FIllListViews()
        {
            BarService bar = new BarService();
            List<OrderModel> orders = bar.GetOrderListByLatest();

            BarListview1.Items.Clear();
            BarListview2.Items.Clear();
            BarListview3.Items.Clear();


            List<ListView> listviews = new List<ListView>();
            listviews.Add(BarListview1);
            listviews.Add(BarListview2);
            listviews.Add(BarListview3);

            List<Label> labelTimeList = new List<Label>();
            labelTimeList.Add(lblTimeOrdered1);
            labelTimeList.Add(lblTimeOrdered2);
            labelTimeList.Add(lblTimeOrdered3);

            List<Label> labelTableList = new List<Label>();
            labelTableList.Add(lblTableNumber1);
            labelTableList.Add(lblTableNumber2);
            labelTableList.Add(lblTableNumber3);

            List<TextBox> txtOpmerkingList = new List<TextBox>();
            txtOpmerkingList.Add(opmerkingen1txt);
            txtOpmerkingList.Add(opmerkingen2txt);
            txtOpmerkingList.Add(opmerkingen3txt);

            for (int i = 0; i < 3;)
            {
                FillList(bar, orders[i].OrderId, i, listviews[i]);
                FillTimeLabels(orders[i].TimeOrdered, labelTimeList[i]);
                FillTableLabels(orders[i].TableId, labelTableList[i]);
                txtOpmerkingList[i].Text = orders[i].Comment;
                i++;
            }

        }
        private void FillTimeLabels(DateTime time, Label label)
        {
            label.Text = time.ToString();
        }
        private void FillTableLabels(int TableID, Label label)
        {
            label.Text = $"Table: {TableID}";
        }
        private void FillList(BarService bar, int OrderID, int nummer, ListView listview)
        {
            listview.View = View.Details;
            foreach (BarItemModel barItem in bar.GetOrderByID(OrderID))
            {
                ListViewItem li = new ListViewItem(barItem.OrderItemID.ToString());
                li.SubItems.Add(barItem.quantity.ToString());
                li.SubItems.Add(barItem.Description);
                listview.Items.Add(li);
            }

        }
        private void ReadyOrder(int number)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> keukenOrders = keuken.GetOrderListByLatest();
            List<KeukenItemModel> keukenItems = keuken.GetOrderByID(keukenOrders[number].OrderId);

            BarService bar = new BarService();
            List<OrderModel> barOrders = bar.GetOrderListByLatest();
            if (keukenItems[0] is null)
            {
                try
                {
                    bar.ReadyOrder(barOrders[number].OrderId);
                    FIllListViews();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("There are no Orders");
                }
            }
            else
            {
                bar.ReadyAllBarOrderItems(barOrders[number].OrderId);
                FIllListViews();
            }
        }
        private void ReadyOrderItem(ListView listView)
        {
            BarService keuken = new BarService();
            try
            {
                keuken.ReadyOrderItem(int.Parse(listView.SelectedItems[0].SubItems[0].Text));
                FIllListViews();
            }
            catch (Exception ex)
            { }
        }

        private void BarListview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(BarListview1);
        }

        private void BarListview2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(BarListview2);
        }

        private void BarListview3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(BarListview3);
        }

        private void btnGereed1_Click(object sender, EventArgs e)
        {
            ReadyOrder(0);
        }
    }
}
