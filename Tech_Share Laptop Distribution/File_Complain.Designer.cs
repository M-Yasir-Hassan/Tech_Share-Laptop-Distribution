namespace Tech_Share_Laptop_Distribution
{
    partial class File_Complain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmanagesales = new System.Windows.Forms.Button();
            this.btnstockdetails = new System.Windows.Forms.Button();
            this.btnviewrider = new System.Windows.Forms.Button();
            this.btnaddrider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplaint = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.typeCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tech_Share_Laptop_Distribution.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(1001, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnmanagesales);
            this.panel1.Controls.Add(this.btnstockdetails);
            this.panel1.Controls.Add(this.btnviewrider);
            this.panel1.Controls.Add(this.btnaddrider);
            this.panel1.Location = new System.Drawing.Point(33, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 113;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Teal;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnlogout.Location = new System.Drawing.Point(643, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(90, 40);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // btnmanagesales
            // 
            this.btnmanagesales.BackColor = System.Drawing.Color.Teal;
            this.btnmanagesales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmanagesales.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagesales.ForeColor = System.Drawing.Color.Transparent;
            this.btnmanagesales.Location = new System.Drawing.Point(547, 3);
            this.btnmanagesales.Name = "btnmanagesales";
            this.btnmanagesales.Size = new System.Drawing.Size(90, 40);
            this.btnmanagesales.TabIndex = 9;
            this.btnmanagesales.Text = "File Complain";
            this.btnmanagesales.UseVisualStyleBackColor = false;
            this.btnmanagesales.Click += new System.EventHandler(this.Btnmanagesales_Click);
            // 
            // btnstockdetails
            // 
            this.btnstockdetails.BackColor = System.Drawing.Color.Teal;
            this.btnstockdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockdetails.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockdetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnstockdetails.Location = new System.Drawing.Point(451, 3);
            this.btnstockdetails.Name = "btnstockdetails";
            this.btnstockdetails.Size = new System.Drawing.Size(90, 40);
            this.btnstockdetails.TabIndex = 6;
            this.btnstockdetails.Text = "Delivery Details";
            this.btnstockdetails.UseVisualStyleBackColor = false;
            this.btnstockdetails.Click += new System.EventHandler(this.Btnstockdetails_Click);
            // 
            // btnviewrider
            // 
            this.btnviewrider.BackColor = System.Drawing.Color.Teal;
            this.btnviewrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnviewrider.Location = new System.Drawing.Point(355, 3);
            this.btnviewrider.Name = "btnviewrider";
            this.btnviewrider.Size = new System.Drawing.Size(90, 40);
            this.btnviewrider.TabIndex = 5;
            this.btnviewrider.Text = "Manage Route";
            this.btnviewrider.UseVisualStyleBackColor = false;
            this.btnviewrider.Click += new System.EventHandler(this.Btnviewrider_Click);
            // 
            // btnaddrider
            // 
            this.btnaddrider.BackColor = System.Drawing.Color.Teal;
            this.btnaddrider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddrider.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrider.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddrider.Location = new System.Drawing.Point(259, 3);
            this.btnaddrider.Name = "btnaddrider";
            this.btnaddrider.Size = new System.Drawing.Size(90, 40);
            this.btnaddrider.TabIndex = 4;
            this.btnaddrider.Text = "View Shops";
            this.btnaddrider.UseVisualStyleBackColor = false;
            this.btnaddrider.Click += new System.EventHandler(this.Btnaddrider_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 112;
            this.label1.Text = "Rider DashBoard";
            // 
            // txtComplaint
            // 
            this.txtComplaint.AnimateReadOnly = false;
            this.txtComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComplaint.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComplaint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplaint.Depth = 0;
            this.txtComplaint.HideSelection = true;
            this.txtComplaint.Hint = "Type Your Complaint Here .....";
            this.txtComplaint.Location = new System.Drawing.Point(61, 230);
            this.txtComplaint.MaxLength = 32767;
            this.txtComplaint.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.PasswordChar = '\0';
            this.txtComplaint.ReadOnly = false;
            this.txtComplaint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplaint.SelectedText = "";
            this.txtComplaint.SelectionLength = 0;
            this.txtComplaint.SelectionStart = 0;
            this.txtComplaint.ShortcutsEnabled = true;
            this.txtComplaint.Size = new System.Drawing.Size(871, 171);
            this.txtComplaint.TabIndex = 114;
            this.txtComplaint.TabStop = false;
            this.txtComplaint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComplaint.UseSystemPasswordChar = false;
            this.txtComplaint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaterialMultiLineTextBox21_KeyPress);
            // 
            // typeCombo
            // 
            this.typeCombo.AutoResize = false;
            this.typeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeCombo.Depth = 0;
            this.typeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeCombo.DropDownHeight = 174;
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.DropDownWidth = 121;
            this.typeCombo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Hint = "Select Your Type Of Complaint";
            this.typeCombo.IntegralHeight = false;
            this.typeCombo.ItemHeight = 43;
            this.typeCombo.Items.AddRange(new object[] {
            "Management",
            "Payment Problem",
            "Software Improvement",
            "Misconducting",
            "Others"});
            this.typeCombo.Location = new System.Drawing.Point(61, 160);
            this.typeCombo.MaxDropDownItems = 4;
            this.typeCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(321, 49);
            this.typeCombo.StartIndex = 0;
            this.typeCombo.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 116;
            this.label3.Text = "File Complaints";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(787, 423);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "Submit >";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // File_Complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1036, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.txtComplaint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "File_Complain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File_Complain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmanagesales;
        private System.Windows.Forms.Button btnstockdetails;
        private System.Windows.Forms.Button btnviewrider;
        private System.Windows.Forms.Button btnaddrider;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtComplaint;
        private MaterialSkin.Controls.MaterialComboBox typeCombo;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}