using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace LOG_IN.CS
{
    public partial class RequirementsSetting : Form
    {
        public RequirementsSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Requirements.sSave == "Add")
            {
                LogIn.q = "insert into Requirements values (null,'" + txtRN.Text
                + "','" + txtSY.Text
                + "','" + txtSY.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding is successfull!!!");
                Close();
            }//rRequirementID, rSchoolYear, rRequirementsName, rTypeOfStudent;
            else
            {
                LogIn.q = "update Requirements set requirementsname = '" + txtRN.Text
                    + "', schoolYear = '" + txtSY.Text
                    + "', typeofstudent = '" + txtST.Text
                    + "'  where requirementID = '" + Requirements.rRequirementID + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is Successfull");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
