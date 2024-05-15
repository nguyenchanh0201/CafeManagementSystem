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
    public partial class frmEditRole : Form
    {
        public frmEditRole()
        {
            InitializeComponent();
            loadListRole();
            AddRoleBinding();
            txtID.Enabled = false;
        }
        void loadListRole()
        {
            grd.DataSource = BLLRole.select();

        }
        void AddRoleBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", grd.DataSource, "roleName"));
            txtID.DataBindings.Add(new Binding("Text", grd.DataSource, "roleID"));
        }



        private void Update_Click(object sender, EventArgs e)
        {
            String roleName = txtName.Text;
            int roleID = Convert.ToInt32(txtID.Text);
            BLLRole.update(roleID, roleName);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListRole();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int roleID = Convert.ToInt32(txtID.Text);
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this role?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLRole.delete(roleID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListRole();
        }

        private void grp2_Enter(object sender, EventArgs e)
        {

        }


    }
}