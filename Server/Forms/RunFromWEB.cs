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
    public partial class RunFromWEB : Form
    {
        public RunFromWEB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.SendData("RUNFROMWEB|" + textBox1.Text + "@.txt");
            this.Hide();
        }
    }
}
