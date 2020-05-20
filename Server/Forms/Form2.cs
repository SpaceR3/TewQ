using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void addt(string s)
        {
            richTextBox1.Invoke(new Action(() => { richTextBox1.Text += "\n" + s; }));        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
