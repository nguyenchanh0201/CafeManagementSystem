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
    public partial class frmShift : Form
    {
        DateTime shiftStart;
        DateTime shiftEnd;
        BLLShift s = new BLLShift("", DateTime.Now, DateTime.Now, "");
        public static Boolean shiftStatus = false;
        public static string shiftID;


        public frmShift()
        {
            InitializeComponent();
            txtEmployee.Text = frmLogin.username;
            bHome.Enabled = true;
            bClose.Enabled = false;
            txtShiftID.Text = s.createShiftID();
            shiftID = txtShiftID.Text;
            lbDate.Text = DateTime.Now.ToString();


        }

        private void bHome_Click(object sender, EventArgs e)
        {
            txtOpentime.Text = DateTime.Now.ToString("HH:mm:ss");
            shiftStart = DateTime.Now;
            //Change the text of the button to "End Shift" and if the button is clicked again, it will end the shift
            txtOpentime.Focus();
            bHome.Enabled = false;
            bClose.Enabled = true;
            shiftStatus = true;
            shiftEnd = DateTime.Now;
            s.addShift(shiftStart, shiftEnd, frmLogin.username);
            


        }

        private void bClose_Click(object sender, EventArgs e)
        {
            txtClosetime.Text = DateTime.Now.ToString("HH:mm:ss");
            shiftEnd = DateTime.Now;
            //Change the text of the button to "Start Shift" and if the button is clicked again, it will start the shift
            txtClosetime.Focus();
            bHome.Click += new EventHandler(bHome_Click);
            //Update shiftEnd in that shift record
            s.updateShift(txtShiftID.Text, shiftEnd);

            //Add to shift table
            bHome.Enabled = true;
            bClose.Enabled = false;
            shiftStatus = false;
        }

        private void frmShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Create message 
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
