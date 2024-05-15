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
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryID = txtName.Text;
            BLLCategories bLLCategories = new BLLCategories("", "");
            BLLCategories.insert(categoryID);
            //Message 
            MessageBox.Show("Category Added Successfully, reload to see new contents");
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
