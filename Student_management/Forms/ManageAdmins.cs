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

        int adminIdNew { get; set; }
        int adminIdSelected { get; set; }

        int adminId { get; set; }

        SqlDataReader reader { get; set; }

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
            getAllData();
        }

        // Method to load all admins from the database into the DataGridView
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

            lblAdminId.Text = Convert.ToString(adminIdNew);
        }

        private void clearData()
        {
            txtFirstName.Clear();
            txtlastName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPassword.Clear();
            lblAdminId.Text = Convert.ToString(adminIdNew);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();

        }


        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {

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

                    getAllData();
                    clearData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
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


                    string query = "UPDATE Admins SET firstName = @firstName, lastName = @lastName, userName = @userName, password = @password WHERE userId = @adminIdSelected";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@adminIdSelected", adminIdSelected);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);

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
                    MessageBox.Show(
                    "Error in delete.check again",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                     );

                }


            }

        }

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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllData();
            clearData() ;

        }
    }
}
