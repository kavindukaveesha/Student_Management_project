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

            regNoLabel.Text = "0" + Convert.ToString(regNumberNew);
        }







        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }
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
        private void btnRegister_Click(object sender, EventArgs e)
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


            string query = "INSERT INTO Registration " +
                "( firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                "VALUES( @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

            try
            {
                SqlCommand cmd = DBConn.getCommand(query);

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobilePhone", int.Parse(mobilePhone));
                cmd.Parameters.AddWithValue("@homePhone", int.Parse(homePhone));
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", int.Parse(contactNo));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                "Student Added Successfully",
                "Register Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

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
                cmd.Parameters.AddWithValue("@mobilePhone", int.Parse(mobilePhone));
                cmd.Parameters.AddWithValue("@homePhone", int.Parse(homePhone));
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", int.Parse(contactNo));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                   "Student Update Successfully",
                   "Update Student",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );

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
        private void btnClear_Click(object sender, EventArgs e)
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

            regNoLabel.Text = "0" + Convert.ToString(regNumberNew);

            radioFemale.Checked = false;
            radioMale.Checked = false;
        }
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                regNoSelected = Convert.ToInt16(selectedItem.Text);

                regNoLabel.Text = "0" + selectedItem.Text;

                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtLastName.Text = selectedItem.SubItems[2].Text;
                txtBirthOfDate.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                txtAddresses.Text = selectedItem.SubItems[5].Text;
                txtEmail.Text = selectedItem.SubItems[6].Text;
                txtMobile.Text = selectedItem.SubItems[7].Text;
                txtHome.Text = selectedItem.SubItems[8].Text;
                txtParentName.Text = selectedItem.SubItems[9].Text;
                txtNic.Text = selectedItem.SubItems[10].Text;
                txtParentNumber.Text = selectedItem.SubItems[11].Text;

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
        private void btnmanageTeachers_Click(object sender, EventArgs e)
        {
            ManageTeachers manageTeachers = new ManageTeachers();
            manageTeachers.Show();

        }
    }
}

