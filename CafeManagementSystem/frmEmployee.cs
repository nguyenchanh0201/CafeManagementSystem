using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmEmployee : Form
    {
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }
        public frmEmployee()
        {
            InitializeComponent();
        }

        

        private void btnRole_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmRole());
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmAccount());
        }
    }
}
