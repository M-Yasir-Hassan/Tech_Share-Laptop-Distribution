namespace Tech_Share_Laptop_Distribution
{
    partial class ForgetPWD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPWD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Role = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 520);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "CENTER";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(-2, 390);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(369, 38);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Tech Share";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Laptop Distribution";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(5, 260);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(154, 138);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(806, 400);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(76, 36);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset >";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(671, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reset Password";
            // 
            // txtComNewPass
            // 
            this.txtComNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComNewPass.AnimateReadOnly = false;
            this.txtComNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComNewPass.Depth = 0;
            this.txtComNewPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComNewPass.Hint = "Confirm new password";
            this.txtComNewPass.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtComNewPass.LeadingIcon")));
            this.txtComNewPass.Location = new System.Drawing.Point(494, 334);
            this.txtComNewPass.MaxLength = 50;
            this.txtComNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComNewPass.Multiline = false;
            this.txtComNewPass.Name = "txtComNewPass";
            this.txtComNewPass.Size = new System.Drawing.Size(439, 36);
            this.txtComNewPass.TabIndex = 10;
            this.txtComNewPass.Text = "";
            this.txtComNewPass.TrailingIcon = null;
            this.txtComNewPass.UseTallSize = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.AnimateReadOnly = false;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Depth = 0;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPass.Hint = "New password";
            this.txtNewPass.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtNewPass.LeadingIcon")));
            this.txtNewPass.Location = new System.Drawing.Point(494, 280);
            this.txtNewPass.MaxLength = 50;
            this.txtNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Password = true;
            this.txtNewPass.Size = new System.Drawing.Size(439, 36);
            this.txtNewPass.TabIndex = 9;
            this.txtNewPass.Text = "";
            this.txtNewPass.TrailingIcon = global::Tech_Share_Laptop_Distribution.Properties.Resources.hide_20px;
            this.txtNewPass.UseTallSize = false;
            this.txtNewPass.TrailingIconClick += new System.EventHandler(this.txtPassword_TrailingIconClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email address";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(493, 159);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 36);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tech_Share_Laptop_Distribution.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(981, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Role
            // 
            this.Role.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Manager",
            "Rider"});
            this.Role.AutoResize = false;
            this.Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Role.Depth = 0;
            this.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Role.DropDownHeight = 131;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.DropDownWidth = 121;
            this.Role.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Role.FormattingEnabled = true;
            this.Role.Hint = "Select Role";
            this.Role.IntegralHeight = false;
            this.Role.ItemHeight = 43;
            this.Role.Location = new System.Drawing.Point(493, 210);
            this.Role.MaxDropDownItems = 3;
            this.Role.MouseState = MaterialSkin.MouseState.OUT;
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(440, 49);
            this.Role.StartIndex = 0;
            this.Role.TabIndex = 16;
            this.Role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(537, 400);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Text = "Back <";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // ForgetPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1026, 520);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtEmail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1026, 520);
            this.MinimumSize = new System.Drawing.Size(1026, 520);
            this.Name = "ForgetPWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgetPWD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtComNewPass;
        private MaterialSkin.Controls.MaterialTextBox txtNewPass;
        public MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox Role;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}