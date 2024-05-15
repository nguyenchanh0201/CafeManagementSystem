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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL; 

namespace CafeManagementSystem
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            showGRD();
        }

        void showGRD()
        {
            listProduct.Items.Clear();
            List<Product> products = BLLProducts.GetProducts();

            foreach (Product p in products)
            {
                ListViewItem listViewItem = new ListViewItem(p.getProductID().ToString());
                listViewItem.SubItems.Add(p.getProductName());
                listViewItem.SubItems.Add(p.getPrice().ToString());
                listViewItem.SubItems.Add(p.getStatus().ToString());
                listViewItem.SubItems.Add(p.getCategoryID().ToString());
                listProduct.Items.Add(listViewItem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProduct frmEditProduct = new frmEditProduct();
            frmEditProduct.ShowDialog();
        }
    }
}
