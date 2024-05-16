using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL; 

namespace CafeManagementSystem
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
            loadgrd1();
            
            txtOrderID.Enabled = false;
        }

        void loadgrd1()
        {
            grd1.DataSource = BLLOrderData.select();
        }

        void loadgrd2()
        {
            string orderID = txtOrderID.Text;
            grd2.DataSource = BLLOrderDetails.GetData(orderID);
        }

        private void grd1_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = grd1.CurrentRow.Cells[0].Value.ToString();

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            loadgrd2();
        }

        private void grd2_Click(object sender, EventArgs e)
        {
            txtODetailsID.Text = grd2.CurrentRow.Cells[0].Value.ToString();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtODetailsID.Text);
            BLLOrderDetails.deleteOrderDetail(id);
            MessageBox.Show("Order Detail Deleted Successfully, reload to see new contents");
            grd2.Refresh();
            
        }
    }
}
