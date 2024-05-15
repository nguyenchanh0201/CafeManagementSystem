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
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
            
            loadListOrder();
            txtOrderID.Enabled = false;
            txtOrderDate.Enabled = false;
            txtTotal.Enabled = false;         

        }
        void loadListOrder()
        {
            grd.DataSource = BLLOrderData.select();
        }
        

        private void Update_Click(object sender, EventArgs e)
        {
            String orderID = txtOrderID.Text;
            DateTime orderDate = DateTime.Now;
            string orderDateString = orderDate.ToString();
            decimal total = decimal.Parse(txtTotal.Text);
            String username = txtUserName.Text;
            String tableID = txtTableID.Text;
            String orderType = txtOrderType.Text;
            String customerID = txtCustomerID.Text;
            String shiftID = txtShiftID.Text;
            String paymentMethod = label.Text;
            BLLOrderData.update(orderID, orderDate, total, username, tableID, orderType, customerID, shiftID,paymentMethod);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListOrder();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string orderID = txtOrderID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this order?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLOrderData.delete(orderID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListOrder();
        }

        private void grd_Click(object sender, EventArgs e)
        {

            txtOrderID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtOrderDate.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtTotal.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtUserName.Text = grd.CurrentRow.Cells[3].Value.ToString();
            txtTableID.Text = grd.CurrentRow.Cells[4].Value.ToString();
            txtOrderType.Text = grd.CurrentRow.Cells[5].Value.ToString();
            txtCustomerID.Text = grd.CurrentRow.Cells[6].Value.ToString();
            txtShiftID.Text = grd.CurrentRow.Cells[7].Value.ToString();
            label.Text = grd.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
