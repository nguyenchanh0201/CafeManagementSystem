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
    public partial class frmTableCard : Form
    {
        public frmTableCard()
        {
            InitializeComponent();
            showGRD();
        }
        void showGRD()
        {
            listTableCard.Items.Clear();
            List<TableCard> tableCards = BLLTableCards.getTableCards();
            foreach (TableCard tc in tableCards)
            {
                ListViewItem item = new ListViewItem(tc.getTableCardID().ToString());
                item.SubItems.Add(tc.getTableName());
                item.SubItems.Add(tc.getStatus());
                listTableCard.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditTableCard frmEditTableCard = new frmEditTableCard();
            frmEditTableCard.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTable frmAddTable = new frmAddTable();
            frmAddTable.ShowDialog();
        }
    }
}
