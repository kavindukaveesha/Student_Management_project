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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeachers));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClear = new Button();
            btnUpdateAdmin = new Button();
            btnDelete = new Button();
            btnRegisterAdmin = new Button();
            groupBox3 = new GroupBox();
            txtSubject = new TextBox();
            lblTeacherIdText = new Label();
            txtSalary = new TextBox();
            lblSalary = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtContactNo = new TextBox();
            lblContactNo = new Label();
            lblTeacherID = new Label();
            Subject = new Label();
            txtlastName = new TextBox();
            Lastname = new Label();
            txtFirstName = new TextBox();
            firstName = new Label();
            adminDataTable = new DataGridView();
            listView = new ListView();
            TeacherID = new ColumnHeader();
            Teacher_First_name = new ColumnHeader();
            Teacher_Last_Name = new ColumnHeader();
            Teacher_Contact_No = new ColumnHeader();
            Teacher_Email = new ColumnHeader();
            Teacher_Subject = new ColumnHeader();
            Teacher_Salary = new ColumnHeader();
            btnRefresh = new Button();
            lblAllTeachers = new Label();
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
            panel2.Location = new Point(12, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 486);
            panel2.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(216, 435);
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
            btnUpdateAdmin.Location = new Point(12, 435);
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
            btnDelete.Location = new Point(216, 390);
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
            btnRegisterAdmin.Location = new Point(12, 390);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(100, 30);
            btnRegisterAdmin.TabIndex = 14;
            btnRegisterAdmin.Text = "Register";
            btnRegisterAdmin.UseVisualStyleBackColor = true;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSubject);
            groupBox3.Controls.Add(lblTeacherIdText);
            groupBox3.Controls.Add(txtSalary);
            groupBox3.Controls.Add(lblSalary);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(lblEmail);
            groupBox3.Controls.Add(txtContactNo);
            groupBox3.Controls.Add(lblContactNo);
            groupBox3.Controls.Add(lblTeacherID);
            groupBox3.Controls.Add(Subject);
            groupBox3.Controls.Add(txtlastName);
            groupBox3.Controls.Add(Lastname);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(firstName);
            groupBox3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 360);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Teacher Details";
            // 
            // txtSubject
            // 
            txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubject.Location = new Point(125, 264);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(161, 27);
            txtSubject.TabIndex = 23;
            // 
            // lblTeacherIdText
            // 
            lblTeacherIdText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTeacherIdText.AutoSize = true;
            lblTeacherIdText.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblTeacherIdText.ForeColor = Color.FromArgb(64, 64, 64);
            lblTeacherIdText.Location = new Point(125, 52);
            lblTeacherIdText.Name = "lblTeacherIdText";
            lblTeacherIdText.Size = new Size(0, 19);
            lblTeacherIdText.TabIndex = 22;
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSalary.Location = new Point(125, 308);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(161, 27);
            txtSalary.TabIndex = 21;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // lblSalary
            // 
            lblSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblSalary.ForeColor = Color.FromArgb(64, 64, 64);
            lblSalary.Location = new Point(16, 311);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(58, 19);
            lblSalary.TabIndex = 20;
            lblSalary.Text = "Salary";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(125, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(16, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 19);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // txtContactNo
            // 
            txtContactNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContactNo.Location = new Point(125, 178);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(161, 27);
            txtContactNo.TabIndex = 17;
            txtContactNo.KeyPress += txtContactNo_KeyPress;
            // 
            // lblContactNo
            // 
            lblContactNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblContactNo.ForeColor = Color.FromArgb(64, 64, 64);
            lblContactNo.Location = new Point(16, 181);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(98, 19);
            lblContactNo.TabIndex = 16;
            lblContactNo.Text = "Contact No";
            // 
            // lblTeacherID
            // 
            lblTeacherID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTeacherID.AutoSize = true;
            lblTeacherID.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblTeacherID.ForeColor = Color.FromArgb(64, 64, 64);
            lblTeacherID.Location = new Point(16, 52);
            lblTeacherID.Name = "lblTeacherID";
            lblTeacherID.Size = new Size(92, 19);
            lblTeacherID.TabIndex = 13;
            lblTeacherID.Text = "Teacher ID";
            // 
            // Subject
            // 
            Subject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Subject.AutoSize = true;
            Subject.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            Subject.ForeColor = Color.FromArgb(64, 64, 64);
            Subject.Location = new Point(16, 267);
            Subject.Name = "Subject";
            Subject.Size = new Size(68, 19);
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
            txtFirstName.Size = new Size(161, 27);
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
            // adminDataTable
            // 
            adminDataTable.BackgroundColor = SystemColors.ButtonFace;
            adminDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataTable.GridColor = SystemColors.InactiveCaption;
            adminDataTable.Location = new Point(350, 99);
            adminDataTable.Name = "adminDataTable";
            adminDataTable.RowHeadersWidth = 51;
            adminDataTable.Size = new Size(820, 442);
            adminDataTable.TabIndex = 4;
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView.BackColor = SystemColors.ControlLight;
            listView.Columns.AddRange(new ColumnHeader[] { TeacherID, Teacher_First_name, Teacher_Last_Name, Teacher_Contact_No, Teacher_Email, Teacher_Subject, Teacher_Salary });
            listView.FullRowSelect = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(350, 99);
            listView.Name = "listView";
            listView.Size = new Size(820, 442);
            listView.TabIndex = 5;
            listView.TabStop = false;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // TeacherID
            // 
            TeacherID.Text = "TeacherID";
            TeacherID.Width = 80;
            // 
            // Teacher_First_name
            // 
            Teacher_First_name.Text = "First Name";
            Teacher_First_name.Width = 135;
            // 
            // Teacher_Last_Name
            // 
            Teacher_Last_Name.Text = "Last Name";
            Teacher_Last_Name.Width = 135;
            // 
            // Teacher_Contact_No
            // 
            Teacher_Contact_No.Text = "ContactNo";
            Teacher_Contact_No.Width = 140;
            // 
            // Teacher_Email
            // 
            Teacher_Email.Text = "Email";
            Teacher_Email.Width = 135;
            // 
            // Teacher_Subject
            // 
            Teacher_Subject.Text = "Subject";
            Teacher_Subject.Width = 100;
            // 
            // Teacher_Salary
            // 
            Teacher_Salary.Text = "Salary";
            Teacher_Salary.Width = 100;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1070, 58);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblAllTeachers
            // 
            lblAllTeachers.AutoSize = true;
            lblAllTeachers.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllTeachers.ForeColor = Color.FromArgb(64, 64, 64);
            lblAllTeachers.Location = new Point(355, 60);
            lblAllTeachers.Name = "lblAllTeachers";
            lblAllTeachers.Size = new Size(181, 33);
            lblAllTeachers.TabIndex = 9;
            lblAllTeachers.Text = "All Teachers";
            // 
            // ManageTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(btnRefresh);
            Controls.Add(lblAllTeachers);
            Controls.Add(listView);
            Controls.Add(adminDataTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "ManageTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageTeachers";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTeacherID;
        private Label Subject;
        private TextBox txtlastName;
        private Label Lastname;
        private TextBox txtFirstName;
        private Label firstName;
        private DataGridView adminDataTable;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtContactNo;
        private Label lblContactNo;
        private TextBox txtSalary;
        private Label lblSalary;
        private Label lblTeacherIdText;
        private ListView listView;
        private ColumnHeader TeacherID;
        private ColumnHeader Teacher_First_name;
        private ColumnHeader Teacher_Last_Name;
        private ColumnHeader Teacher_Contact_No;
        private ColumnHeader Teacher_Email;
        private ColumnHeader Teacher_Subject;
        private ColumnHeader Teacher_Salary;
        private Button btnRefresh;
        private Label lblAllTeachers;
        private TextBox txtSubject;
    }
}