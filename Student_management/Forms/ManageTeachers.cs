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
    public partial class ManageTeachers : Form
    {
        int teacherIdNew { get; set; }
        int teacherIdSelected { get; set; }

        int teacherId { get; set; }
        string firstNameVar { get; set; }
        string lastNameVar { get; set; }
        string contactNoVar { get; set; }
        string emailVar { get; set; }
        string subjectVar { get; set; }
        string salaryVar { get; set; }

        SqlDataReader reader { get; set; }

        public ManageTeachers()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageTeachers_Load);
        }
        private void ManageTeachers_Load(object sender, EventArgs e)
        {
            getAllData();
        }


        private void getAllData()
        {


            string query = "SELECT * FROM Teachers";


            SqlCommand cmd = DBConn.getCommand(query);

            reader = cmd.ExecuteReader();

            listView.Items.Clear();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["teacherId"].ToString());

                item.SubItems.Add(reader["firstName"].ToString());
                item.SubItems.Add(reader["lastName"].ToString());
                item.SubItems.Add(reader["contactNo"].ToString());
                item.SubItems.Add(reader["email"].ToString());
                item.SubItems.Add(reader["subject"].ToString());
                item.SubItems.Add(reader["salary"].ToString());


                listView.Items.Add(item);

                teacherIdNew = (int)reader["teacherId"] + 1;

            }

            lblTeacherIdText.Text = Convert.ToString(teacherIdNew);
        }


        private void clearData()
        {
            txtFirstName.Clear();
            txtlastName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtSubject.Clear();
            txtSalary.Clear();
            lblTeacherIdText.Text = Convert.ToString(teacherIdNew);

        }

        //function that use to validate contact_no
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }


        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            firstNameVar = txtFirstName.Text;
            lastNameVar = txtlastName.Text;
            contactNoVar = txtContactNo.Text;
            emailVar = txtEmail.Text;
            subjectVar = txtSubject.Text;
            salaryVar = txtSalary.Text;

            //check required inputs are entered or not
            if (string.IsNullOrEmpty(firstNameVar) || string.IsNullOrEmpty(contactNoVar) || string.IsNullOrEmpty(subjectVar))
            {
                MessageBox.Show(
                    "First Name Contact No and Subject Important!.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            // Validate phone numbers are numeric and valid length (e.g., 10 digits)
            if (!IsValidPhoneNumber(contactNoVar))
            {
                MessageBox.Show("Please enter valid phone numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                try
                {


                    string query = "INSERT INTO Teachers (firstName, lastName, contactNo, email,subject,salary) VALUES (@firstName, @lastName, @contactNo, @email,@subject,@salary)";
                    SqlCommand cmd = DBConn.getCommand(query);

                    cmd.Parameters.AddWithValue("@firstName", firstNameVar);
                    cmd.Parameters.AddWithValue("@lastName", lastNameVar);
                    cmd.Parameters.AddWithValue("@contactNo", contactNoVar);
                    cmd.Parameters.AddWithValue("@email", emailVar);
                    cmd.Parameters.AddWithValue("@subject", subjectVar);
                    cmd.Parameters.AddWithValue("@salary", salaryVar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                       "Teacher Register Successfully",
                       "Success!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                        );

                    getAllData();
                    clearData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering Teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            firstNameVar = txtFirstName.Text;
            lastNameVar = txtlastName.Text;
            contactNoVar = txtContactNo.Text;
            emailVar = txtEmail.Text;
            subjectVar = txtSubject.Text;
            salaryVar = txtSalary.Text;


            //check required inputs are entered or not
            if (string.IsNullOrEmpty(firstNameVar) || string.IsNullOrEmpty(contactNoVar) || string.IsNullOrEmpty(subjectVar))
            {
                MessageBox.Show(
                    "First Name Contact No and Subject Important!.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            // Validate phone numbers are numeric and valid length (e.g., 10 digits)
            if (!IsValidPhoneNumber(contactNoVar))
            {
                MessageBox.Show("Please enter valid phone numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {

                try
                {


                    string query = "UPDATE Teachers SET firstName = @firstName, lastName = @lastName, contactNo = @contactNo, email = @email,subject = @subject,salary = @salary WHERE teacherId = @teacherIdSelected";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@teacherIdSelected", teacherIdSelected);
                    cmd.Parameters.AddWithValue("@firstName", firstNameVar);
                    cmd.Parameters.AddWithValue("@lastName", lastNameVar);
                    cmd.Parameters.AddWithValue("@contactNo", contactNoVar);
                    cmd.Parameters.AddWithValue("@email", emailVar);
                    cmd.Parameters.AddWithValue("@subject", subjectVar);
                    cmd.Parameters.AddWithValue("@salary", salaryVar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                       "Teacher Update Successfully",
                       "Success!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                        );

                    getAllData();
                    clearData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Updating a Teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure, Do you really want to Delete this Teacher...?",
           "Delete",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Teachers WHERE teacherId = @teacherIdSelected";
                    SqlCommand cmd = DBConn.getCommand(query);
                    cmd.Parameters.AddWithValue("@teacherIdSelected", teacherIdSelected);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                teacherIdSelected = Convert.ToInt16(selectedItem.Text);

                lblTeacherIdText.Text = selectedItem.Text;

                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtlastName.Text = selectedItem.SubItems[2].Text;
                txtContactNo.Text = selectedItem.SubItems[3].Text;
                txtEmail.Text = selectedItem.SubItems[4].Text;
                txtSubject.Text = selectedItem.SubItems[5].Text;
                txtSalary.Text = selectedItem.SubItems[6].Text;



            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllData();
            clearData();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow the character
            }
        }
    }
}
