namespace Student_management.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            btnClear = new Button();
            txtPassword = new TextBox();
            Password = new Label();
            txtUsername = new TextBox();
            Username = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__10__removebg_preview;
            pictureBox1.Location = new Point(138, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 165);
            label1.Name = "label1";
            label1.Size = new Size(348, 44);
            label1.TabIndex = 1;
            label1.Text = "Skills International";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(Username);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(66, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGray;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Location = new Point(227, 145);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.BackgroundImageLayout = ImageLayout.Center;
            btnClear.Location = new Point(23, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 30);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(23, 100);
            Password.Name = "Password";
            Password.Size = new Size(82, 23);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(133, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 30);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(23, 55);
            Username.Name = "Username";
            Username.Size = new Size(85, 23);
            Username.TabIndex = 0;
            Username.Text = "username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(482, 453);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login-Skills International";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Button btnClear;
        private TextBox txtPassword;
        private Label Password;
        private TextBox txtUsername;
        private Label Username;
    }
}