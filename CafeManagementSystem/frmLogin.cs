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
    public partial class frmLogin : Form
    {
        public static string username;
        public static string role; 
        string password;

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
             username = txtUsername.Text;
             password = txtPassword.Text;
             
            // Check if either username or password fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            // Check if the username and password are correct
            BLLUsers users = new BLLUsers(username, password, 0, "", "");
            role = BLLUsers.getRole(username);


            if (users.login(username, password))
            {
                // Login successful, show the main form
                frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                // Login failed, show an error message
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = Showpassword.Checked ? '\0' : '*';
        }
    }
}





