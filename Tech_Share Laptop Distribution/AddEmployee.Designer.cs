namespace Tech_Share_Laptop_Distribution
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.MaleCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtCnic = new MaterialSkin.Controls.MaterialTextBox();
            this.FemaleCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.ComboBoxSalary = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
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
            this.RadioBtnError = new System.Windows.Forms.Label();
            this.cnicError = new System.Windows.Forms.Label();
            this.NumberError = new System.Windows.Forms.Label();
            this.mailError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.adressError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tech_Share_Laptop_Distribution.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Hint = "Employee Name";
            this.txtName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtName.LeadingIcon")));
            this.txtName.Location = new System.Drawing.Point(69, 176);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 36);
            this.txtName.TabIndex = 24;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(69, 246);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 36);
            this.txtEmail.TabIndex = 25;
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
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.Hint = "Address";
            this.txtAddress.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtAddress.LeadingIcon")));
            this.txtAddress.Location = new System.Drawing.Point(69, 323);
            this.txtAddress.MaxLength = 70;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 36);
            this.txtAddress.TabIndex = 28;
            this.txtAddress.Text = "";
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseTallSize = false;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddress_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPhoneNumber.LeadingIcon")));
            this.txtPhoneNumber.Location = new System.Drawing.Point(544, 240);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(336, 36);
            this.txtPhoneNumber.TabIndex = 26;
            this.txtPhoneNumber.Text = "";
            this.txtPhoneNumber.TrailingIcon = null;
            this.txtPhoneNumber.UseTallSize = false;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // MaleCheck
            // 
            this.MaleCheck.AutoSize = true;
            this.MaleCheck.Depth = 0;
            this.MaleCheck.Location = new System.Drawing.Point(69, 377);
            this.MaleCheck.Margin = new System.Windows.Forms.Padding(0);
            this.MaleCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MaleCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaleCheck.Name = "MaleCheck";
            this.MaleCheck.Ripple = true;
            this.MaleCheck.Size = new System.Drawing.Size(70, 37);
            this.MaleCheck.TabIndex = 31;
            this.MaleCheck.TabStop = true;
            this.MaleCheck.Text = "Male";
            this.MaleCheck.UseVisualStyleBackColor = true;
            // 
            // txtCnic
            // 
            this.txtCnic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCnic.AnimateReadOnly = false;
            this.txtCnic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnic.Depth = 0;
            this.txtCnic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCnic.Hint = "CNIC";
            this.txtCnic.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtCnic.LeadingIcon")));
            this.txtCnic.Location = new System.Drawing.Point(544, 176);
            this.txtCnic.MaxLength = 13;
            this.txtCnic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCnic.Multiline = false;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(336, 36);
            this.txtCnic.TabIndex = 27;
            this.txtCnic.Text = "";
            this.txtCnic.TrailingIcon = null;
            this.txtCnic.UseTallSize = false;
            this.txtCnic.TextChanged += new System.EventHandler(this.TxtCnic_TextChanged);
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCnic_KeyPress);
            // 
            // FemaleCheck
            // 
            this.FemaleCheck.AutoSize = true;
            this.FemaleCheck.Depth = 0;
            this.FemaleCheck.Location = new System.Drawing.Point(69, 408);
            this.FemaleCheck.Margin = new System.Windows.Forms.Padding(0);
            this.FemaleCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FemaleCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.FemaleCheck.Name = "FemaleCheck";
            this.FemaleCheck.Ripple = true;
            this.FemaleCheck.Size = new System.Drawing.Size(87, 37);
            this.FemaleCheck.TabIndex = 32;
            this.FemaleCheck.TabStop = true;
            this.FemaleCheck.Text = "Female";
            this.FemaleCheck.UseVisualStyleBackColor = true;
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
            this.ComboBoxSalary.Location = new System.Drawing.Point(544, 310);
            this.ComboBoxSalary.MaxDropDownItems = 4;
            this.ComboBoxSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSalary.Name = "ComboBoxSalary";
            this.ComboBoxSalary.Size = new System.Drawing.Size(336, 49);
            this.ComboBoxSalary.StartIndex = 0;
            this.ComboBoxSalary.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Add Employee";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(569, 409);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(786, 409);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(69, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save >";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.panel1.Location = new System.Drawing.Point(38, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 48);
            this.panel1.TabIndex = 109;
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
            this.label1.Location = new System.Drawing.Point(402, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 108;
            this.label1.Text = "Manager DashBoard";
            // 
            // RadioBtnError
            // 
            this.RadioBtnError.AutoSize = true;
            this.RadioBtnError.ForeColor = System.Drawing.Color.Red;
            this.RadioBtnError.Location = new System.Drawing.Point(66, 445);
            this.RadioBtnError.Name = "RadioBtnError";
            this.RadioBtnError.Size = new System.Drawing.Size(0, 13);
            this.RadioBtnError.TabIndex = 110;
            // 
            // cnicError
            // 
            this.cnicError.AutoSize = true;
            this.cnicError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cnicError.ForeColor = System.Drawing.Color.Red;
            this.cnicError.Location = new System.Drawing.Point(576, 215);
            this.cnicError.Name = "cnicError";
            this.cnicError.Size = new System.Drawing.Size(0, 13);
            this.cnicError.TabIndex = 111;
            // 
            // NumberError
            // 
            this.NumberError.AutoSize = true;
            this.NumberError.ForeColor = System.Drawing.Color.Red;
            this.NumberError.Location = new System.Drawing.Point(579, 283);
            this.NumberError.Name = "NumberError";
            this.NumberError.Size = new System.Drawing.Size(0, 13);
            this.NumberError.TabIndex = 112;
            // 
            // mailError
            // 
            this.mailError.AutoSize = true;
            this.mailError.ForeColor = System.Drawing.Color.Red;
            this.mailError.Location = new System.Drawing.Point(102, 283);
            this.mailError.Name = "mailError";
            this.mailError.Size = new System.Drawing.Size(0, 13);
            this.mailError.TabIndex = 113;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(105, 214);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 13);
            this.nameError.TabIndex = 114;
            // 
            // adressError
            // 
            this.adressError.AutoSize = true;
            this.adressError.ForeColor = System.Drawing.Color.Red;
            this.adressError.Location = new System.Drawing.Point(96, 362);
            this.adressError.Name = "adressError";
            this.adressError.Size = new System.Drawing.Size(0, 13);
            this.adressError.TabIndex = 115;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.adressError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.mailError);
            this.Controls.Add(this.NumberError);
            this.Controls.Add(this.cnicError);
            this.Controls.Add(this.RadioBtnError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ComboBoxSalary);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.MaleCheck);
            this.Controls.Add(this.FemaleCheck);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1052, 529);
            this.MinimumSize = new System.Drawing.Size(1052, 529);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneNumber;
        private MaterialSkin.Controls.MaterialRadioButton MaleCheck;
        private MaterialSkin.Controls.MaterialTextBox txtCnic;
        private MaterialSkin.Controls.MaterialRadioButton FemaleCheck;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSalary;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
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
        private System.Windows.Forms.Label RadioBtnError;
        private System.Windows.Forms.Label cnicError;
        private System.Windows.Forms.Label NumberError;
        private System.Windows.Forms.Label mailError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label adressError;
    }
}