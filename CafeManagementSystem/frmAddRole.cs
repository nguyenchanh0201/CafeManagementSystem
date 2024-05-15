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
    public partial class frmAddRole : Form
    {
        public frmAddRole()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roleName = txtName.Text;
            BLLRole bLLRole = new BLLRole(0,"");
            bLLRole.insert(roleName);
            //Message 
            MessageBox.Show("Role Added Successfully, reload to see new contents");
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
