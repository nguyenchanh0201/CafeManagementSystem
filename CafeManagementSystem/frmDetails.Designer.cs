namespace CafeManagementSystem
{
    partial class frmDetails
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
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.bConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(17, 38);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(45, 20);
            this.quantityBox.TabIndex = 0;
            this.quantityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantity";
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(123, 25);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 43);
            this.bConfirm.TabIndex = 33;
            this.bConfirm.Text = "Confirm";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 83);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.quantityBox);
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetails";
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bConfirm;
    }
}