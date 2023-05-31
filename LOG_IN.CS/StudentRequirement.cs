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
    public partial class StudentRequirement : Form1
    {
        public StudentRequirement()
        {
            InitializeComponent();
        }

        private void StudentRequirement_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT Student Requirement ID, Student ID, Requirement ID, School Year, UserID FROM studentrequirement s;";
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
        }
        public static string dStudentRequirementID, dStudentID, dRequirementID, dSchoolYear, dUserID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dStudentRequirementID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dStudentID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                dRequirementID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                dSchoolYear = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                dUserID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

            }
            catch { }
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            StudentSetting s = new StudentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            StudentRequirement_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            StudentSetting s = new StudentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            StudentRequirement_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
