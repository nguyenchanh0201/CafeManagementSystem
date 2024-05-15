namespace CafeManagementSystem
{
    partial class frmMomo
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
            this.qrMomo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbReturn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.bCheckStatus = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrMomo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrMomo
            // 
            this.qrMomo.Location = new System.Drawing.Point(758, 166);
            this.qrMomo.Name = "qrMomo";
            this.qrMomo.Size = new System.Drawing.Size(465, 324);
            this.qrMomo.TabIndex = 0;
            this.qrMomo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbReturn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(758, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return";
            // 
            // lbReturn
            // 
            this.lbReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturn.Location = new System.Drawing.Point(143, 35);
            this.lbReturn.Name = "lbReturn";
            this.lbReturn.Size = new System.Drawing.Size(131, 38);
            this.lbReturn.TabIndex = 26;
            this.lbReturn.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReceived);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(437, 24);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(191, 29);
            this.txtReceived.TabIndex = 25;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(16, 35);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(198, 38);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "?";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Received : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Give this QR to Customer: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 40);
            this.label3.TabIndex = 25;
            this.label3.Text = "Order ID :";
            // 
            // lbOrderID
            // 
            this.lbOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderID.Location = new System.Drawing.Point(457, 166);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(199, 40);
            this.lbOrderID.TabIndex = 26;
            this.lbOrderID.Text = "?";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(316, 221);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(138, 86);
            this.bGenerate.TabIndex = 27;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // bCheckStatus
            // 
            this.bCheckStatus.Location = new System.Drawing.Point(493, 221);
            this.bCheckStatus.Name = "bCheckStatus";
            this.bCheckStatus.Size = new System.Drawing.Size(138, 86);
            this.bCheckStatus.TabIndex = 28;
            this.bCheckStatus.Text = "Check Pay status";
            this.bCheckStatus.UseVisualStyleBackColor = true;
            this.bCheckStatus.Click += new System.EventHandler(this.bCheckStatus_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(316, 342);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(191, 20);
            this.txtLink.TabIndex = 29;
            // 
            // frmMomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 585);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.bCheckStatus);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qrMomo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMomo";
            this.Text = "frmMomo";
            ((System.ComponentModel.ISupportInitialize)(this.qrMomo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrMomo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bCheckStatus;
        private System.Windows.Forms.TextBox txtLink;
    }
}