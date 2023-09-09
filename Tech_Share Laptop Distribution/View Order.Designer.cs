namespace Tech_Share_Laptop_Distribution
{
    partial class View_Order
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
            this.label3 = new System.Windows.Forms.Label();
            this.gproductdeletegrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddshop = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnstockdetails = new System.Windows.Forms.Button();
            this.btnviewrider = new System.Windows.Forms.Button();
            this.btnaddrider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gproductdeletegrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(2, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = ">> View Orders";
            // 
            // gproductdeletegrid
            // 
            this.gproductdeletegrid.BackgroundColor = System.Drawing.Color.Teal;
            this.gproductdeletegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gproductdeletegrid.GridColor = System.Drawing.Color.Teal;
            this.gproductdeletegrid.Location = new System.Drawing.Point(79, 145);
            this.gproductdeletegrid.Name = "gproductdeletegrid";
            this.gproductdeletegrid.ReadOnly = true;
            this.gproductdeletegrid.Size = new System.Drawing.Size(831, 330);
            this.gproductdeletegrid.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(367, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Employee DashBoard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnaddproduct);
            this.panel1.Controls.Add(this.btnplaceorder);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnaddshop);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btnstockdetails);
            this.panel1.Controls.Add(this.btnviewrider);
            this.panel1.Controls.Add(this.btnaddrider);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 35;
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.BackColor = System.Drawing.Color.Teal;
            this.btnaddproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddproduct.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddproduct.Location = new System.Drawing.Point(29, 4);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(100, 40);
            this.btnaddproduct.TabIndex = 14;
            this.btnaddproduct.Text = "Add Product";
            this.btnaddproduct.UseVisualStyleBackColor = false;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BackColor = System.Drawing.Color.Teal;
            this.btnplaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnplaceorder.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaceorder.ForeColor = System.Drawing.Color.Transparent;
            this.btnplaceorder.Location = new System.Drawing.Point(134, 5);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(100, 40);
            this.btnplaceorder.TabIndex = 12;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = false;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Teal;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnlogout.Location = new System.Drawing.Point(770, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(100, 40);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnaddshop
            // 
            this.btnaddshop.BackColor = System.Drawing.Color.Teal;
            this.btnaddshop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddshop.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddshop.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddshop.Location = new System.Drawing.Point(664, 5);
            this.btnaddshop.Name = "btnaddshop";
            this.btnaddshop.Size = new System.Drawing.Size(100, 40);
            this.btnaddshop.TabIndex = 9;
            this.btnaddshop.Text = "Add Shop";
            this.btnaddshop.UseVisualStyleBackColor = false;
            this.btnaddshop.Click += new System.EventHandler(this.btnaddshop_Click);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.Teal;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorders.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.Transparent;
            this.btnorders.Location = new System.Drawing.Point(558, 5);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(100, 40);
            this.btnorders.TabIndex = 8;
            this.btnorders.Text = "Orders";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnstockdetails
            // 
            this.btnstockdetails.BackColor = System.Drawing.Color.Teal;
            this.btnstockdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockdetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockdetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnstockdetails.Location = new System.Drawing.Point(452, 5);
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
            this.btnviewrider.Location = new System.Drawing.Point(346, 5);
            this.btnviewrider.Name = "btnviewrider";
            this.btnviewrider.Size = new System.Drawing.Size(100, 40);
            this.btnviewrider.TabIndex = 5;
            this.btnviewrider.Text = "View Rider";
            this.btnviewrider.UseVisualStyleBackColor = false;
            this.btnviewrider.Click += new System.EventHandler(this.btnviewrider_Click);
            // 
            // btnaddrider
            // 
            this.btnaddrider.BackColor = System.Drawing.Color.Teal;
            this.btnaddrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddrider.Location = new System.Drawing.Point(240, 5);
            this.btnaddrider.Name = "btnaddrider";
            this.btnaddrider.Size = new System.Drawing.Size(100, 40);
            this.btnaddrider.TabIndex = 4;
            this.btnaddrider.Text = "Add Rider";
            this.btnaddrider.UseVisualStyleBackColor = false;
            this.btnaddrider.Click += new System.EventHandler(this.btnaddrider_Click_1);
            // 
            // View_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gproductdeletegrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Order";
            this.Load += new System.EventHandler(this.View_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gproductdeletegrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gproductdeletegrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddshop;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnstockdetails;
        private System.Windows.Forms.Button btnviewrider;
        private System.Windows.Forms.Button btnaddrider;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.Button btnaddproduct;
    }
}