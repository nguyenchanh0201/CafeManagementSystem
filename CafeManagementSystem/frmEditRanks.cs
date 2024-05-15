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
    public partial class frmEditRanks : Form
    {
        public frmEditRanks()
        {
            InitializeComponent();
            loadListRank();
            
        }
        void loadListRank()
        {
            grd.DataSource = BLLRank.select();
        } 
        

        private void grd_Click(object sender, EventArgs e)
        {
            txtID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtPoint.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtDiscount.Text = grd.CurrentRow.Cells[3].Value.ToString();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string rankID = txtID.Text;
            string rankName = txtName.Text;
            int goalPoints = Convert.ToInt32(txtPoint.Text);
            int discount = Convert.ToInt32(txtDiscount.Text);
            BLLRank.update(rankName, goalPoints, discount, rankID);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListRank();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string rankID = txtID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this rank?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLRank.delete(rankID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListRank();
        }
    }
}
