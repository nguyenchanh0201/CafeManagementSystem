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
    public partial class frmChangePwd : Form
    {

        public frmChangePwd()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPwdConfirm.PasswordChar = '*';
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {

            string newPassword = txtPassword.Text;
            string confirmPassword = txtPwdConfirm.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                //Change password
                string username = frmLogin.username; // Assuming frmLogin is a form where username is stored
                BLLUsers bllusers = new BLLUsers(username, newPassword, 0, "", ""); // Assuming the third parameter is some other information like email
                bllusers.updatePassword(username, newPassword);

                //Update password in database
                MessageBox.Show("Password changed successfully");
                this.Close();
            }
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            
        }

        private void Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = Showpassword.Checked ? '\0' : '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPwdConfirm.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
