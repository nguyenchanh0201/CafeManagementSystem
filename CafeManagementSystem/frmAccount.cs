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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            showGRD();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

        public void showGRD()
        {
            listAccount.Items.Clear();

            List<Users> users = BLLUsers.getUsers();
            foreach (Users u in users)
            {
                ListViewItem item = new ListViewItem(u.getUsername().ToString());
                //Get role name
                string roleName = BLLUsers.getRole(u.getUsername().ToString());
                
                item.SubItems.Add(u.getName());
                item.SubItems.Add(u.getPhone());
                item.SubItems.Add(roleName);
                listAccount.Items.Add(item);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            frmEditAccount frmEditAccount = new frmEditAccount();
            frmEditAccount.ShowDialog();
        }
    }
}
