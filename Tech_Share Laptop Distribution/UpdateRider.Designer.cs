namespace Tech_Share_Laptop_Distribution
{
    partial class UpdateRider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRider));
            this.NumberError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.cnicError = new System.Windows.Forms.Label();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSalary = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCnic = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox();
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
            this.btnaddemployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberError
            // 
            this.NumberError.AutoSize = true;
            this.NumberError.ForeColor = System.Drawing.Color.Red;
            this.NumberError.Location = new System.Drawing.Point(610, 295);
            this.NumberError.Name = "NumberError";
            this.NumberError.Size = new System.Drawing.Size(0, 13);
            this.NumberError.TabIndex = 131;
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(136, 301);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(0, 13);
            this.emailError.TabIndex = 130;
            // 
            // cnicError
            // 
            this.cnicError.AutoSize = true;
            this.cnicError.ForeColor = System.Drawing.Color.Red;
            this.cnicError.Location = new System.Drawing.Point(610, 231);
            this.cnicError.Name = "cnicError";
            this.cnicError.Size = new System.Drawing.Size(0, 13);
            this.cnicError.TabIndex = 129;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(819, 405);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.TabIndex = 128;
            this.btnUpdate.Text = "Update >";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(599, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tech_Share_Laptop_Distribution.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(136, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "Name can\'t be updated";
            // 
            // ComboBoxSalary
            // 
            this.ComboBoxSalary.AutoResize = false;
            this.ComboBoxSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSalary.Depth = 0;
            this.ComboBoxSalary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSalary.DropDownHeight = 174;
            this.ComboBoxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSalary.DropDownWidth = 121;
            this.ComboBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSalary.FormattingEnabled = true;
            this.ComboBoxSalary.Hint = "Salary";
            this.ComboBoxSalary.IntegralHeight = false;
            this.ComboBoxSalary.ItemHeight = 43;
            this.ComboBoxSalary.Items.AddRange(new object[] {
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "85000",
            "90000"});
            this.ComboBoxSalary.Location = new System.Drawing.Point(574, 317);
            this.ComboBoxSalary.MaxDropDownItems = 4;
            this.ComboBoxSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSalary.Name = "ComboBoxSalary";
            this.ComboBoxSalary.Size = new System.Drawing.Size(312, 49);
            this.ComboBoxSalary.StartIndex = 0;
            this.ComboBoxSalary.TabIndex = 124;
            // 
            // txtCnic
            // 
            this.txtCnic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCnic.AnimateReadOnly = false;
            this.txtCnic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnic.Depth = 0;
            this.txtCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCnic.Hint = "CNIC";
            this.txtCnic.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtCnic.LeadingIcon")));
            this.txtCnic.Location = new System.Drawing.Point(574, 183);
            this.txtCnic.MaxLength = 13;
            this.txtCnic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCnic.Multiline = false;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(312, 36);
            this.txtCnic.TabIndex = 122;
            this.txtCnic.Text = "";
            this.txtCnic.TrailingIcon = null;
            this.txtCnic.UseTallSize = false;
            this.txtCnic.TextChanged += new System.EventHandler(this.TxtCnic_TextChanged);
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCnic_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPhoneNumber.LeadingIcon")));
            this.txtPhoneNumber.Location = new System.Drawing.Point(574, 247);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(312, 36);
            this.txtPhoneNumber.TabIndex = 121;
            this.txtPhoneNumber.Text = "";
            this.txtPhoneNumber.TrailingIcon = null;
            this.txtPhoneNumber.UseTallSize = false;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.TxtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AnimateReadOnly = true;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Hint = "Rider\'s Name";
            this.txtName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtName.LeadingIcon")));
            this.txtName.Location = new System.Drawing.Point(99, 183);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 36);
            this.txtName.TabIndex = 119;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(99, 253);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 36);
            this.txtEmail.TabIndex = 120;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.Hint = "Address";
            this.txtAddress.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtAddress.LeadingIcon")));
            this.txtAddress.Location = new System.Drawing.Point(99, 330);
            this.txtAddress.MaxLength = 70;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 36);
            this.txtAddress.TabIndex = 123;
            this.txtAddress.Text = "";
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseTallSize = false;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 22);
            this.label2.TabIndex = 117;
            this.label2.Text = ">> Update Employee Details";
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
            this.panel1.Controls.Add(this.btnaddemployee);
            this.panel1.Location = new System.Drawing.Point(48, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 116;
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
            // btnaddemployee
            // 
            this.btnaddemployee.BackColor = System.Drawing.Color.Teal;
            this.btnaddemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddemployee.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddemployee.Location = new System.Drawing.Point(3, 3);
            this.btnaddemployee.Name = "btnaddemployee";
            this.btnaddemployee.Size = new System.Drawing.Size(90, 40);
            this.btnaddemployee.TabIndex = 2;
            this.btnaddemployee.Text = "DashBoard";
            this.btnaddemployee.UseVisualStyleBackColor = false;
            this.btnaddemployee.Click += new System.EventHandler(this.Btnaddemployee_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(405, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 115;
            this.label1.Text = "Manager DashBoard";
            // 
            // AdressError
            // 
            this.AdressError.AutoSize = true;
            this.AdressError.ForeColor = System.Drawing.Color.Red;
            this.AdressError.Location = new System.Drawing.Point(139, 373);
            this.AdressError.Name = "AdressError";
            this.AdressError.Size = new System.Drawing.Size(0, 13);
            this.AdressError.TabIndex = 132;
            // 
            // UpdateRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.AdressError);
            this.Controls.Add(this.NumberError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.cnicError);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxSalary);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1052, 529);
            this.MinimumSize = new System.Drawing.Size(1052, 529);
            this.Name = "UpdateRider";
            this.Text = "UpdateRider";
            this.Load += new System.EventHandler(this.UpdateRider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label cnicError;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSalary;
        private MaterialSkin.Controls.MaterialTextBox txtCnic;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
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
        private System.Windows.Forms.Button btnaddemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdressError;
    }
}