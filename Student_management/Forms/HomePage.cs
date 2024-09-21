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
    public partial class HomePage : Form
    {
        int regNo { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime dateOfBirth { get; set; }
        string gender { get; set; }
        string address { get; set; }
        string email { get; set; }
        int mobilePhone { get; set; }
        int homePhone { get; set; }
        string parentName { get; set; }
        string nic { get; set; }
        int contactNo { get; set; }
        SqlDataReader reader { get; set; }

        List<string> regNos = new List<string>();

        public HomePage()
        {
            InitializeComponent();

            /*string query = "SELECT * FROM Registration";

            SqlCommand cmd = DBConn.getCommand(query);

            reader =  cmd.ExecuteReader();

            while (reader.Read()) { 
            
            regNo.Add(reader.GetInt32(0));


            }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }






        private void txtMale(object sender, EventArgs e)
        {

        }

        private void txtFemale(object sender, EventArgs e)
        {

        }

        private void txtAddress(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void button6_Click(object sender, EventArgs e)
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
                    //try to delete student
                    MessageBox.Show(
                   "Student Deleted Successfully",
                   "Delete Student",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Student Added Successfully",
            "Register Student",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "Student Update Successfully",
           "Update Student",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information
           );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
