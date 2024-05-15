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
    public partial class frmAddTable : Form
    {
        public frmAddTable()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            string tableName = txtName.Text;
            BLLTableCards bLLTableCards = new BLLTableCards("", "", "");
            BLLTableCards.insertTableCard(tableName);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
