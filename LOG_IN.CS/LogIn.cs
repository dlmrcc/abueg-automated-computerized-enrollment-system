using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LOG_IN.CS
{
    public partial class LogIn : Form
    {
        public static MySqlConnection cn = new MySqlConnection("data source = localhost; username = root; password = ; database = abueg;");
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static MySqlCommand cmd;
        public static MySqlDataReader rd;
        public static DataTable table;
        public static String q;
        public LogIn()
        {
            InitializeComponent();
        }
        public static void vtable()  
        {
            table = new DataTable();
            da.SelectCommand = new MySqlCommand(q, cn);
            da.Fill(table);
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "winwin";
            txtUsername.Text = "alwinnn";
            bnLogIn_Click(sender, e);
        }
        public static String suserID, suserName, spassword, sFName, sLName, suserType, suserStatus, scontactNumber, securityAnswer, securityQuestion, sdateRegister;
        private void bnLogIn_Click(object sender, EventArgs e)
        {//                 0       1       2       3       4       5           6           7                   8               9           10
            if (txtUsername.Text.Length < 6)
            {
                MessageBox.Show("Mababa sa 6 na letra");
            }
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mababa sa 6 na letra");
            }
            else
            {
                q = "SELECT userID, userName, password, FName, LName, userType, userStatus, contactNumber, securityAnswer, securityQuestion, dateRegister FROM user where userName = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                vtable();
                q = q.ToUpper();
                LogIn.vtable();
                if (table.Rows.Count != 0)
                {
                    suserID = table.Rows[0][table.Columns[0], DataRowVersion.Current].ToString();
                    suserName = table.Rows[0][table.Columns[01], DataRowVersion.Current].ToString();
                    spassword = table.Rows[0][table.Columns[02], DataRowVersion.Current].ToString();
                    sFName = table.Rows[0][table.Columns[03], DataRowVersion.Current].ToString();
                    sLName = table.Rows[0][table.Columns[04], DataRowVersion.Current].ToString();
                    suserType = table.Rows[0][table.Columns[05], DataRowVersion.Current].ToString();
                    suserStatus = table.Rows[0][table.Columns[06], DataRowVersion.Current].ToString();
                    scontactNumber = table.Rows[0][table.Columns[07], DataRowVersion.Current].ToString();
                    securityAnswer = table.Rows[0][table.Columns[08], DataRowVersion.Current].ToString();
                    securityQuestion = table.Rows[0][table.Columns[09], DataRowVersion.Current].ToString();
                    sdateRegister = table.Rows[0][table.Columns[10], DataRowVersion.Current].ToString();
                    Hide();
                    Home F = new Home();
                    F.WindowState = FormWindowState.Maximized;
                    F.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Invalid Input");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password f = new Forgot_Password();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    