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
    public partial class frmTrackRevenue : Form
    {
        public frmTrackRevenue()
        {
            InitializeComponent();
            grd1.DataSource = BLLOrderData.getRevenueByYear();
            
        }

       

        

        
        

        private void grd1_Click(object sender, EventArgs e)
        {
            
            txtYear.Text = grd1.CurrentRow.Cells[0].Value.ToString();
        }

        private void bShow2_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text == "")
            {
                MessageBox.Show("Please select a month");
                return;
            }
            grd3.DataSource = BLLOrderData.getRevenueByDate(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtMonth.Text));
        }

        private void grd2_Click(object sender, EventArgs e)
        {
            txtMonth.Text = grd2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                MessageBox.Show("Please select a year");
                return;
            }
            grd2.DataSource = BLLOrderData.getRevenueByMonth(Convert.ToInt32(txtYear.Text));
        }

        private void grd3_Click(object sender, EventArgs e)
        {
            txtDate.Text = grd3.CurrentRow.Cells[0].Value.ToString();
        }

        private void bShow3_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "")
            {
                MessageBox.Show("Please select a day");
                return;
            }
            grd4.DataSource = BLLOrderData.getRevenueByShift(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtDate.Text));
        }
    }
}
