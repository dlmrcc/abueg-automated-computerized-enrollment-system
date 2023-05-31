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
    public partial class StudentSetting : Form
    {
        public StudentSetting()
        {
            InitializeComponent();
        }
        public static string sSave;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Student.sSave == "Add")
            {
                LogIn.q = "insert into Student values (null,'" + txtFirstName.Text
                + "','" + txtLastName.Text
                + "','" + txtMiddleName.Text
                + "','" + dtdateofbirth.Text
                + "','" + txtPlaceOfBirth.Text
                + "','" + cbGender.Text
                + "','" + cbStatus.Text
                + "','" + txtAge.Text
                + "','" + txtAddress.Text
                + "','" + txtReligion.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding  is successfull!!!");
                Close();
            }
            else
            {// SELECT * FROM student StudentID, FName, LName, Mi, Dateofbirth, PlaceofBirth, Gender, CivilStatus, Age, Address, Religions;
                LogIn.q = "update Student set Fname = '" + txtFirstName.Text
                    + "', Lname = '" + txtLastName.Text
                    + "', Mi = '" + txtMiddleName.Text
                    + "', dateofbirth = '" + dtdateofbirth.Value.ToString("yyyy-MM-dd")
                    + "', placeofbirth = '" + txtPlaceOfBirth.Text
                    + "', gender = '" + cbGender.Text
                    + "', Age = '" + txtAge.Text
                    + "', civilstatus = '" + cbStatus.Text
                    + "', Address = '" + txtAddress.Text
                    + "', religion = '" + txtReligion.Text
                    + "'  where studentID = '" + Student.sStudentID + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is successfull");
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentSetting_Load(object sender, EventArgs e)
        {
            if (Student.sSave == "Edit")
            {
                txtFirstName.Text = Student.sFName;
                txtLastName.Text = Student.sLName;
                txtMiddleName.Text = Student.sMI;
                txtPlaceOfBirth.Text = Student.sPlaceofBirth;
                dtdateofbirth.Text = Student.sDateofBirth;
                txtReligion.Text = Student.sReligion;
                txtAddress.Text = Student.sAddress;
                txtAge.Text = Student.sAge;
                cbGender.Text = Student.sGender;
                cbGender.Text = Student.sCivilStatus;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

        
        