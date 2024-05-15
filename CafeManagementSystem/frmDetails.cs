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
    public partial class frmDetails : Form
    {
        public static int quantity = 0;
        public frmDetails()
        {
            InitializeComponent();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(quantityBox.Value);
            //Close the form
            this.Close();
        }
    }
}
