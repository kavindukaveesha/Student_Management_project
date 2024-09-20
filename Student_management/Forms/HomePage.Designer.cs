namespace Student_management.Forms
{
    partial class HomePage
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            txtParentNumber = new TextBox();
            label14 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            txtNic = new TextBox();
            label12 = new Label();
            txtParentName = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            txtHome = new TextBox();
            label8 = new Label();
            txtMobile = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtAddresses = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            label6 = new Label();
            txtBirthOfDate = new DateTimePicker();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1782, 51);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 4;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1630, 12);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 3;
            button1.Text = "Manage Admins";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1782, 51);
            label1.TabIndex = 2;
            label1.Text = "Student Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 992);
            panel2.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button6.Location = new Point(432, 846);
            button6.Name = "button6";
            button6.Size = new Size(100, 30);
            button6.TabIndex = 3;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button5.Location = new Point(318, 846);
            button5.Name = "button5";
            button5.Size = new Size(100, 30);
            button5.TabIndex = 2;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.Location = new Point(124, 846);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 1;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(12, 846);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 0;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 776);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtParentNumber);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtNic);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtParentName);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(23, 593);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(470, 164);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // txtParentNumber
            // 
            txtParentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtParentNumber.Location = new Point(177, 123);
            txtParentNumber.Name = "txtParentNumber";
            txtParentNumber.Size = new Size(267, 27);
            txtParentNumber.TabIndex = 12;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(28, 126);
            label14.Name = "label14";
            label14.Size = new Size(138, 19);
            label14.TabIndex = 11;
            label14.Text = "Contact Number";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(177, 189);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(537, 27);
            textBox8.TabIndex = 10;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(28, 192);
            label11.Name = "label11";
            label11.Size = new Size(132, 19);
            label11.TabIndex = 9;
            label11.Text = "Registration No";
            // 
            // txtNic
            // 
            txtNic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNic.Location = new Point(177, 80);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(267, 27);
            txtNic.TabIndex = 8;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(28, 83);
            label12.Name = "label12";
            label12.Size = new Size(37, 19);
            label12.TabIndex = 7;
            label12.Text = "NIC";
            // 
            // txtParentName
            // 
            txtParentName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtParentName.Location = new Point(177, 38);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(267, 27);
            txtParentName.TabIndex = 6;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(28, 41);
            label13.Name = "label13";
            label13.Size = new Size(110, 19);
            label13.TabIndex = 5;
            label13.Text = "Parent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtHome);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtMobile);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtAddresses);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(23, 326);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 240);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txtHome
            // 
            txtHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHome.Location = new Point(177, 189);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(267, 27);
            txtHome.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(28, 192);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 9;
            label8.Text = "Home Phone";
            // 
            // txtMobile
            // 
            txtMobile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMobile.Location = new Point(177, 146);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(267, 27);
            txtMobile.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(28, 149);
            label7.Name = "label7";
            label7.Size = new Size(114, 19);
            label7.TabIndex = 7;
            label7.Text = "Mobile Phone";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(177, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(28, 107);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 5;
            label9.Text = "Email";
            // 
            // txtAddresses
            // 
            txtAddresses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddresses.Location = new Point(177, 37);
            txtAddresses.Multiline = true;
            txtAddresses.Name = "txtAddresses";
            txtAddresses.Size = new Size(267, 50);
            txtAddresses.TabIndex = 4;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(28, 51);
            label10.Name = "label10";
            label10.Size = new Size(74, 19);
            label10.TabIndex = 3;
            label10.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioFemale);
            groupBox2.Controls.Add(radioMale);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtBirthOfDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(23, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 213);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioFemale
            // 
            radioFemale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioFemale.AutoSize = true;
            radioFemale.ForeColor = SystemColors.InfoText;
            radioFemale.Location = new Point(327, 162);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(85, 23);
            radioFemale.TabIndex = 11;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioMale.AutoSize = true;
            radioMale.ForeColor = SystemColors.InfoText;
            radioMale.Location = new Point(177, 164);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(65, 23);
            radioMale.TabIndex = 10;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(28, 164);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            label6.Click += label6_Click;
            // 
            // txtBirthOfDate
            // 
            txtBirthOfDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBirthOfDate.CalendarForeColor = Color.FromArgb(64, 64, 64);
            txtBirthOfDate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            txtBirthOfDate.Location = new Point(177, 119);
            txtBirthOfDate.Name = "txtBirthOfDate";
            txtBirthOfDate.Size = new Size(267, 27);
            txtBirthOfDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(28, 124);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 7;
            label5.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(177, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(267, 27);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(28, 82);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(177, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 27);
            txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(28, 40);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(172, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "txtRegNo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(23, 46);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 0;
            label2.Text = "Registration No";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(549, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 902);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1201, 839);
            dataGridView1.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 953);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DateTimePicker txtBirthOfDate;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Label label6;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private GroupBox groupBox3;
        private TextBox txtHome;
        private Label label8;
        private TextBox txtMobile;
        private Label label7;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtAddresses;
        private Label label10;
        private GroupBox groupBox4;
        private TextBox txtParentNumber;
        private Label label14;
        private TextBox textBox8;
        private Label label11;
        private TextBox txtNic;
        private Label label12;
        private TextBox txtParentName;
        private Label label13;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
    }
}