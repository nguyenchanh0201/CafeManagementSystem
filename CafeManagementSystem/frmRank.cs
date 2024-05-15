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
    public partial class frmRank : Form
    {
        public frmRank()
        {
            InitializeComponent();
            showGRD();
        }
        void showGRD()
        {
            listRank.Items.Clear();
            List<Rank> ranks = BLLRank.getRank();
            foreach (Rank r in ranks)
            {
                ListViewItem item = new ListViewItem(r.getRankID().ToString());
                item.SubItems.Add(r.getRankName());
                item.SubItems.Add(r.getGoalPoints().ToString());
                item.SubItems.Add(r.getDiscount().ToString());
                listRank.Items.Add(item);
            }
        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddRanks frmAddRanks = new frmAddRanks();
            frmAddRanks.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditRanks frmEditRanks = new frmEditRanks();
            frmEditRanks.ShowDialog();
        }
    }
}
