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
    public partial class TypeOfStudent : Form
    {
        public TypeOfStudent()
        {
            InitializeComponent();
        }

        private void TypeOfStudent_Load(object sender, EventArgs e)
        {
           
        }
        string sStudentType;
        string[] requirementid;
        private void cbStudenttype_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbStudenttype.SelectedIndex == 0)
            {
                sStudentType = "New";
                StudentSetting.sSave = "Add";
                StudentSetting s = new StudentSetting();
                s.StartPosition = FormStartPosition.CenterScreen;
                s.ShowDialog();
            }
            else if (cbStudenttype.SelectedIndex == 1)
            {
                sStudentType = "Old";
               student_Information.sSave = "Add";
               student_Information s = new student_Information();
                s.StartPosition = FormStartPosition.CenterScreen;
                s.ShowDialog();
            }
            else
            {
                sStudentType = "Transferee";
                TranfereeSetting t = new TranfereeSetting();
                t.ShowDialog();
               
            
                
            }
            LogIn.q = "select requirementsname,requirementid from requirements where typeofstudent = '" + sStudentType + "'";
            LogIn.vtable();
            checkedListBox1.Items.Clear();
            requirementid = new string[LogIn.table.Rows.Count];
            for (int a = 0; a < LogIn.table.Rows.Count; a++)
            {
                checkedListBox1.Items.Add(LogIn.table.Rows[a][LogIn.table.Columns[0], DataRowVersion.Current]);
                requirementid[a] = LogIn.table.Rows[a][LogIn.table.Columns[1], DataRowVersion.Current].ToString();
            }
        }

        private void bnContinue_Click(object sender, EventArgs e)
        {
            StudentSetting s = new StudentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.ShowDialog();
        }
    }
}
