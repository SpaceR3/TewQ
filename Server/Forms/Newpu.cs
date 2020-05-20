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
    public partial class Newpu : Form
    {
        public Newpu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.SendData("RUN_PY|" + richTextBox1.Text + "@" + textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
