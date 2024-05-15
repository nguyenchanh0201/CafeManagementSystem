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
using DTO; 

namespace CafeManagementSystem
{
    public partial class frmMemberShip : Form
    {
        public frmMemberShip()
        {
            InitializeComponent();
            grp.Enabled = false; 
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text; 
            List<Customer> customers = BLLCustomer.getCustomerByPhone(phoneNumber);
            if (customers.Count == 0)
            {   //Message do you want to add new customer, yes no 
                DialogResult result = MessageBox.Show("Do you want to add new customer?", "Add new customer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    grp.Enabled = true;

                }
                else
                {
                    return;
                }
            }
            else
            {
                string orderID = frmPlaceOrder.orderID;
                string customerID = customers[0].getCustomerID();
                BLLOrderData.updateOrderCustomer(orderID, customerID);
                MessageBox.Show("Add customer successfully");
                this.Close();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BLLCustomer.insert(txtName.Text, txtNewPhone.Text, listBox1.Text, 0, "R001");
            string orderID = frmPlaceOrder.orderID;
            string customerID = BLLCustomer.getCustomerByPhone(txtNewPhone.Text)[0].getCustomerID();
            BLLOrderData.updateOrderCustomer(orderID, customerID);
            //Message success
            MessageBox.Show("Add new customer successfully");
            this.Close();
        }
    }
}
