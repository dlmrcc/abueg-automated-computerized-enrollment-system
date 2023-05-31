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
    public partial class SubjectSetting : Form
    {
        public SubjectSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Subject.sSave == "Add")
            {//SubjectID, SubjectName, Units, SchoolYear
                LogIn.q = "insert into Subject values(null, '" + txtSubjectN.Text
                    + "', '" + txtUnits.Text
                    + "', '" + txtSchoolyear.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding is successfull");
            }
            else
            {
                LogIn.q = "update Subject set Subjectname = '" + txtSubjectN.Text
                    + "', Units = '" + txtUnits.Text
                    + "', Schoolyear = '" + txtSchoolyear.Text
                    + "' where SubjectID = '" + Subject.sSubjectID + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is Successfull");
            }
        }
    }
}
