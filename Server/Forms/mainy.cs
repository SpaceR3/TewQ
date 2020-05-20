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
    public partial class mainy : Form
    {
        public mainy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.SendData("H1T|" + textBox1.Text + "@" + textBox2.Text);
            this.Hide();
        }
    }
}
