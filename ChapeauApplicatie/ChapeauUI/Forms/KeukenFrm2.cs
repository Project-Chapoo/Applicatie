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
        private string employeeName;
        public KeukenFrm2(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }

        private void KeukenFrm2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            FIllListViews();
            LogedInEmployee();
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

            for (int i = 0; i < orders.Count;)
            {
                if (i > 2)
                    return;
                FillList(keuken, orders[i].OrderId, i, listviews[i]);
                FillTimeLabels(orders[i].TimeOrdered, labelTimeList[i]);
                FillTableLabels(orders[i].TableId, labelTableList[i]);
                txtOpmerkingList[i].Text = orders[i].Comment;
                i++;
            }
        }
        private void FillTimeStrings(DateTime TimeOrdered, Label label)
        {
            
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
            List<OrderModel> keukenitems = keuken.GetOrderListByLatest();
            try
            {
                BarService Bar = new BarService();
                List<OrderModel> barOrders = Bar.GetOrderListByLatest();
                List<BarItemModel> barItems = Bar.GetOrderByID(barOrders[number].OrderId);
                if (barItems[0].OrderItemID == 0)
                {
                    MessageBox.Show("whole order is ready");
                    keuken.ReadyOrder(keukenitems[number].OrderId);
                    FIllListViews();
                }
                else
                {
                    MessageBox.Show("only items are ready");
                    keuken.ReadyAllKeukenOrderItems(keukenitems[number].OrderId);
                    FIllListViews();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("whole order is ready");
                keuken.ReadyOrder(keukenitems[number].OrderId);
                FIllListViews();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            KassaLogin kassaLogin = new KassaLogin();
            this.Hide();
            kassaLogin.Closed += (s, args) => this.Close();
            kassaLogin.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TafelOverzicht tafelOverzicht = new TafelOverzicht();
            tafelOverzicht.Show();
            tafelOverzicht.LogedInEmployee(employeeName);
        }
        public void LogedInEmployee()
        {
            lblEmployeeName.Text = employeeName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KeukenService keuken = new KeukenService();
            List<OrderModel> orders = keuken.GetOrderListByLatest();

            List<Label> labelTimeWaitingList = new List<Label>();
            labelTimeWaitingList.Add(lblWaitingTime1);
            labelTimeWaitingList.Add(lblWaitingTime2);
            labelTimeWaitingList.Add(lblWaitingTime3);

            DateTime OverzichtTijd = DateTime.Now;
            lblTimeNow.Text = OverzichtTijd.ToString("HH:mm dd/mm/yyyy");
            for (int i = 0; i < orders.Count; i++)
            {
                if (i > 2)
                    return;
                labelTimeWaitingList[i].Text = OverzichtTijd.Subtract(orders[i].TimeOrdered).ToString(@"hh\:mm");
            }
        }
    }
}
