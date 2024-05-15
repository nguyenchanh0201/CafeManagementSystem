namespace CafeManagementSystem
{
    partial class frmTrackRevenue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.bShow2 = new System.Windows.Forms.Button();
            this.bShow3 = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.grd3 = new System.Windows.Forms.DataGridView();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grd4 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CafeManagementSystem.Properties.Resources.icons8_revenue_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(714, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 520);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 755);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select date";
            // 
            // grd1
            // 
            this.grd1.AllowDrop = true;
            this.grd1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(46, 198);
            this.grd1.Name = "grd1";
            this.grd1.Size = new System.Drawing.Size(1288, 105);
            this.grd1.TabIndex = 7;
            this.grd1.Click += new System.EventHandler(this.grd1_Click);
            // 
            // bShow2
            // 
            this.bShow2.Location = new System.Drawing.Point(426, 530);
            this.bShow2.Name = "bShow2";
            this.bShow2.Size = new System.Drawing.Size(75, 23);
            this.bShow2.TabIndex = 11;
            this.bShow2.Text = "Show";
            this.bShow2.UseVisualStyleBackColor = true;
            this.bShow2.Click += new System.EventHandler(this.bShow2_Click);
            // 
            // bShow3
            // 
            this.bShow3.Location = new System.Drawing.Point(426, 767);
            this.bShow3.Name = "bShow3";
            this.bShow3.Size = new System.Drawing.Size(75, 23);
            this.bShow3.TabIndex = 12;
            this.bShow3.Text = "Show";
            this.bShow3.UseVisualStyleBackColor = true;
            this.bShow3.Click += new System.EventHandler(this.bShow3_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(227, 530);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(175, 20);
            this.txtMonth.TabIndex = 13;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(227, 767);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(175, 20);
            this.txtDate.TabIndex = 14;
            // 
            // grd2
            // 
            this.grd2.AllowDrop = true;
            this.grd2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(523, 351);
            this.grd2.Name = "grd2";
            this.grd2.Size = new System.Drawing.Size(811, 144);
            this.grd2.TabIndex = 15;
            this.grd2.Click += new System.EventHandler(this.grd2_Click);
            // 
            // grd3
            // 
            this.grd3.AllowDrop = true;
            this.grd3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd3.Location = new System.Drawing.Point(523, 529);
            this.grd3.Name = "grd3";
            this.grd3.Size = new System.Drawing.Size(811, 186);
            this.grd3.TabIndex = 16;
            this.grd3.Click += new System.EventHandler(this.grd3_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(227, 362);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(175, 20);
            this.txtYear.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd4
            // 
            this.grd4.AllowDrop = true;
            this.grd4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd4.Location = new System.Drawing.Point(523, 755);
            this.grd4.Name = "grd4";
            this.grd4.Size = new System.Drawing.Size(811, 73);
            this.grd4.TabIndex = 19;
            // 
            // frmTrackRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 867);
            this.Controls.Add(this.grd4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.grd3);
            this.Controls.Add(this.grd2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.bShow3);
            this.Controls.Add(this.bShow2);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrackRevenue";
            this.Text = "frmTrackRevenue";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.Button bShow2;
        private System.Windows.Forms.Button bShow3;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DataGridView grd2;
        private System.Windows.Forms.DataGridView grd3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd4;
    }
}