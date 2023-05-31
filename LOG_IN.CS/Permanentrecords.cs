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
    public partial class Permanentrecords : Form
    {
        public Permanentrecords()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PermanentSetting b = new PermanentSetting();
            b.ShowDialog();
        }
        public static string sSave;
        private void Permanentrecords_Load(object sender, EventArgs e)
        {
  
            PermanentSetting m = new PermanentSetting();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PermanentSetting l = new PermanentSetting();
            l.ShowDialog();
        }
    }
}
