using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManagementSystem
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            showGRD();
        }
        void showGRD()
        {
            listOrder.Items.Clear();
            List<OrderData> orders = BLLOrderData.getOrderData();
            foreach (OrderData o in orders)
            {
                ListViewItem item = new ListViewItem(o.getOrderID().ToString());
                item.SubItems.Add(o.getOrderDate().ToShortDateString());
                item.SubItems.Add(o.getTotal().ToString());
                item.SubItems.Add(o.getUsername());
                item.SubItems.Add(o.getTableID());
                item.SubItems.Add(o.getOrderType());
                item.SubItems.Add(o.getCustomerID());
                item.SubItems.Add(o.getShiftID());
                item.SubItems.Add(o.getPaymentMethod());
                listOrder.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if user is owner or manager
            if (frmLogin.role == "owner" || frmLogin.role == "manager")
            {
                frmEditOrder frmEditOrder = new frmEditOrder();
                frmEditOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to add order");
            }

            
        }
    }
}
