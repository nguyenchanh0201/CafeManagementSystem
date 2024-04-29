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

        }

        private void bSale_Click(object sender, EventArgs e)
        {
            
            AddControls(new frmSale());
        }

        private void bOrder_Click(object sender, EventArgs e)
        {

        }

        private void bMenu_Click(object sender, EventArgs e)
        {

        }

        private void bTrack_Click(object sender, EventArgs e)
        {

        }

        private void bEmployee_Click(object sender, EventArgs e)
        {

        }

        private void bPromotion_Click(object sender, EventArgs e)
        {

        }

        private void bLoyalty_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void bChange_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            AddControls(new frmHome());
            timer1.Start();
        }

        private void bMini_Click(object sender, EventArgs e)
        {
            //minimize the window
            this.WindowState = FormWindowState.Minimized;

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
