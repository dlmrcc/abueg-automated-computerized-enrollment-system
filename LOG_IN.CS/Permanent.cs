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
    public partial class Permanent : Form
    {
        public Permanent()
        {
            InitializeComponent();
        }

        private void Permanent_Load(object sender, EventArgs e)
        {
            LogIn.q = " SELECT Permanentid, Subjectid, 1stGrading, 2ndGrading, 3rdGrading, 4thGrading, FinalRating, UserID, Studentid, SchoolYear, YearLevel, SchoolName, Remarks, TeacherID FROM permanentrecord p;";
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public static string ppermanentid, psubjectid, p1stgrading,  p2ndgrading, p3rdgrading, p4thgrading, pFinalRating, pUserID, pStudentID, pSchoolYear, pYearLevel, pSchoolName, pRemarks, pTeacherID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ppermanentid = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                psubjectid = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                p1stgrading = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                p2ndgrading = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                p3rdgrading = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                p4thgrading = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
                pFinalRating = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                pUserID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
                pStudentID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
                pSchoolYear = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
                pYearLevel = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString();
                pSchoolName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString();
                pRemarks = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[12].Value.ToString();
                pTeacherID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[13].Value.ToString();


            }
            catch { }
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            PermanentSetting s = new PermanentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Permanent_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            PermanentSetting s = new PermanentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Permanent_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 
    }
}
