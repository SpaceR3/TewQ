using Server.Properties;
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
    public partial class Task_Manager : Form
    {
        public Task_Manager()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        void doitnow()
        {
            dataGridView1.Rows.Clear();
            form.SendData("GETPRCC|@");
            string theones = File.ReadAllText(@"C:\Users\tewni\Desktop\nain\tempProcess.txt");
            foreach(string g in theones.Split('@'))
            {
                try { dataGridView1.Rows.Add(g.Split('?')[0], g.Split('?')[1], g.Split('?')[2]); } catch { }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            doitnow();
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.SendData("KISL|" + selected2 + "@");
        }
    }
}
