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
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
            loadListCategory();
            txtID.Enabled = false;
        }
        void loadListCategory()
        {
            grd.DataSource = BLLCategories.select();
        }   
        


        private void grd_Click(object sender, EventArgs e)
        {
            txtID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = grd.CurrentRow.Cells[1].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string CategoryName= txtName.Text;
            string CategoryID = txtID.Text;
            //Yes-No Message
            DialogResult result = MessageBox.Show("Do you want to update this category?", "Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLCategories.update(CategoryName,CategoryID);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListCategory();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string CategoryID = txtID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this category?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLCategories.delete(CategoryID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListCategory();
        }
    }
}
