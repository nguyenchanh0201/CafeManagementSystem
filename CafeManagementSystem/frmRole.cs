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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
            showGRD();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddRole far = new frmAddRole();
            far.ShowDialog();
        }
        public void showGRD()
        { 
            listRole.Items.Clear();

            List<Role> roles = BLLRole.getRole();
            foreach (Role role in roles)
            {
                ListViewItem item = new ListViewItem(role.getRoleID().ToString());
                item.SubItems.Add(role.getRoleName());
                listRole.Items.Add(item);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditRole frmEditRole = new frmEditRole();
            frmEditRole.ShowDialog();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void listRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
