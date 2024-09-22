using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            var loginsuccess = false;

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            // Check if username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                string loginQuery = "SELECT userId FROM Admins WHERE userName = @username AND password = @password";  // Kavindu
               // string loginQuery = "SELECT useId FROM Logins WHERE useName = @username AND password = @password";    // Prasad


                try
                {
                    SqlCommand cmd = DBConn.getCommand(loginQuery);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        int userId = reader.GetInt32(0);
                        if (userId >= 0)

                        {
                            loginsuccess = true;
                        }
                    }



                    reader.Close(); 

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Database error occurred: " + ex.Message,
                        "SQL Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                // After the login attempt, check if login was successful
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
                        // Invalid credentials
                        MessageBox.Show(
                            "Invalid Username or Password. Please try again!",
                            "Login Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        // Clear the username and password text boxes
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any unexpected error that might occur when transitioning to the home page
                    MessageBox.Show(
                        "An error occurred while processing the login: " + ex.Message,
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
