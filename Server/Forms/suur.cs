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
    public partial class suur : Form
    {
        public suur()
        {
            InitializeComponent();
        }
        string amount = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if (amount == "")
                MessageBox.Show("Please SET RQ amount");
            f.SendData("SUUR|" + textBox1.Text + " 80@" + amount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            amount = textBox2.Text;
        }
    }
}
