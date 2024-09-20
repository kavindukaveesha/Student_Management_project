﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginsuccess = true;
            try
            {
                if (loginsuccess)
                {
                    // Hide the current form (LoginForm)
                    this.Hide();

                    MessageBox.Show(
                   "Login Success!",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                    // Open the HomePage form
                    HomePage homePage = new HomePage();
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show(
                    "Invalid Username or password.Check again!",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                }
            }
            catch(Exception ex) {
                    MessageBox.Show(
                    "Login Error!",
                     "Login Error",
                           MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
            }
           


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
