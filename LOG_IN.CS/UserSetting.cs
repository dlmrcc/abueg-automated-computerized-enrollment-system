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
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRetypepass.Text)
            {
                if (User_Form.sSave == "Add")
                {
                    LogIn.q = "insert into USER (UserID, Username, password, FName, LName,"
                        + " Usertype, Userstatus, SecurityQuestion, SecurityAnswer, Contactnumber, DateRegister)"
                        + " values (null,'" + txtUsername.Text
                        + "','" + txtPassword.Text
                        + "','" + txtFN.Text
                        + "','" + txtLN.Text
                        + "','" + "Staff"
                        + "','" + "Active"
                        + "','" + cbSQ.Text
                        + "','" + txtSA.Text
                        + "','" + txtCN.Text
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                        + "')";
                    LogIn.vtable();
                    MessageBox.Show("Adding is successfull!!!");
                }
                else
                {
                    LogIn.q = "update user set Username = '" + txtUsername.Text
                        + "', password = '" + txtPassword.Text
                        + "', Fname = '" + txtFN.Text
                        + "', Lname = '" + txtLN.Text
                        + "', SecurityQuestion = '" + cbSQ.Text
                        + "', SecurityAnswer = '" + txtSA.Text
                        + "', ContactNumber = '" + txtCN.Text
                        + "' where UserId = '" + LogIn.suserID
                        + "'";
                    LogIn.vtable();
                    MessageBox.Show("Editing is Successfull");
                    LogIn.suserName = txtUsername.Text;
                    LogIn.spassword = txtPassword.Text;
                    LogIn.spassword = txtRetypepass.Text;
                    LogIn.sFName = txtFN.Text;
                    LogIn.sLName = txtLN.Text;
                    LogIn.scontactNumber = txtCN.Text;
                    LogIn.securityQuestion = cbSQ.Text;
                    LogIn.securityAnswer = txtSA.Text;
                }
                Close();
            }
            else
            {
                MessageBox.Show("Password and retype password did not match!", "Invalid input");
            }
        }
        private void UserSetting_Load(object sender, EventArgs e)
        {
            if (User_Form.sSave == "Edit")
            {
                txtUsername.Text = LogIn.suserName;
                txtPassword.Text = LogIn.spassword;
                txtRetypepass.Text = LogIn.spassword;
                txtFN.Text = LogIn.sFName;
                txtLN.Text = LogIn.sLName;
                txtCN.Text = LogIn.scontactNumber;
                cbSQ.Text = LogIn.securityQuestion;
                txtSA.Text = LogIn.securityAnswer;
            }
        }
    }
}