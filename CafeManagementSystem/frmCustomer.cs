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
using BLL;


namespace CafeManagementSystem
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            showGRD();
        }
        void showGRD()
        {
            listCustomer.Items.Clear();
            List<Customer> customers = BLLCustomer.getCustomer();
            foreach (Customer c  in customers)
            {
                ListViewItem item = new ListViewItem(c.getCustomerID().ToString());
                item.SubItems.Add(c.getCustomerName());
                item.SubItems.Add(c.getPhoneNumber());
                item.SubItems.Add(c.getGender());
                item.SubItems.Add(c.getPoints().ToString());
                item.SubItems.Add(c.getMembershipLevel().ToString());
                listCustomer.Items.Add(item);
            }
        }

        

        private void bEdit_Click(object sender, EventArgs e)
        {
            frmEditCustomer frmEditCustomer = new frmEditCustomer();
            frmEditCustomer.ShowDialog();
        }
    }
}
