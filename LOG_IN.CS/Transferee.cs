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
    public partial class Transferee : Form
    {
        public Transferee()
        {
            InitializeComponent();
        }

        private void Transferee_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT TransfereeID, StudentID, NameOfSchool, Address, YearAttended, SchoolYearAttended FROM transferee;";
           LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Visible = false;

        }
        public static string eTransfereeID, eStudentID, eNameOfSchool, eAddress, eYearAttended, eSchoolYearAttended;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                eTransfereeID= dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                eStudentID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                eNameOfSchool = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                eAddress = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                eYearAttended = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                eSchoolYearAttended = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
                
            }
            catch { }
        }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            TranfereeSetting s = new TranfereeSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Transferee_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            TranfereeSetting s = new TranfereeSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Transferee_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        

       

       

       

        }

        
   
      
    }
}
