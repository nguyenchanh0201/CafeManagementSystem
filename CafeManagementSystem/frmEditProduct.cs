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
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
            loadGRD();
        }

        public void loadGRD()
        {
            grd.DataSource = BLLProducts.select();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string productID = txtID.Text;
            DialogResult result = MessageBox.Show("Do you want to delete this product?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLProducts.delete(productID);
            MessageBox.Show("Product Deleted Successfully, reload to see new contents");
        }

        

        private void Update_Click(object sender, EventArgs e)
        {   
            string productID = txtID.Text;
            string productName = txtName.Text;
            decimal productPrice = Convert.ToDecimal(txtPrice.Text);
            string productCate = txtCateID.Text;
            if (txtID.Text != "")
            {
                
                BLLProducts.update(productID, productName, productCate, productPrice);
                MessageBox.Show("Product Updated Successfully, reload to see new contents");
                loadGRD();
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void grd_Click(object sender, EventArgs e)
        {
            txtID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtStatus.Text = grd.CurrentRow.Cells[3].Value.ToString();
            txtCateID.Text = grd.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
