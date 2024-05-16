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
    public partial class frmAddRanks : Form
    {
        public frmAddRanks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string rankName = txtName.Text;
            int goalPoints = Convert.ToInt32(txtPoint.Text);
            int discount = Convert.ToInt32(txtDiscount.Text);
            
            BLLRank.insert(rankName, goalPoints, discount);
            MessageBox.Show("Rank Added Successfully, reload to see new contents");
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
