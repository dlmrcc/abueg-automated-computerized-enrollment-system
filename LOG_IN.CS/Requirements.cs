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
    public partial class Requirements : Form
    {
        public Requirements()
        {
            InitializeComponent();
        }

        private void Requirements_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT RequirementID, SchoolYear, RequirementsName, TypeOfStudent FROM requirements r;";
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public static string rRequirementID, rSchoolYear, rRequirementsName, rTypeOfStudent;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                rRequirementID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                rSchoolYear = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                rRequirementsName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                rTypeOfStudent = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
     
            }
            catch { }
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            RequirementsSetting s = new RequirementsSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Requirements_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            RequirementsSetting s = new RequirementsSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Requirements_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        }
    }

