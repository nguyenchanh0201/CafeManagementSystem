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
    public partial class frmEditTableCard : Form
    {
        public frmEditTableCard()
        {
            InitializeComponent();
            loadListTable();
            

        }
        void loadListTable()
        {
            grd.DataSource = BLLTableCards.select();
        }
        

        private void Update_Click(object sender, EventArgs e)
        {
            String  id = txtID.Text;
            String name = txtName.Text;
            String status = txtStatus.Text;
            BLLTableCards.updateTableCard(id,name,status);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListTable();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this table?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLTableCards.deleteTableCard(id);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListTable();
        }

        private void grd_Click(object sender, EventArgs e)
        {
            txtID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtStatus.Text = grd.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
