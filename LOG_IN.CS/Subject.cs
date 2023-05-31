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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            SubjectSetting f = new SubjectSetting();
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.ShowDialog();
            Subject_Load(sender, e);
            
        }

        private void Subject_Load(object sender, EventArgs e)
        {//SubjectID, SubjectName, Units, SchoolYear
            LogIn.q = "SELECT SubjectID, SubjectName, Units, SchoolYear FROM subject ";
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public static string sSubjectID, sSubjectname, sUnits, sSchoolyear;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sSubjectID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sSubjectname = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sUnits = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sSchoolyear = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

            }

            catch { }
          }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            SubjectSetting f = new SubjectSetting();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.ShowDialog();
            Subject_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sSave = "Add";
            SubjectSetting k = new SubjectSetting();
            k.StartPosition = FormStartPosition.CenterScreen;
            k.FormBorderStyle = FormBorderStyle.FixedSingle;
            k.ShowDialog();
            Subject_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}
