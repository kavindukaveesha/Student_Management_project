using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_management.Forms
{
    public partial class ManageAdmin : Form
    {
        int adminIdNew { get; set; }
        int adminIdSelected { get; set; }

        string firstNameVar { get; set; }
        string lastNameVar { get; set; }
        string userNameVar { get; set; }
        string passwordVar { get; set; }

        SqlDataReader reader { get; set; }

        public ManageAdmin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
        }

        // Load admins into the ListView when the form loads
        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        // Method to load all admins from the database into the ListView
        private void getAllData()
        {
            string query = "SELECT * FROM Admins";
            SqlCommand cmd = DBConn.getCommand(query);

            reader = cmd.ExecuteReader();
            listView.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["userId"].ToString());
                item.SubItems.Add(reader["firstName"].ToString());
                item.SubItems.Add(reader["lastName"].ToString());
                item.SubItems.Add(reader["username"].ToString());
                item.SubItems.Add(reader["password"].ToString());

                listView.Items.Add(item);

                adminIdNew = (int)reader["userId"] + 1;
            }
            reader.Close(); // Close reader after use
            lblAdminId.Text = Convert.ToString(adminIdNew);
        }

        // Function to clear inputs
        private void clearData()
        {
            txtFirstName.Clear();
            txtlastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            lblAdminId.Text = Convert.ToString(adminIdNew);
        }

        // Register a new admin
        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            firstNameVar = txtFirstName.Text;
            lastNameVar = txtlastName.Text;
            userNameVar = txtUserName.Text;
            passwordVar = txtPassword.Text;

            if (string.IsNullOrEmpty(firstNameVar) || string.IsNullOrEmpty(userNameVar) || string.IsNullOrEmpty(passwordVar))
            {
                MessageBox.Show("First Name, Username, and Password are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Check for duplicate username
                    string checkQuery = "SELECT COUNT(*) FROM Admins WHERE userName = @userName";
                    SqlCommand checkCmd = DBConn.getCommand(checkQuery);
                    checkCmd.Parameters.AddWithValue("@userName", userNameVar);
                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "INSERT INTO Admins (firstName, lastName, userName, password) VALUES (@firstName, @lastName, @userName, @password)";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@firstName", firstNameVar);
                    cmd.Parameters.AddWithValue("@lastName", lastNameVar);
                    cmd.Parameters.AddWithValue("@userName", userNameVar);
                    cmd.Parameters.AddWithValue("@password", passwordVar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAllData();
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update admin
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            firstNameVar = txtFirstName.Text;
            lastNameVar = txtlastName.Text;
            userNameVar = txtUserName.Text;
            passwordVar = txtPassword.Text;

            if (string.IsNullOrEmpty(firstNameVar) || string.IsNullOrEmpty(userNameVar) || string.IsNullOrEmpty(passwordVar))
            {
                MessageBox.Show("First Name, Username, and Password are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string query = "UPDATE Admins SET firstName = @firstName, lastName = @lastName, userName = @userName, password = @password WHERE userId = @adminIdSelected";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@adminIdSelected", adminIdSelected);
                    cmd.Parameters.AddWithValue("@firstName", firstNameVar);
                    cmd.Parameters.AddWithValue("@lastName", lastNameVar);
                    cmd.Parameters.AddWithValue("@userName", userNameVar);
                    cmd.Parameters.AddWithValue("@password", passwordVar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAllData();
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete admin
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Admins WHERE userId = @adminIdSelected";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@adminIdSelected", adminIdSelected);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAllData();
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Selected row data is shown in input fields
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                adminIdSelected = Convert.ToInt16(selectedItem.Text);
                lblAdminId.Text = selectedItem.Text;

                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtlastName.Text = selectedItem.SubItems[2].Text;
                txtUserName.Text = selectedItem.SubItems[3].Text;
                txtPassword.Text = selectedItem.SubItems[4].Text;
            }
        }

        // Refresh button functionality
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllData();
            clearData();
        }

        // Clear button functionality
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
