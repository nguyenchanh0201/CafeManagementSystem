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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
            loadCate();
        }

        private void loadCate()
        {
            List<ProductCategory> cates = BLLCategories.getCategory();
            foreach (ProductCategory cate in cates)
            {
                listBox1.Items.Add(cate.getCategoryID() + "." + cate.getCategoryName());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string productName = txtName.Text;
            decimal productPrice = Convert.ToDecimal(txtPrice.Text);
            
            if (listBox1.SelectedItem != null)
            {
                string productCate = listBox1.SelectedItem.ToString().Split('.')[0];
                BLLProducts.insert(productName, productCate, productPrice );

                MessageBox.Show("Product Added Successfully, reload to see new contents");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a category");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
