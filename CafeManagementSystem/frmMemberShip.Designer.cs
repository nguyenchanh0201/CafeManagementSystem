namespace CafeManagementSystem
{
    partial class frmMemberShip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCheck = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bCheck);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 126);
            this.panel1.TabIndex = 0;
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(199, 64);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(137, 42);
            this.bCheck.TabIndex = 25;
            this.bCheck.Text = "Check";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 38);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(478, 20);
            this.txtPhone.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter phoneNumber:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter phoneNum(*)";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(10, 108);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(290, 20);
            this.txtNewPhone.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 92);
            this.button1.TabIndex = 32;
            this.button1.Text = "Create and Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "male",
            "female"});
            this.listBox1.Location = new System.Drawing.Point(10, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 33;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.listBox1);
            this.grp.Controls.Add(this.button1);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.txtNewPhone);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.txtName);
            this.grp.Controls.Add(this.label1);
            this.grp.Location = new System.Drawing.Point(12, 152);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(483, 226);
            this.grp.TabIndex = 1;
            this.grp.TabStop = false;
            this.grp.Text = "Infomation";
            // 
            // frmMemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 395);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.panel1);
            this.Name = "frmMemberShip";
            this.Text = "frmMemberShip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grp;
    }
}