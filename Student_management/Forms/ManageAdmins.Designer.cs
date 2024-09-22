namespace Student_management.Forms
{
    partial class ManageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdmin));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnUpdateAdmin = new Button();
            btnDelete = new Button();
            btnRegisterAdmin = new Button();
            groupBox3 = new GroupBox();
            lblId = new Label();
            lblAdminId = new Label();
            txtPassword = new TextBox();
            password = new Label();
            txtUserName = new TextBox();
            userName = new Label();
            txtlastName = new TextBox();
            Lastname = new Label();
            txtFirstName = new TextBox();
            firstName = new Label();
            panel3 = new Panel();
            btnRefresh = new Button();
            label15 = new Label();
            listView = new ListView();
            AdminNo = new ColumnHeader();
            Admin_First_name = new ColumnHeader();
            Admin_Last_Name = new ColumnHeader();
            Admin_username = new ColumnHeader();
            Admin_Password = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(982, 41);
            label1.TabIndex = 0;
            label1.Text = "Admin Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdateAdmin);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRegisterAdmin);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(10, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 486);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(208, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdateAdmin.ForeColor = Color.Black;
            btnUpdateAdmin.Location = new Point(12, 365);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(100, 30);
            btnUpdateAdmin.TabIndex = 16;
            btnUpdateAdmin.Text = "Update";
            btnUpdateAdmin.UseVisualStyleBackColor = true;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(208, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRegisterAdmin.ForeColor = Color.Black;
            btnRegisterAdmin.Location = new Point(12, 320);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(100, 30);
            btnRegisterAdmin.TabIndex = 14;
            btnRegisterAdmin.Text = "Register";
            btnRegisterAdmin.UseVisualStyleBackColor = true;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblId);
            groupBox3.Controls.Add(lblAdminId);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(password);
            groupBox3.Controls.Add(txtUserName);
            groupBox3.Controls.Add(userName);
            groupBox3.Controls.Add(txtlastName);
            groupBox3.Controls.Add(Lastname);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(firstName);
            groupBox3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 278);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Admin Details";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(64, 64, 64);
            lblId.Location = new Point(16, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(79, 19);
            lblId.TabIndex = 15;
            lblId.Text = "Admin ID";
            // 
            // lblAdminId
            // 
            lblAdminId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAdminId.AutoSize = true;
            lblAdminId.ForeColor = Color.FromArgb(64, 64, 64);
            lblAdminId.Location = new Point(125, 52);
            lblAdminId.Name = "lblAdminId";
            lblAdminId.Size = new Size(0, 19);
            lblAdminId.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(125, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(153, 27);
            txtPassword.TabIndex = 12;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password.AutoSize = true;
            password.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            password.ForeColor = Color.FromArgb(64, 64, 64);
            password.Location = new Point(16, 224);
            password.Name = "password";
            password.Size = new Size(87, 19);
            password.TabIndex = 11;
            password.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(125, 177);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(153, 27);
            txtUserName.TabIndex = 10;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userName.AutoSize = true;
            userName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            userName.ForeColor = Color.FromArgb(64, 64, 64);
            userName.Location = new Point(16, 180);
            userName.Name = "userName";
            userName.Size = new Size(95, 19);
            userName.TabIndex = 9;
            userName.Text = "User Name";
            // 
            // txtlastName
            // 
            txtlastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtlastName.Location = new Point(125, 135);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(153, 27);
            txtlastName.TabIndex = 8;
            // 
            // Lastname
            // 
            Lastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lastname.AutoSize = true;
            Lastname.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            Lastname.ForeColor = Color.FromArgb(64, 64, 64);
            Lastname.Location = new Point(16, 138);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(92, 19);
            Lastname.TabIndex = 7;
            Lastname.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(125, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 27);
            txtFirstName.TabIndex = 6;
            // 
            // firstName
            // 
            firstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstName.AutoSize = true;
            firstName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            firstName.ForeColor = Color.FromArgb(64, 64, 64);
            firstName.Location = new Point(16, 94);
            firstName.Name = "firstName";
            firstName.Size = new Size(94, 19);
            firstName.TabIndex = 3;
            firstName.Text = "First Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(listView);
            panel3.Location = new Point(336, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 486);
            panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(531, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(3, 2);
            label15.Name = "label15";
            label15.Size = new Size(159, 33);
            label15.TabIndex = 7;
            label15.Text = "All Admins";
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView.BackColor = SystemColors.ControlLight;
            listView.Columns.AddRange(new ColumnHeader[] { AdminNo, Admin_First_name, Admin_Last_Name, Admin_username, Admin_Password });
            listView.FullRowSelect = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(3, 41);
            listView.Name = "listView";
            listView.Size = new Size(630, 442);
            listView.TabIndex = 1;
            listView.TabStop = false;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // AdminNo
            // 
            AdminNo.Text = "RegNo";
            AdminNo.Width = 80;
            // 
            // Admin_First_name
            // 
            Admin_First_name.Text = "First Name";
            Admin_First_name.Width = 135;
            // 
            // Admin_Last_Name
            // 
            Admin_Last_Name.Text = "Last Name";
            Admin_Last_Name.Width = 135;
            // 
            // Admin_username
            // 
            Admin_username.Text = "Username";
            Admin_username.Width = 140;
            // 
            // Admin_Password
            // 
            Admin_Password.Text = "Password";
            Admin_Password.Width = 135;
            // 
            // ManageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox3;
        private TextBox txtFirstName;
        private Label firstName;
        private TextBox txtPassword;
        private Label password;
        private TextBox txtUserName;
        private Label userName;
        private TextBox txtlastName;
        private Label Lastname;
       // private Label adminId;
        private Button btnClear;
        private Button btnUpdateAdmin;
        private Button btnDelete;
        private Button btnRegisterAdmin;
        private Panel panel3;
        private ListView listView;
        private ColumnHeader AdminNo;
        private ColumnHeader Admin_First_name;
        private ColumnHeader Admin_Last_Name;
        private ColumnHeader Admin_username;
        private ColumnHeader Admin_Password;
        private Button btnRefresh;
        private Label label15;
        private Label lblAdminId;
        private Label lblId;
    }
}