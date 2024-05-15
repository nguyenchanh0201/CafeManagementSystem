namespace CafeManagementSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bMini = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bLogout = new System.Windows.Forms.Button();
            this.bLoyalty = new System.Windows.Forms.Button();
            this.bEmployee = new System.Windows.Forms.Button();
            this.bTrack = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.bOrder = new System.Windows.Forms.Button();
            this.bSale = new System.Windows.Forms.Button();
            this.bShift = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bLogout);
            this.panel1.Controls.Add(this.bLoyalty);
            this.panel1.Controls.Add(this.bEmployee);
            this.panel1.Controls.Add(this.bTrack);
            this.panel1.Controls.Add(this.bMenu);
            this.panel1.Controls.Add(this.bOrder);
            this.panel1.Controls.Add(this.bSale);
            this.panel1.Controls.Add(this.bShift);
            this.panel1.Controls.Add(this.bHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 1100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cafe Management System";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(295, 194);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(998, 906);
            this.CenterPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome, ";
            // 
            // bChange
            // 
            this.bChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChange.Location = new System.Drawing.Point(45, 117);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(133, 61);
            this.bChange.TabIndex = 14;
            this.bChange.Text = "Change Password";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // lbUser
            // 
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(353, 46);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(161, 39);
            this.lbUser.TabIndex = 15;
            this.lbUser.Text = "user";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.roleLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Controls.Add(this.bChange);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 194);
            this.panel2.TabIndex = 1;
            // 
            // roleLabel
            // 
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(323, 104);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(233, 39);
            this.roleLabel.TabIndex = 20;
            this.roleLabel.Text = "role";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "Role : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bClose);
            this.panel4.Controls.Add(this.bMini);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(915, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 194);
            this.panel4.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::CafeManagementSystem.Properties.Resources.icons8_clock_1001;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(766, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 131);
            this.label3.TabIndex = 19;
            this.label3.Text = "                           00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Red;
            this.bClose.BackgroundImage = global::CafeManagementSystem.Properties.Resources.close;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bClose.Location = new System.Drawing.Point(42, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(41, 36);
            this.bClose.TabIndex = 17;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bMini
            // 
            this.bMini.BackColor = System.Drawing.SystemColors.Highlight;
            this.bMini.BackgroundImage = global::CafeManagementSystem.Properties.Resources.minimize;
            this.bMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMini.Location = new System.Drawing.Point(3, 0);
            this.bMini.Name = "bMini";
            this.bMini.Size = new System.Drawing.Size(43, 36);
            this.bMini.TabIndex = 16;
            this.bMini.UseVisualStyleBackColor = false;
            this.bMini.Click += new System.EventHandler(this.bMini_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CafeManagementSystem.Properties.Resources.Sample_User_Icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(34, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 93);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeManagementSystem.Properties.Resources.icons8_admin_100;
            this.pictureBox3.Location = new System.Drawing.Point(103, 506);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 102);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagementSystem.Properties.Resources.icons8_coffee_shop_64;
            this.pictureBox1.Location = new System.Drawing.Point(120, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 72);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bLogout
            // 
            this.bLogout.Image = global::CafeManagementSystem.Properties.Resources.icons8_log_out_24;
            this.bLogout.Location = new System.Drawing.Point(93, 965);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(110, 77);
            this.bLogout.TabIndex = 9;
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bLoyalty
            // 
            this.bLoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoyalty.Image = global::CafeManagementSystem.Properties.Resources.icons8_loyalty_64;
            this.bLoyalty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLoyalty.Location = new System.Drawing.Point(0, 849);
            this.bLoyalty.Name = "bLoyalty";
            this.bLoyalty.Size = new System.Drawing.Size(295, 83);
            this.bLoyalty.TabIndex = 8;
            this.bLoyalty.Text = "        Manage         Loyalty";
            this.bLoyalty.UseVisualStyleBackColor = true;
            this.bLoyalty.Click += new System.EventHandler(this.bLoyalty_Click);
            // 
            // bEmployee
            // 
            this.bEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmployee.Image = global::CafeManagementSystem.Properties.Resources.icons8_employee_80;
            this.bEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEmployee.Location = new System.Drawing.Point(0, 771);
            this.bEmployee.Name = "bEmployee";
            this.bEmployee.Size = new System.Drawing.Size(295, 83);
            this.bEmployee.TabIndex = 6;
            this.bEmployee.Text = "           Manage Employee";
            this.bEmployee.UseVisualStyleBackColor = true;
            this.bEmployee.Click += new System.EventHandler(this.bEmployee_Click);
            // 
            // bTrack
            // 
            this.bTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTrack.Image = global::CafeManagementSystem.Properties.Resources.icons8_revenue_64;
            this.bTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTrack.Location = new System.Drawing.Point(0, 692);
            this.bTrack.Name = "bTrack";
            this.bTrack.Size = new System.Drawing.Size(295, 83);
            this.bTrack.TabIndex = 5;
            this.bTrack.Text = "          Track Report";
            this.bTrack.UseVisualStyleBackColor = true;
            this.bTrack.Click += new System.EventHandler(this.bTrack_Click);
            // 
            // bMenu
            // 
            this.bMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenu.Image = global::CafeManagementSystem.Properties.Resources.icons8_menu_50;
            this.bMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMenu.Location = new System.Drawing.Point(0, 614);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(295, 83);
            this.bMenu.TabIndex = 4;
            this.bMenu.Text = "           Manage Menu";
            this.bMenu.UseVisualStyleBackColor = true;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // bOrder
            // 
            this.bOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrder.Image = global::CafeManagementSystem.Properties.Resources.icons8_order_64;
            this.bOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOrder.Location = new System.Drawing.Point(0, 420);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(295, 83);
            this.bOrder.TabIndex = 3;
            this.bOrder.Text = "           Manage Order";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // bSale
            // 
            this.bSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSale.Image = global::CafeManagementSystem.Properties.Resources.icons8_sale_80;
            this.bSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSale.Location = new System.Drawing.Point(0, 342);
            this.bSale.Name = "bSale";
            this.bSale.Size = new System.Drawing.Size(295, 83);
            this.bSale.TabIndex = 2;
            this.bSale.Text = "Sale";
            this.bSale.UseVisualStyleBackColor = true;
            this.bSale.Click += new System.EventHandler(this.bSale_Click);
            // 
            // bShift
            // 
            this.bShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShift.Image = global::CafeManagementSystem.Properties.Resources.icons8_shift_64;
            this.bShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bShift.Location = new System.Drawing.Point(0, 266);
            this.bShift.Name = "bShift";
            this.bShift.Size = new System.Drawing.Size(295, 83);
            this.bShift.TabIndex = 1;
            this.bShift.Text = "           Manage Shift";
            this.bShift.UseVisualStyleBackColor = true;
            this.bShift.Click += new System.EventHandler(this.bShift_Click);
            // 
            // bHome
            // 
            this.bHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHome.Image = global::CafeManagementSystem.Properties.Resources.icons8_home_50;
            this.bHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHome.Location = new System.Drawing.Point(0, 189);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(295, 83);
            this.bHome.TabIndex = 0;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 1100);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "``";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Button bSale;
        private System.Windows.Forms.Button bShift;
        private System.Windows.Forms.Button bEmployee;
        private System.Windows.Forms.Button bTrack;
        private System.Windows.Forms.Button bLoyalty;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bMini;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}