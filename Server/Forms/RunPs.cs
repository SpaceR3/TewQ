using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class RunPs : Form
    {
        public RunPs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.SendData("RUNPS|" + richTextBox1.Text + "@");
            MessageBox.Show("Done");
            this.Hide();
        }
    }
}
