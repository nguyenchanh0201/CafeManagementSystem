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
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
            loadListCustomer();
            AddCustomerBinding();
            txtID.Enabled = false;

        }
        void loadListCustomer()
        {
            grd.DataSource = BLLCustomer.select();
        }
        void AddCustomerBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", grd.DataSource, "id"));
            txtName.DataBindings.Add(new Binding("Text", grd.DataSource, "name"));
            txtPhone.DataBindings.Add(new Binding("Text", grd.DataSource, "phoneNum"));
            txtGender.DataBindings.Add(new Binding("Text", grd.DataSource, "gender"));
            txtPoint.DataBindings.Add(new Binding("Text", grd.DataSource, "points"));
            txtRank.DataBindings.Add(new Binding("Text", grd.DataSource, "rankID"));
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string phoneNumber = txtPhone.Text;
            string customerID = txtID.Text;
            BLLCustomer.update(customerName, phoneNumber,customerID);
            MessageBox.Show("Update success");
            grd.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string customerID = txtID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this customer?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLCustomer.delete(customerID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListCustomer();
        }
    }
}
