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
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        // Load admins into the DataGridView when the form loads
        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }

        // Method to load all admins from the database into the DataGridView
        private void LoadAdmins()
        {
            try
            {
                string query = "SELECT * FROM Admins";
                SqlCommand cmd = DBConn.getCommand(query);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    adminDataTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No admin data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admins: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdminId.Clear();
            txtFirstName.Clear();
            txtlastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPassword.Clear();

        }


        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {

            string adminId = txtAdminId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtlastName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "First Name Username and Password Important!.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {

                try
                {


                    string query = "INSERT INTO Admins (firstName, lastName, userName, password) VALUES (@firstName, @lastName, @userName, @password)";
                    SqlCommand cmd = DBConn.getCommand(query);

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                       "Student Register Successfully",
                       "Register Student",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                        );

                    LoadAdmins();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            string adminId = txtAdminId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtlastName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "First Name Username and Password Important!.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {

                try
                {


                    string query = "UPDATE Admins SET firstName = @firstName, lastName = @lastName, userName = @userName, password = @password WHERE userId = @adminId";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure, Do you really want to Delete this Admin...?",
           "Delete",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Admins WHERE userId = @adminId";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@adminId", txtAdminId.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Error in delete.check again",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                     );

                }


            }

        }



        private void adminDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the row clicked is valid
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow row = adminDataTable.Rows[e.RowIndex];

                    // Set values from the selected row into the text fields
                    txtAdminId.Text = row.Cells["userId"].Value.ToString() ;
                    txtFirstName.Text = row.Cells["firstName"].Value.ToString();
                    txtlastName.Text = row.Cells["lastName"].Value.ToString();
                    txtUserName.Text = row.Cells["userName"].Value.ToString();
                    txtPassword.Text = row.Cells["password"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
