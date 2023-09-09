namespace Tech_Share_Laptop_Distribution
{
    partial class View_Rider
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
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btncompaints = new System.Windows.Forms.Button();
            this.btnmanagesales = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnstockdetails = new System.Windows.Forms.Button();
            this.btnviewrider = new System.Windows.Forms.Button();
            this.btnaddrider = new System.Windows.Forms.Button();
            this.btnviewemployee = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RidersGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RidersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(788, 469);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(583, 469);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 107;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 106;
            this.label2.Text = ">> View Rider";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btncompaints);
            this.panel1.Controls.Add(this.btnmanagesales);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btnstockdetails);
            this.panel1.Controls.Add(this.btnviewrider);
            this.panel1.Controls.Add(this.btnaddrider);
            this.panel1.Controls.Add(this.btnviewemployee);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Location = new System.Drawing.Point(36, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 105;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Teal;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnlogout.Location = new System.Drawing.Point(871, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(90, 40);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // btncompaints
            // 
            this.btncompaints.BackColor = System.Drawing.Color.Teal;
            this.btncompaints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncompaints.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompaints.ForeColor = System.Drawing.Color.Transparent;
            this.btncompaints.Location = new System.Drawing.Point(771, 3);
            this.btncompaints.Name = "btncompaints";
            this.btncompaints.Size = new System.Drawing.Size(94, 40);
            this.btncompaints.TabIndex = 10;
            this.btncompaints.Text = "About";
            this.btncompaints.UseVisualStyleBackColor = false;
            this.btncompaints.Click += new System.EventHandler(this.Btncompaints_Click);
            // 
            // btnmanagesales
            // 
            this.btnmanagesales.BackColor = System.Drawing.Color.Teal;
            this.btnmanagesales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmanagesales.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagesales.ForeColor = System.Drawing.Color.Transparent;
            this.btnmanagesales.Location = new System.Drawing.Point(675, 3);
            this.btnmanagesales.Name = "btnmanagesales";
            this.btnmanagesales.Size = new System.Drawing.Size(90, 40);
            this.btnmanagesales.TabIndex = 9;
            this.btnmanagesales.Text = "Complaints";
            this.btnmanagesales.UseVisualStyleBackColor = false;
            this.btnmanagesales.Click += new System.EventHandler(this.Btnmanagesales_Click);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.Teal;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorders.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.Transparent;
            this.btnorders.Location = new System.Drawing.Point(579, 3);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(90, 40);
            this.btnorders.TabIndex = 8;
            this.btnorders.Text = "Orders";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.Btnorders_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.Teal;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreports.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.Color.Transparent;
            this.btnreports.Location = new System.Drawing.Point(483, 3);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(90, 40);
            this.btnreports.TabIndex = 7;
            this.btnreports.Text = "Stock";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.Btnreports_Click);
            // 
            // btnstockdetails
            // 
            this.btnstockdetails.BackColor = System.Drawing.Color.Teal;
            this.btnstockdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockdetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockdetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnstockdetails.Location = new System.Drawing.Point(387, 3);
            this.btnstockdetails.Name = "btnstockdetails";
            this.btnstockdetails.Size = new System.Drawing.Size(90, 40);
            this.btnstockdetails.TabIndex = 6;
            this.btnstockdetails.Text = "View Rider";
            this.btnstockdetails.UseVisualStyleBackColor = false;
            this.btnstockdetails.Click += new System.EventHandler(this.Btnstockdetails_Click);
            // 
            // btnviewrider
            // 
            this.btnviewrider.BackColor = System.Drawing.Color.Teal;
            this.btnviewrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnviewrider.Location = new System.Drawing.Point(291, 3);
            this.btnviewrider.Name = "btnviewrider";
            this.btnviewrider.Size = new System.Drawing.Size(90, 40);
            this.btnviewrider.TabIndex = 5;
            this.btnviewrider.Text = "Add Rider";
            this.btnviewrider.UseVisualStyleBackColor = false;
            this.btnviewrider.Click += new System.EventHandler(this.Btnviewrider_Click);
            // 
            // btnaddrider
            // 
            this.btnaddrider.BackColor = System.Drawing.Color.Teal;
            this.btnaddrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddrider.Location = new System.Drawing.Point(195, 3);
            this.btnaddrider.Name = "btnaddrider";
            this.btnaddrider.Size = new System.Drawing.Size(90, 40);
            this.btnaddrider.TabIndex = 4;
            this.btnaddrider.Text = "View EMpoyee";
            this.btnaddrider.UseVisualStyleBackColor = false;
            this.btnaddrider.Click += new System.EventHandler(this.Btnaddrider_Click);
            // 
            // btnviewemployee
            // 
            this.btnviewemployee.BackColor = System.Drawing.Color.Teal;
            this.btnviewemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewemployee.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewemployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnviewemployee.Location = new System.Drawing.Point(99, 3);
            this.btnviewemployee.Name = "btnviewemployee";
            this.btnviewemployee.Size = new System.Drawing.Size(90, 40);
            this.btnviewemployee.TabIndex = 3;
            this.btnviewemployee.Text = "Add Employee";
            this.btnviewemployee.UseVisualStyleBackColor = false;
            this.btnviewemployee.Click += new System.EventHandler(this.Btnviewemployee_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Teal;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndashboard.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btndashboard.Location = new System.Drawing.Point(3, 3);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(90, 40);
            this.btndashboard.TabIndex = 2;
            this.btndashboard.Text = "DashBoard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.Btndashboard_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 104;
            this.label1.Text = "Manager DashBoard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tech_Share_Laptop_Distribution.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(1020, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // RidersGrid
            // 
            this.RidersGrid.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.RidersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RidersGrid.Location = new System.Drawing.Point(73, 142);
            this.RidersGrid.Name = "RidersGrid";
            this.RidersGrid.Size = new System.Drawing.Size(843, 307);
            this.RidersGrid.TabIndex = 110;
            // 
            // View_Rider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.RidersGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1052, 529);
            this.MinimumSize = new System.Drawing.Size(1052, 529);
            this.Name = "View_Rider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Rider";
            this.Load += new System.EventHandler(this.View_Rider_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RidersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btncompaints;
        private System.Windows.Forms.Button btnmanagesales;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnstockdetails;
        private System.Windows.Forms.Button btnviewrider;
        private System.Windows.Forms.Button btnaddrider;
        private System.Windows.Forms.Button btnviewemployee;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView RidersGrid;
    }
}