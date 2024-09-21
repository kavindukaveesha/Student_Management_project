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
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            try
            {

                //try to add admin
                MessageBox.Show(
                "Student Register Successfully",
                "Register Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Error in Register.check again",
                   "Error!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                 );
            }
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            try
            {

                //try to add admin
                MessageBox.Show(
                "Student Update Successfully",
                "Update Student",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Error in Update.check again",
                   "Error!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                 );
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
                    //try to delete student
                    MessageBox.Show("Admin deleted successfully.");

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

        }

        private void adminDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
