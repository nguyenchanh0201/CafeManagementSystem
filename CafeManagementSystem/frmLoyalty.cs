using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmLoyalty : Form
    {
        public frmLoyalty()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            AddControls(new frmRank());
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            AddControls(new frmCustomer());
        }
    }
}
