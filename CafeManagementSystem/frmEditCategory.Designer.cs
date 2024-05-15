namespace CafeManagementSystem
{
    partial class frmEditCategory
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grp2.SuspendLayout();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.grd);
            this.grp1.Location = new System.Drawing.Point(12, 187);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(456, 215);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            this.grp1.Text = "List";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(7, 19);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(443, 190);
            this.grd.TabIndex = 0;
            this.grd.Click += new System.EventHandler(this.grd_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.label3);
            this.grp2.Controls.Add(this.txtName);
            this.grp2.Controls.Add(this.label1);
            this.grp2.Controls.Add(this.txtID);
            this.grp2.Location = new System.Drawing.Point(25, 23);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(443, 81);
            this.grp2.TabIndex = 4;
            this.grp2.TabStop = false;
            this.grp2.Text = "Infomation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CateName";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CateID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 20);
            this.txtID.TabIndex = 0;
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.Delete);
            this.grp3.Controls.Add(this.Update);
            this.grp3.Location = new System.Drawing.Point(25, 110);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(443, 59);
            this.grp3.TabIndex = 5;
            this.grp3.TabStop = false;
            this.grp3.Text = "Action";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(252, 19);
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
            // frmEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 416);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp3);
            this.Name = "frmEditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditCategory";
            this.grp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
    }
}