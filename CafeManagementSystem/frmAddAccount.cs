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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
            loadRole();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadRole()
        {


            List<Role> roles = BLLRole.getRole();
            foreach (Role role in roles)
            {
                listBox1.Items.Add(role.getRoleID() + "."+ role.getRoleName());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int roleID = Convert.ToInt32(listBox1.SelectedItem.ToString().Split('.')[0]);
                BLLUsers bLLUsers = new BLLUsers("", "", 0, "", "");
                bLLUsers.insert(txtUsername.Text, "123456", roleID, txtName.Text, txtPhone.Text);
                MessageBox.Show("Account Added Successfully, reload to see new contents");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }
    }
}
