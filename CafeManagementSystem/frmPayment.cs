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
    public partial class frmPayment : Form
    {
        public static string paymentMethod;
        public static Boolean status; 
        public frmPayment()
        {
            InitializeComponent();
            

        }
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentMethod = "momo";
            AddControls(new frmMomo());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmCash());
            paymentMethod = "cash";
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            AddControls(new frmCash());

            
            paymentMethod = "cash";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Write code to go back to the previous form
            this.Close();

        }
        

        private void button23_Click(object sender, EventArgs e)
        {
            //Check if the payment is successful
            //If successful, print the bill
            //Print bills and close place order form , this form then reopen place order form
            if (paymentMethod == "cash")
            {
                //Print the bill
                MessageBox.Show("Bill printed successfully");
                //Close the form
                BLLOrderData.updatePaymentMethodAndTotal(frmPlaceOrder.orderID, paymentMethod, Convert.ToDecimal(frmPlaceOrder.total));
                BLLTableCards.changeStatus(frmPlaceOrder.tableID, "Empty");

                //get Customer ID from order ID
                string customerID = BLLOrderData.getCustomerIDFromOrderID(frmPlaceOrder.orderID);
                //Update customer points
                BLLCustomer.updateCustomerPoints(customerID, Convert.ToInt32(frmPlaceOrder.total / 10));

                //Close the form
                this.Close();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPlaceOrder))
                    {
                        form.Close();
                    }
                }
                frmPlaceOrder frm = new frmPlaceOrder();
                frm.ShowDialog();
                
            }
            else if (paymentMethod == "momo")
            {
                //Print the bill


                //Check if the payment is successful
                //If successful, print the bill
                //Else say customer to try again
                
                MessageBox.Show("Bill printed successfully");
                //Close the form
                BLLOrderData.updatePaymentMethodAndTotal(frmPlaceOrder.orderID, paymentMethod, Convert.ToDecimal(frmPlaceOrder.total));
                BLLTableCards.changeStatus(frmPlaceOrder.tableID, "Empty");
                //get Customer ID from order ID
                string customerID = BLLOrderData.getCustomerIDFromOrderID(frmPlaceOrder.orderID);
                //Update customer points
                BLLCustomer.updateCustomerPoints(customerID, Convert.ToInt32(frmPlaceOrder.total / 10));
                this.Close();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPlaceOrder))
                    {
                        form.Close();
                    }
                }
                frmPlaceOrder frm = new frmPlaceOrder();
                frm.ShowDialog();

                //Close the form
                this.Close();
            }
        }
    }
}
