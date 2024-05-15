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
using BLL;

namespace CafeManagementSystem
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            showGRD();
        }
        void showGRD()
        {
            listCategory.Items.Clear();
            List<ProductCategory> categories = BLLCategories.getCategory();
            foreach (ProductCategory pc in categories)
            {
                ListViewItem item = new ListViewItem(pc.getCategoryID().ToString());
                item.SubItems.Add(pc.getCategoryName());
                listCategory.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCategory frmAddCategory = new frmAddCategory();
            frmAddCategory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditCategory frmEditCategory = new frmEditCategory();
            frmEditCategory.ShowDialog();

        }
    }
}
