using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
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
                catch (Exception ex) {
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
    }
}
