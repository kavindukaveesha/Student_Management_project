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

            string loginQuery = "SELECT useid FROM Logins WHERE usename = @username AND password = @password";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    SqlCommand cmd = DBConn.getCommand(loginQuery);
                   
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int useid = reader.GetInt32(0);
                            if (useid >= 0)
                            {
                                loginsuccess = true;
                            }
                        }
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }



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

                    txtUsername.Clear();
                    txtPassword.Clear();
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
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
