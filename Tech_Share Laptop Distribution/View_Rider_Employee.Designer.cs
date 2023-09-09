namespace Tech_Share_Laptop_Distribution
{
    partial class View_Rider_Employee
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddshop = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnstockdetails = new System.Windows.Forms.Button();
            this.btnviewrider = new System.Windows.Forms.Button();
            this.btnaddrider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewridersemployee = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewridersemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnaddshop);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btnstockdetails);
            this.panel1.Controls.Add(this.btnviewrider);
            this.panel1.Controls.Add(this.btnaddrider);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 35;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Teal;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnlogout.Location = new System.Drawing.Point(646, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(100, 40);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnaddshop
            // 
            this.btnaddshop.BackColor = System.Drawing.Color.Teal;
            this.btnaddshop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddshop.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddshop.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddshop.Location = new System.Drawing.Point(540, 3);
            this.btnaddshop.Name = "btnaddshop";
            this.btnaddshop.Size = new System.Drawing.Size(100, 40);
            this.btnaddshop.TabIndex = 9;
            this.btnaddshop.Text = "Add Shop";
            this.btnaddshop.UseVisualStyleBackColor = false;
            this.btnaddshop.Click += new System.EventHandler(this.btnaddshop_Click_1);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.Teal;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorders.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.Transparent;
            this.btnorders.Location = new System.Drawing.Point(434, 3);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(100, 40);
            this.btnorders.TabIndex = 8;
            this.btnorders.Text = "Orders";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click_1);
            // 
            // btnstockdetails
            // 
            this.btnstockdetails.BackColor = System.Drawing.Color.Teal;
            this.btnstockdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockdetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockdetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnstockdetails.Location = new System.Drawing.Point(328, 3);
            this.btnstockdetails.Name = "btnstockdetails";
            this.btnstockdetails.Size = new System.Drawing.Size(100, 40);
            this.btnstockdetails.TabIndex = 6;
            this.btnstockdetails.Text = "Stock Details";
            this.btnstockdetails.UseVisualStyleBackColor = false;
            this.btnstockdetails.Click += new System.EventHandler(this.btnstockdetails_Click);
            // 
            // btnviewrider
            // 
            this.btnviewrider.BackColor = System.Drawing.Color.Teal;
            this.btnviewrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnviewrider.Location = new System.Drawing.Point(222, 3);
            this.btnviewrider.Name = "btnviewrider";
            this.btnviewrider.Size = new System.Drawing.Size(100, 40);
            this.btnviewrider.TabIndex = 5;
            this.btnviewrider.Text = "View Rider";
            this.btnviewrider.UseVisualStyleBackColor = false;
            this.btnviewrider.Click += new System.EventHandler(this.btnviewrider_Click_1);
            // 
            // btnaddrider
            // 
            this.btnaddrider.BackColor = System.Drawing.Color.Teal;
            this.btnaddrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddrider.Location = new System.Drawing.Point(116, 3);
            this.btnaddrider.Name = "btnaddrider";
            this.btnaddrider.Size = new System.Drawing.Size(100, 40);
            this.btnaddrider.TabIndex = 4;
            this.btnaddrider.Text = "Add Rider";
            this.btnaddrider.UseVisualStyleBackColor = false;
            this.btnaddrider.Click += new System.EventHandler(this.btnaddrider_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(371, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Employee DashBoard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = ">> View Riders";
            // 
            // gridviewridersemployee
            // 
            this.gridviewridersemployee.BackgroundColor = System.Drawing.Color.Teal;
            this.gridviewridersemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewridersemployee.Location = new System.Drawing.Point(225, 152);
            this.gridviewridersemployee.Name = "gridviewridersemployee";
            this.gridviewridersemployee.ReadOnly = true;
            this.gridviewridersemployee.Size = new System.Drawing.Size(757, 405);
            this.gridviewridersemployee.TabIndex = 37;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Teal;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(61, 315);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 40);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // View_Rider_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.gridviewridersemployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Rider_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Rider_Employee";
            this.Load += new System.EventHandler(this.View_Rider_Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewridersemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddshop;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnstockdetails;
        private System.Windows.Forms.Button btnviewrider;
        private System.Windows.Forms.Button btnaddrider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewridersemployee;
        private System.Windows.Forms.Button btndelete;
    }
}