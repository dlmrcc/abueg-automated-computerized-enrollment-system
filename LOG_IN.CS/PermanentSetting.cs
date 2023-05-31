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
    public partial class PermanentSetting : Form
    {
        public PermanentSetting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Permanent.sSave == "Add")
            {

             LogIn.q = "insert into Permanentrecord values (null,'" + txtSubjectid.Text 
                + "','" + txt1stgrading.Text
                + "','" + txt2grading.Text
                + "','" + txt3grading.Text
                + "','" + txt4grading.Text
                + "','" + txtFinalrating.Text
                + "','" + txtUserid.Text
                + "','" + txtStudentid.Text
                + "','" + txtSchoolyear.Text
                + "','" + txtYearlevel.Text
                + "','" + txtSchoolname.Text
                + "','" + txtRemarks.Text
                + "','" + txtteacherid.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding is successfull!!!");
                Close();    
            }
            else
            {//SubjectID, PermanentRecord, PeriodicRating1, PeriodicRating2, PeriodicRating3, PeriodicRating4, FinalRating, UserID, StudentID, SchoolYear, YearLevel, SchoolName, Remarks, TeacherID
                LogIn.q = "update permanentrecord set subjectid = '" + txtSubjectid.Text
                    + "', 1stGrading = '" + txt1stgrading.Text
                    + "', 2ndGrading = '" + txt2grading.Text
                    + "', 3rdGrading = '" + txt3grading.Text
                    + "', 4thGrading = '" + txt4grading.Text
                    + "', Finalrating = '" + txtFinalrating.Text
                     + "', Userid = '" + txtUserid.Text
                      + "', Studentid = '" + txtStudentid.Text
                       + "', Schoolyear= '" + txtSchoolyear.Text
                        + "', Yearlevel = '" + txtYearlevel.Text
                         + "', Schoolname = '" + txtSchoolname.Text
                          + "', Remarks = '" + txtRemarks.Text
                             + "', TeacherId = '" + txtteacherid.Text
                    + "'  where Permanentid = '" + Permanent.ppermanentid + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is Successfull");
            }//public static string pSubjectID, pPermanentRecord, pPeriodicRating1, pPeriodicRating2, pPeriodicRating3, pPeriodicRating4, pFinalRating, pUserID, pStudentID, pSchoolYear, pYearLevel, pSchoolName, pRemarks, pStudentID;
        }
       
        private void PermanentSetting_Load(object sender, EventArgs e)
        {
            if (Permanent.sSave == "Edit")
            {
                txtSubjectid.Text = Permanent.psubjectid;
                txt1stgrading.Text = Permanent.p1stgrading;
                txt2grading.Text = Permanent.p2ndgrading;
                txt3grading.Text = Permanent.p3rdgrading;
                txt4grading.Text = Permanent.p4thgrading;
                txtFinalrating.Text = Permanent.pFinalRating;
                txtUserid.Text = Permanent.pUserID;
                txtStudentid.Text = Permanent.pStudentID;
                txtSchoolyear.Text = Permanent.pSchoolYear;
                txtYearlevel.Text = Permanent.pYearLevel;
                txtSchoolname.Text = Permanent.pSchoolName;
                txtRemarks.Text = Permanent.pRemarks;
                txtStudentid.Text = Permanent.pStudentID;
            }
        }

         
    }
}
