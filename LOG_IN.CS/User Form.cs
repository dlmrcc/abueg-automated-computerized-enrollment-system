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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            LogIn.q = "SELECT"
                + " UserID as `USER ID`,"//0
                + " Username AS `USER NAME`,"//1
                + " password,"//2
                + " FName,"//3
                + " LName,"//4
                + " concat(fname, ' ',lname) as fullname,"//5
                + " Usertype as `USER TYPE`,"//6
                + " Userstatus as `USER STATUS`,"//7
                + " SecurityQuestion,"//8
                + " SecurityAnswer,"//9
                + " Contactnumber as `CONTACT NUMBER`,"//10
                + " DateRegister FROM `user` u;";//11
            LogIn.vtable();
            dataGridView1.DataSource =LogIn.table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbresult.Text = dataGridView1.Rows.Count.ToString() + " User result has found!";
    }
        public static string sSave;
        private void button1_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            UserSetting s = new UserSetting();
            s.ShowDialog();
            User_Form_Load(sender, e);
        }
        public static string sUserID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sUserID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cbUserType.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
                cbUserStatus.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sUserID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cbUserType.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            cbUserStatus.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            UserSetting v = new UserSetting();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.FormBorderStyle = FormBorderStyle.FixedSingle;
            v.ShowDialog();
            User_Form_Load(sender, e);
        
       
        }

    }
}
