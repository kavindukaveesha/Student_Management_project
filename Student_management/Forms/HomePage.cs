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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_management.Forms
{
    public partial class HomePage : Form
    {

        int regNumberNew { get; set; }
        int regNoSelected { get; set; }
        int regNo { get; set; }

        string firstName { get; set; }
        string lastName { get; set; }
        DateTime dateOfBirth { get; set; }
        string gender { get; set; }
        string address { get; set; }
        string email { get; set; }
        string mobilePhone { get; set; }
        string homePhone { get; set; }
        string parentName { get; set; }
        string nic { get; set; }
        string contactNo { get; set; }
        SqlDataReader reader { get; set; }


        public HomePage()
        {
            InitializeComponent();
            getAllData();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        //function for clear inputs
        private void clearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddresses.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParentName.Clear();
            txtNic.Clear();
            txtParentNumber.Clear();
            txtBirthOfDate.Value = DateTime.Now;
        }


        //function for get all data
        private void getAllData()
        {


            string query = "SELECT * FROM Registration";


            SqlCommand cmd = DBConn.getCommand(query);

            reader = cmd.ExecuteReader();

            listView.Items.Clear();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["regNo"].ToString());

                item.SubItems.Add(reader["firstName"].ToString());
                item.SubItems.Add(reader["lastName"].ToString());
                item.SubItems.Add(reader["dateOfBirth"].ToString());
                item.SubItems.Add(reader["gender"].ToString());
                item.SubItems.Add(reader["address"].ToString());
                item.SubItems.Add(reader["email"].ToString());
                item.SubItems.Add(reader["mobilePhone"].ToString());
                item.SubItems.Add(reader["homePhone"].ToString());
                item.SubItems.Add(reader["parentName"].ToString());
                item.SubItems.Add(reader["nic"].ToString());
                item.SubItems.Add(reader["contactNo"].ToString());

                listView.Items.Add(item);

                regNumberNew = (int)reader["regNo"] + 1;

            }

            regNoLabel.Text = Convert.ToString(regNumberNew);
        }




        //register student
        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Get values from input fields
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            dateOfBirth = txtBirthOfDate.Value;
            address = txtAddresses.Text;
            email = txtEmail.Text;
            mobilePhone = txtMobile.Text;
            homePhone = txtHome.Text;
            parentName = txtParentName.Text;
            nic = txtNic.Text;
            contactNo = txtParentNumber.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(mobilePhone) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(parentName) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(contactNo))
            {

                MessageBox.Show("Please fill out all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Validate phone numbers are numeric and valid length (e.g., 10 digits)
            if (!IsValidPhoneNumber(mobilePhone) || !IsValidPhoneNumber(homePhone) || !IsValidPhoneNumber(contactNo))
            {
                MessageBox.Show("Please enter valid phone numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Insert the data into the database
            string query = "INSERT INTO Registration " +
                           "(firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                           "VALUES(@firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

            try
            {
                SqlCommand cmd = DBConn.getCommand(query);

                // Add parameters to the query
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@homePhone", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);

                // Execute the command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
                getAllData(); // Refresh the data
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //update student
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            dateOfBirth = txtBirthOfDate.Value;
            address = txtAddresses.Text;
            email = txtEmail.Text;
            mobilePhone = txtMobile.Text;
            homePhone = txtHome.Text;
            parentName = txtParentName.Text;
            nic = txtNic.Text;
            contactNo = txtParentNumber.Text;


            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(mobilePhone) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(parentName) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(contactNo))
            {
                MessageBox.Show("Please fill out all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                return;
            }

            // Validate phone numbers are numeric and valid length (e.g., 10 digits)
            if (!IsValidPhoneNumber(mobilePhone) || !IsValidPhoneNumber(homePhone) || !IsValidPhoneNumber(contactNo))
            {
                MessageBox.Show("Please enter valid phone numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string query = "UPDATE Registration " +
                           "SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, gender = @gender, " +
                           "address = @address, email = @email, mobilePhone = @mobilePhone, homePhone = @homePhone, parentName = @parentName, " +
                           "nic = @nic, contactNo = @contactNo " +
                           "WHERE regNo = @regNoSelected";

            try
            {
                SqlCommand cmd = DBConn.getCommand(query);

                cmd.Parameters.AddWithValue("@regNoSelected", regNoSelected);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@homePhone", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                   "Student Update Successfully",
                   "Update Student",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                clearInputs();

                getAllData();

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    $"SQL Error: {sqlEx.Message}",
                    "SQL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"General Error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }



        }

        //delete student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure, Do you really want to Delete this Student...?",
            "Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                try
                {

                    string query = "DELETE FROM Registration WHERE regNo = @regNoSelected";

                    SqlCommand cmd = DBConn.getCommand(query);

                    cmd.Parameters.AddWithValue("@regNoSelected", regNoSelected);

                    cmd.ExecuteNonQuery();

                    //try to delete student
                    MessageBox.Show(
                   "Student Deleted Successfully",
                   "Delete Student",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                    clearInputs();

                    getAllData();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(
                        $"SQL Error: {sqlEx.Message}",
                        "SQL Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
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

        //clear text fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputs();
            txtBirthOfDate.Value = DateTime.Now;
            regNoLabel.Text = Convert.ToString(regNumberNew);

            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        //function to selected row add to text field
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                regNoSelected = Convert.ToInt16(selectedItem.Text);

                regNoLabel.Text = selectedItem.Text;

                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtLastName.Text = selectedItem.SubItems[2].Text;
                txtBirthOfDate.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                txtAddresses.Text = selectedItem.SubItems[5].Text;
                txtEmail.Text = selectedItem.SubItems[6].Text;
                txtMobile.Text = "0" + selectedItem.SubItems[7].Text;
                txtHome.Text = "0" + selectedItem.SubItems[8].Text;
                txtParentName.Text = selectedItem.SubItems[9].Text;
                txtNic.Text = selectedItem.SubItems[10].Text;
                txtParentNumber.Text = "0" + selectedItem.SubItems[11].Text;

                if ("Male".Equals(selectedItem.SubItems[4].Text))
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
            }

        }

        //This is the function to refresh form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllData();
            clearInputs();
        }



        //radio male
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        //radio female
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }


        //goto admin management form
        private void btnManageAdmins_Click(object sender, EventArgs e)
        {
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.Show();
        }

        //logout 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        //goto teacher management
        private void btnManageTeachers_Click_1(object sender, EventArgs e)
        {
            ManageTeachers admin = new ManageTeachers();
            admin.Show();
        }






        //check mobile numbers can only have 10 numbers
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }




        //Functions for handle mobile numbers can input only numbers

        //handle mobile number text field can get numbers only
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        //handle Home number text field can get numbers only
        private void txtHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        //handle  parent mobile number text field can get numbers only
        private void txtParentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }


    }
}

