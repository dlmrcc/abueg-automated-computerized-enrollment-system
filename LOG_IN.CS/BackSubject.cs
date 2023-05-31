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
    public partial class BackSubject : Form
    {
        public BackSubject()
        {
            InitializeComponent();
        }

        private void BackSubject_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT BackSubjectID, SubjectID, TransferreID FROM `back subject tbl` b;";
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
        }
        public static string bBackSubjectID, bSubjectID, bTransferreID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bBackSubjectID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                bSubjectID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                bTransferreID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
               
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
            BackSubject_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            StudentSetting s = new StudentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            BackSubject_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
