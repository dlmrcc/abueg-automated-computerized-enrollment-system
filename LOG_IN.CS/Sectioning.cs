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
    public partial class Sectioning : Form
    {
        public Sectioning()
        {
            InitializeComponent();
        }
        public static String sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            SetioningSetting s = new SetioningSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Sectioning_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "";
            SetioningSetting s = new SetioningSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Sectioning_Load(sender, e);
        }

        private void Sectioning_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT sectioningID, Yearlevel, YearSection, SchoolYear FROM abueg.sectioning s;";
            LogIn.q = LogIn.q.ToUpper();
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public static string ssectioningID, sYearlevel, sYearSection, sSchoolYear;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
             {//SELECT sectioningID, Yearlevel, YearSection, SchoolYear FROM abueg.sectioning s;
                ssectioningID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sYearlevel = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sYearSection = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sSchoolYear = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                 
            }
            catch { }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
