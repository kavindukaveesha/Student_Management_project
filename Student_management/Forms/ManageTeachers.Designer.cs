namespace Student_management.Forms
{
    partial class ManageTeachers
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClear = new Button();
            btnUpdateAdmin = new Button();
            btnDelete = new Button();
            btnRegisterAdmin = new Button();
            groupBox3 = new GroupBox();
            subjectDropdown = new ComboBox();
            txtTeacherId = new TextBox();
            adminId = new Label();
            txtPassword = new TextBox();
            password = new Label();
            Subject = new Label();
            txtlastName = new TextBox();
            Lastname = new Label();
            txtFirstName = new TextBox();
            firstName = new Label();
            adminDataTable = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminDataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(1182, 41);
            label1.TabIndex = 1;
            label1.Text = "Teacher Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 40);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdateAdmin);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRegisterAdmin);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 508);
            panel2.TabIndex = 3;
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
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(subjectDropdown);
            groupBox3.Controls.Add(txtTeacherId);
            groupBox3.Controls.Add(adminId);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(password);
            groupBox3.Controls.Add(Subject);
            groupBox3.Controls.Add(txtlastName);
            groupBox3.Controls.Add(Lastname);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(firstName);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 278);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Teacher Details";
            // 
            // subjectDropdown
            // 
            subjectDropdown.AutoCompleteCustomSource.AddRange(new string[] { "Maths", "History", "English", "Information Technology" });
            subjectDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectDropdown.FormattingEnabled = true;
            subjectDropdown.Items.AddRange(new object[] { "Maths", "Sinhala", "English", "History", "Information Technology", "Health", "Tamil" });
            subjectDropdown.Location = new Point(125, 177);
            subjectDropdown.Name = "subjectDropdown";
            subjectDropdown.Size = new Size(161, 28);
            subjectDropdown.TabIndex = 15;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTeacherId.Location = new Point(125, 49);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(161, 27);
            txtTeacherId.TabIndex = 14;
            // 
            // adminId
            // 
            adminId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminId.AutoSize = true;
            adminId.ForeColor = Color.FromArgb(64, 64, 64);
            adminId.Location = new Point(16, 52);
            adminId.Name = "adminId";
            adminId.Size = new Size(79, 20);
            adminId.TabIndex = 13;
            adminId.Text = "Teacher ID";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(125, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 27);
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
            // Subject
            // 
            Subject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Subject.AutoSize = true;
            Subject.ForeColor = Color.FromArgb(64, 64, 64);
            Subject.Location = new Point(16, 180);
            Subject.Name = "Subject";
            Subject.Size = new Size(58, 20);
            Subject.TabIndex = 9;
            Subject.Text = "Subject";
            // 
            // txtlastName
            // 
            txtlastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtlastName.Location = new Point(125, 135);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(161, 27);
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
            txtFirstName.Size = new Size(161, 27);
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
            // 
            // adminDataTable
            // 
            adminDataTable.BackgroundColor = SystemColors.ButtonFace;
            adminDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataTable.GridColor = SystemColors.InactiveCaption;
            adminDataTable.Location = new Point(347, 55);
            adminDataTable.Name = "adminDataTable";
            adminDataTable.RowHeadersWidth = 51;
            adminDataTable.Size = new Size(823, 486);
            adminDataTable.TabIndex = 4;
            // 
            // ManageTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(adminDataTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageTeachers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ManageTeachers";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminDataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnClear;
        private Button btnUpdateAdmin;
        private Button btnDelete;
        private Button btnRegisterAdmin;
        private GroupBox groupBox3;
        private TextBox txtTeacherId;
        private Label adminId;
        private TextBox txtPassword;
        private Label password;
        private Label Subject;
        private TextBox txtlastName;
        private Label Lastname;
        private TextBox txtFirstName;
        private Label firstName;
        private DataGridView adminDataTable;
        private ComboBox subjectDropdown;
    }
}