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
    public partial class frmCash : Form
    {
        
        public frmCash()
        {
            InitializeComponent();
            lbTotal.Text = frmPlaceOrder.total.ToString();
        }

        

        

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            //500K
            txtReceived.Text = "500000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //200K
            txtReceived.Text = "200000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //100K
            txtReceived.Text = "100000";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //50K
            txtReceived.Text = "50000";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //20K
            txtReceived.Text = "20000";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //10K
            txtReceived.Text = "10000";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5K
            txtReceived.Text = "5000";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Add 1 to the received amount by string concatenation
            txtReceived.Text += "1";


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Add 2 to the received amount by string concatenation
            txtReceived.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Add 3 to the received amount by string concatenation
            txtReceived.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "00";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtReceived.Text += "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Delete last character
            if (txtReceived.Text.Length > 0)
            {
                txtReceived.Text = txtReceived.Text.Remove(txtReceived.Text.Length - 1, 1);
            }
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            //Calculate the change
            decimal total = Convert.ToDecimal(lbTotal.Text);
            decimal received = Convert.ToDecimal(txtReceived.Text);
            decimal change = received - total;
            if (total > received)
            {
                MessageBox.Show("Received amount is not enough");
            }
            else
            {
                lbReturn.Text = change.ToString();
            }
            
        }
    }
}
