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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());

        }

        private void bShift_Click(object sender, EventArgs e)
        {
            bool frmShiftRunning = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmShift))
                {
                    // If frmShift is already running, set the flag and break the loop
                    frmShiftRunning = true;
                    MessageBox.Show("frmShift is already open!");
                    break;
                }
            }

            // If frmShift is not running, open a new instance
            if (!frmShiftRunning)
            {
                frmShift frmshift = new frmShift();
                frmshift.Show();
            }
           
        }

        private void bSale_Click(object sender, EventArgs e)
        {
            
            AddControls(new frmSale());
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            //if user is cashier , request password
            AddControls(new frmOrder());
            

        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            if (roleLabel.Text == "cashier")
            {
                MessageBox.Show("You dont have permission to see this");
            }
            else
            {
                AddControls(new frmMenu());
            }
        }

        private void bTrack_Click(object sender, EventArgs e)
        {
            if (roleLabel.Text == "cashier")
            {
                MessageBox.Show("You dont have permission to see this");
            }
            else
            {
                AddControls(new frmTrackRevenue());
            }
        }

        private void bEmployee_Click(object sender, EventArgs e)
        {
            if (roleLabel.Text == "cashier")
            {
                MessageBox.Show("You dont have permission to see this");
            }
            else
            {
                AddControls(new frmEmployee());
            }
            
        }

        private void bPromotion_Click(object sender, EventArgs e)
        {
            if (roleLabel.Text == "cashier")
            {
                MessageBox.Show("You dont have permission to see this");
            }
        }

        private void bLoyalty_Click(object sender, EventArgs e)
        {
            
            if (roleLabel.Text == "cashier")
            {
                MessageBox.Show("You dont have permission to see this");
            }
            else
            {
                AddControls(new frmLoyalty());
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            frmChangePwd frm = new frmChangePwd();
            frm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AddControls(new frmHome());
            timer1.Start();
            lbUser.Text = frmLogin.username;
            roleLabel.Text = frmLogin.role;
        }

        private void bMini_Click(object sender, EventArgs e)
        {
            //minimize the window
            this.WindowState = FormWindowState.Minimized;

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            
            //close the application
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void bLogout_Click(object sender, EventArgs e)
        {   //Check if the shift is closed or not
            if (frmShift.shiftStatus == true)
            {
                MessageBox.Show("Please close the shift before logging out");
                return;
            }
            //Log the user out 
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
