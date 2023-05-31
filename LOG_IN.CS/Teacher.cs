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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT TeacherID, Fname, Mname, Lname, Address, ContactNumber, Position, TeacherStatus FROM teacher t where fname like '%"+txtSearch.Text+"%'";
            LogIn.q = LogIn.q.ToUpper();
            LogIn.vtable();
            dataGridView1.DataSource = LogIn.table;
            dataGridView1.Columns[1].Visible=true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label2.Text = dataGridView1.Rows.Count + " teacher result has been found";
        }
        public static string tTeacherID, tFname, tMname, tLname, tAddress, tContactNumber, tPosition, tTeacherStatus;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tTeacherID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                tFname = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                tMname = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                tLname = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                tAddress = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                tContactNumber = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
                tPosition = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                tTeacherStatus = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();

            }
            catch { }
        }
        public static String sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            TeacherSetting s = new TeacherSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Teacher_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            TeacherSetting s = new TeacherSetting();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.FormBorderStyle = FormBorderStyle.FixedSingle;
            s.ShowDialog();
            Teacher_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = prTeacher;
                MyPrintPreviewDialog.ShowDialog();
                prTeacher.Print();
            }

        }

        private void prTeacher_PrintPage(object sender, PrintPageEventArgs e)
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
            prTeacher.DocumentName = "GAASNTVMHS Info";
            prTeacher.PrinterSettings = MyPrintDialog.PrinterSettings;
            prTeacher.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            prTeacher.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            prTeacher.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dataGridView1, prTeacher, true, true, "GAASNVMHS Info"
                , new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Teacher_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
       
        }
    }


