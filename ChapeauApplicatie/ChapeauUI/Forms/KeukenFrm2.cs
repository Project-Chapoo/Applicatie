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
    public partial class KeukenFrm2 : Form
    {
        public KeukenFrm2()
        {
            InitializeComponent();
        }

        private void KeukenFrm2_Load(object sender, EventArgs e)
        {
            
            FIllListViews();
        }
        private void FIllListViews()
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();

            KeukenListView1.Items.Clear();
            KeukenListView2.Items.Clear();
            KeukenListView3.Items.Clear();


            List<ListView> listviews = new List<ListView>();
            listviews.Add(KeukenListView1);
            listviews.Add(KeukenListView2);
            listviews.Add(KeukenListView3);

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
                FillList(keuken, orders[i].OrderId, i, listviews[i]);
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
        private void FillList(KeukenService keuken, int OrderID, int nummer, ListView listview)
        {
            listview.View = View.Details;
            foreach (KeukenItemModel keukenItem in keuken.GetOrderByID(OrderID))
            {
                ListViewItem li = new ListViewItem(keukenItem.OrderItemID.ToString());
                li.SubItems.Add(keukenItem.quantity.ToString());
                li.SubItems.Add(keukenItem.Description);
                listview.Items.Add(li);
            }

        }

        private void btnGereed1_Click(object sender, EventArgs e)
        {
            ReadyOrder(0);
        }

        private void btnGereed2_Click(object sender, EventArgs e)
        {
            ReadyOrder(1);
        }

        private void btnGereed3_Click(object sender, EventArgs e)
        {
            ReadyOrder(2);
        }
        private void ReadyOrder(int number)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();
            try
            {
                keuken.ReadyOrder(orders[number].OrderId);
                FIllListViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There are no Orders");
            }
        }

        private void KeukenListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(KeukenListView1);
        }

        private void KeukenListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(KeukenListView2);
        }

        private void KeukenListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadyOrderItem(KeukenListView3);
        }
        private void ReadyOrderItem(ListView listView)
        {
            KeukenService keuken = new KeukenService();
            try
            {
                keuken.ReadyOrderItem(int.Parse(listView.SelectedItems[0].SubItems[0].Text));
                FIllListViews();
            }
            catch (Exception ex)
            { }
        }
    }
}
