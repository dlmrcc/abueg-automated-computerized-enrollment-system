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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Form.sSave = "Edit";
            UserSetting s = new UserSetting();
            s.ShowDialog();
        }
        void vCloseAll()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Student s = new Student();
            s.MdiParent = this;
            s.WindowState = FormWindowState.Maximized;
            s.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbUser.Text = LogIn.sFName + " " + LogIn.sLName;
            lbDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyy hh:mm:ss tt");
        }
        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Teacher a = new Teacher();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }
        private void requirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Requirements b = new Requirements();
            b.MdiParent = this;
            b.WindowState = FormWindowState.Maximized;
            b.Show();
        }
        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            User_Form u = new User_Form();
            u.MdiParent = this;
            u.WindowState = FormWindowState.Maximized;
            u.Show();
        }
        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Subject x = new Subject();
            x.MdiParent = this;
            x.WindowState = FormWindowState.Maximized;
            x.Show();
        }
        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Sectioning m = new Sectioning();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }
        private void studentRequirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfStudent r = new TypeOfStudent();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.ShowDialog();
        }
        private void permanentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCloseAll();
            Permanent p = new Permanent();
            p.MdiParent = this;
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void transfereeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            vCloseAll();
            Transferee b = new Transferee();
            b.WindowState = FormWindowState.Maximized;
            b.MdiParent = this;
            b.Show();
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Log - Out"
                , "Confirm Log - Out"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question)
                == DialogResult.No)
                e.Cancel = true;
        }
    }
}