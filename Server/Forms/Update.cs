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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            Byte[] bytes = File.ReadAllBytes(textBox1.Text);
            String file = Convert.ToBase64String(bytes);
            form1.SendData("RUNFILE|" + file + "@.txt");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBox1.Text = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("ERROR! lINE 35 IN RunFromLocal.cs");
                }
            }
        }
    }
}
