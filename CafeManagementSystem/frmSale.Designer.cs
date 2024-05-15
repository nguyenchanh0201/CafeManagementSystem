namespace CafeManagementSystem
{
    partial class frmSale
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
            this.bPlaceOrder = new System.Windows.Forms.Button();
            this.bTable = new System.Windows.Forms.Button();
            this.bCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bPlaceOrder
            // 
            this.bPlaceOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlaceOrder.Image = global::CafeManagementSystem.Properties.Resources.icons8_buy_50;
            this.bPlaceOrder.Location = new System.Drawing.Point(574, 420);
            this.bPlaceOrder.Name = "bPlaceOrder";
            this.bPlaceOrder.Size = new System.Drawing.Size(405, 134);
            this.bPlaceOrder.TabIndex = 16;
            this.bPlaceOrder.Text = "Place Order";
            this.bPlaceOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPlaceOrder.UseVisualStyleBackColor = true;
            this.bPlaceOrder.Click += new System.EventHandler(this.bPlaceOrder_Click);
            // 
            // bTable
            // 
            this.bTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTable.Image = global::CafeManagementSystem.Properties.Resources.icons8_table_50;
            this.bTable.Location = new System.Drawing.Point(1051, 420);
            this.bTable.Name = "bTable";
            this.bTable.Size = new System.Drawing.Size(405, 134);
            this.bTable.TabIndex = 15;
            this.bTable.Text = "Manage Table Cards";
            this.bTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bTable.UseVisualStyleBackColor = true;
            this.bTable.Click += new System.EventHandler(this.bTable_Click);
            // 
            // bCustomer
            // 
            this.bCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCustomer.Image = global::CafeManagementSystem.Properties.Resources.icons8_customer_60;
            this.bCustomer.Location = new System.Drawing.Point(88, 420);
            this.bCustomer.Name = "bCustomer";
            this.bCustomer.Size = new System.Drawing.Size(405, 134);
            this.bCustomer.TabIndex = 14;
            this.bCustomer.Text = "Manage Customer";
            this.bCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCustomer.UseVisualStyleBackColor = true;
            this.bCustomer.Click += new System.EventHandler(this.bCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bPlaceOrder);
            this.panel1.Controls.Add(this.bTable);
            this.panel1.Controls.Add(this.bCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 854);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1493, 227);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CafeManagementSystem.Properties.Resources.icons8_sale_801;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(637, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1493, 854);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCustomer;
        private System.Windows.Forms.Button bTable;
        private System.Windows.Forms.Button bPlaceOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}