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
    public partial class SetioningSetting : Form
    {
        public SetioningSetting()
        {
            InitializeComponent();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            if (Sectioning.sSave == "Add")
            {
                LogIn.q = "insert into Sectioning values (null,'" + txtED.Text 
                + "','" + txtYS.Text
                + "','" + txtUD.Text + "')";
                LogIn.vtable();
                MessageBox.Show("Adding is successfull!!!");
                Close();    
            }
            else
            {
                LogIn.q = "update Sectioning set Yearlevel = '" + txtED.Text
                    + "', YearSection = '" + txtYS.Text
                    + "', SchoolYear = '" + txtUD.Text
                    + "'  where sectioningID = '"+ Sectioning.ssectioningID + "'";
                LogIn.vtable();
                MessageBox.Show("Editing is Successfull");
        }
    }

        private void SetioningSetting_Load(object sender, EventArgs e)
        {
            if (Sectioning.sSave == "Edit")
            {
                txtED.Text = Sectioning.sYearlevel;
                txtYS.Text = Sectioning.sYearSection;
                txtUD.Text = Sectioning.sSchoolYear;
            }

         }
     }
}
