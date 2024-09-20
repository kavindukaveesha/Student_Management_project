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
            txtAdminId = new TextBox();
            adminId = new Label();
            txtPassword = new TextBox();
            password = new Label();
            txtUserName = new TextBox();
            userName = new Label();
            txtlastName = new TextBox();
            Lastname = new Label();
            txtFirstName = new TextBox();
            firstName = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(249, -1);
            label1.Name = "label1";
            label1.Size = new Size(297, 35);
            label1.TabIndex = 0;
            label1.Text = "Admin Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdateAdmin);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRegisterAdmin);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 414);
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
            groupBox3.Controls.Add(txtAdminId);
            groupBox3.Controls.Add(adminId);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(password);
            groupBox3.Controls.Add(txtUserName);
            groupBox3.Controls.Add(userName);
            groupBox3.Controls.Add(txtlastName);
            groupBox3.Controls.Add(Lastname);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(firstName);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 278);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txtAdminId
            // 
            txtAdminId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAdminId.Location = new Point(125, 49);
            txtAdminId.Name = "txtAdminId";
            txtAdminId.Size = new Size(153, 27);
            txtAdminId.TabIndex = 14;
            // 
            // adminId
            // 
            adminId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminId.AutoSize = true;
            adminId.ForeColor = Color.FromArgb(64, 64, 64);
            adminId.Location = new Point(16, 52);
            adminId.Name = "adminId";
            adminId.Size = new Size(72, 20);
            adminId.TabIndex = 13;
            adminId.Text = "Admin ID";
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
            password.ForeColor = Color.FromArgb(64, 64, 64);
            password.Location = new Point(16, 224);
            password.Name = "password";
            password.Size = new Size(70, 20);
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
            userName.ForeColor = Color.FromArgb(64, 64, 64);
            userName.Location = new Point(16, 180);
            userName.Name = "userName";
            userName.Size = new Size(82, 20);
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
            Lastname.ForeColor = Color.FromArgb(64, 64, 64);
            Lastname.Location = new Point(16, 138);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(79, 20);
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
            firstName.ForeColor = Color.FromArgb(64, 64, 64);
            firstName.Location = new Point(16, 94);
            firstName.Name = "firstName";
            firstName.Size = new Size(80, 20);
            firstName.TabIndex = 3;
            firstName.Text = "First Name";
            firstName.Click += label10_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(327, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(455, 413);
            panel3.TabIndex = 2;
            // 
            // ManageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
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
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox3;
        private TextBox txtFirstName;
        private Label firstName;
        private TextBox txtPassword;
        private Label password;
        private TextBox txtUserName;
        private Label userName;
        private TextBox txtlastName;
        private Label Lastname;
        private TextBox txtAdminId;
        private Label adminId;
        private Button btnClear;
        private Button btnUpdateAdmin;
        private Button btnDelete;
        private Button btnRegisterAdmin;
    }
}