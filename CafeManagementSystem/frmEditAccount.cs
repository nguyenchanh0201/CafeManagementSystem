using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace CafeManagementSystem
{
    public partial class frmEditAccount : Form
    {
        public frmEditAccount()
        {
            InitializeComponent();
            loadListAccount();
            AddAccountBinding();
            txtuser.Enabled = false;
            txtRole.Enabled = false;
        }
        void loadListAccount()
        {
            grd.DataSource = BLLUsers.select();
        }
        void AddAccountBinding()
        {
            txtuser.DataBindings.Add(new Binding("Text", grd.DataSource, "username"));
            txtRole.DataBindings.Add(new Binding("Text", grd.DataSource, "roleID"));
            txtName.DataBindings.Add(new Binding("Text", grd.DataSource, "name"));
            txtPhone.DataBindings.Add(new Binding("Text", grd.DataSource, "phone"));
        }

        

        private void Update_Click(object sender, EventArgs e)
        {
            String username = txtuser.Text;
            String name = txtName.Text;
            String phone = txtPhone.Text;
            //Yes-No Message
            DialogResult result = MessageBox.Show("Do you want to update this account?", "Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLUsers.update(username, name, phone);
            MessageBox.Show("Update success");
            grd.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this account?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLUsers.delete(username);

            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListAccount();
        }
    }
}
