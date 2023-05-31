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
    public partial class TeacherSetting : Form
    {
        public TeacherSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Teacher.sSave == "Add")
            {
                LogIn.q = "insert into teacher values (null,'" + txtFName.Text 
                + "','" + txtMName.Text
                + "','" + txtLName.Text
                + "','" + txtAddress.Text
                + "','" + txtConNum.Text
                + "','" + txtTeacherStatus.Text
                + "','" + cbPosition.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding is successfull!!!");
                Close();    
            }
            else
            {
                LogIn.q = "update teacher set Fname = '" + txtFName.Text
                    + "', Mname = '" + txtMName.Text
                    + "', Lname = '" + txtLName.Text
                    + "', Address = '" + txtAddress.Text
                    + "', ContactNumber = '" + txtConNum.Text
                    + "', Position = '" + cbPosition.Text
                    + "', TeacherStatus = '" + txtTeacherStatus.Text
                    + "'  where teacherID = '"+Teacher.tTeacherID + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is Successfull");
            }//SELECT TeacherID, Fname, Mname, Lname, Address, ContactNumber, Position, TeacherStatus FROM teacher t;
        }

        private void TeacherSetting_Load(object sender, EventArgs e)
        {
            if (Teacher.sSave == "Edit")
            {
                txtFName.Text = Teacher.tFname;
                txtLName.Text = Teacher.tLname;
                txtMName.Text = Teacher.tMname;
                txtConNum.Text = Teacher.tContactNumber;
                txtTeacherStatus.Text = Teacher.tTeacherStatus;
                txtAddress.Text = Teacher.tAddress;
                cbPosition.Text = Teacher.tPosition;
            }
        }
         
    }
}
