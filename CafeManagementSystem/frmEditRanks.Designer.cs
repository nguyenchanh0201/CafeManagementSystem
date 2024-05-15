namespace CafeManagementSystem
{
    partial class frmEditRanks
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grp2.SuspendLayout();
            this.grp1.SuspendLayout();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(6, 19);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(559, 251);
            this.grd.TabIndex = 0;
            this.grd.Click += new System.EventHandler(this.grd_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.label4);
            this.grp2.Controls.Add(this.txtDiscount);
            this.grp2.Controls.Add(this.label3);
            this.grp2.Controls.Add(this.txtName);
            this.grp2.Controls.Add(this.label2);
            this.grp2.Controls.Add(this.txtPoint);
            this.grp2.Controls.Add(this.label1);
            this.grp2.Controls.Add(this.txtID);
            this.grp2.Location = new System.Drawing.Point(18, 12);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(559, 141);
            this.grp2.TabIndex = 7;
            this.grp2.TabStop = false;
            this.grp2.Text = "Infomation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(320, 105);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(185, 20);
            this.txtDiscount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "GoalPoints";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(18, 105);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(180, 20);
            this.txtPoint.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 0;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.grd);
            this.grp1.Location = new System.Drawing.Point(12, 224);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(572, 276);
            this.grp1.TabIndex = 6;
            this.grp1.TabStop = false;
            this.grp1.Text = "List";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.Delete);
            this.grp3.Controls.Add(this.Update);
            this.grp3.Location = new System.Drawing.Point(18, 159);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(566, 59);
            this.grp3.TabIndex = 8;
            this.grp3.TabStop = false;
            this.grp3.Text = "Action";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(320, 19);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(157, 33);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(27, 19);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(157, 33);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // frmEditRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 524);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.grp3);
            this.Name = "frmEditRanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditRanks";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}