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
    public partial class KeukenFrm : Form
    {
        public KeukenFrm()
        {
            InitializeComponent();
        }

        private void KeukenFrm_Load(object sender, EventArgs e)
        {
            KeukenService keuken = new KeukenService();
            KeukenListView1.View = View.Details;
            foreach (KeukenItemModel keukenItem in keuken.GetFirstOrder())
            {
                ListViewItem li = new ListViewItem(keukenItem.quantity.ToString());
                li.SubItems.Add(keukenItem.Description);
                KeukenListView1.Items.Add(li);
            }

            KeukenListView2.View = View.Details;
            foreach (KeukenItemModel keukenItem in keuken.GetSecondOrder())
            {
                ListViewItem li = new ListViewItem(keukenItem.quantity.ToString());
                li.SubItems.Add(keukenItem.Description);
                KeukenListView2.Items.Add(li);
            }

            KeukenListView3.View = View.Details;
            foreach (KeukenItemModel keukenItem in keuken.GetThirdOrder())
            {
                ListViewItem li = new ListViewItem(keukenItem.quantity.ToString());
                li.SubItems.Add(keukenItem.Description);
                KeukenListView3.Items.Add(li);
            }
        }
    }
}
