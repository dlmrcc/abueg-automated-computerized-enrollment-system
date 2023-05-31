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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        string sSecAns;
        string sPassword;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Enabled == false)
            {
                if (sSecAns.ToUpper() == txtSecAns.Text.ToUpper())
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your security answer didn't match", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                LogIn.q = "SELECT password, securityQuestion,securityAnswer FROM user where username='" + txtUsername.Text + "'";
                LogIn.vtable();
                if (LogIn.table.Rows.Count != 0)
                {
                    sPassword = LogIn.table.Rows[0][LogIn.table.Columns[0], DataRowVersion.Current].ToString();
                    lbSecQues.Text = LogIn.table.Rows[0][LogIn.table.Columns[1], DataRowVersion.Current].ToString();
                    sSecAns = LogIn.table.Rows[0][LogIn.table.Columns[2], DataRowVersion.Current].ToString();
                    panel3.Visible = true;
                    txtUsername.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Username does not exit!", "Invalid Username");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your password is (" + sPassword + ")", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}