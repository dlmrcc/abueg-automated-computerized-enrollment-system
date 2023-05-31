using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace LOG_IN.CS
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        
        }
        private void Student_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT StudentID, FName, LName, MI, DateofBirth, PlaceofBirth, Gender, CivilStatus, Age, Address, Religion FROM student where concat(fname,' ',mi,' ',lname) like '%" + textBox2.Text + "%'";
            LogIn.q = LogIn.q.ToUpper();
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].HeaderText = "FIRST NAME";
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label2.Text = dataGridView1.Rows.Count + " student result has been found";

        }
        public static string sStudentID, sFName, sLName, sMI, sDateofBirth, sPlaceofBirth, sGender, sCivilStatus, sAge, sAddress, sReligion;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sStudentID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sFName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sLName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sMI = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sDateofBirth = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sPlaceofBirth = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
                sGender = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                sCivilStatus = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
                sAddress = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
                sReligion = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
                sAge = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString();


            }
            catch { }
        }
        public static string sSave;
        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            StudentSetting s = new StudentSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Student_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = prStudent;
                MyPrintPreviewDialog.ShowDialog();
                prStudent.Print();
            }

        }

        private void prStudent_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;

        }
        Printing print;
        private bool SetupThePrinting()
        {

            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            prStudent.DocumentName = "GAASNTVMHS Info";
            prStudent.PrinterSettings = MyPrintDialog.PrinterSettings;
            prStudent.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            prStudent.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            prStudent.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dataGridView1, prStudent, true, true, "GAASNTVMHS Info"
                , new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            return true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Student_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}