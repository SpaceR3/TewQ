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
    public partial class RMote : Form
    {
        public RMote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            timer1.Enabled = true;
        }
        Form1 f = new Form1();
        private void timer1_Tick(object sender, EventArgs e)
        {
            f.SendData("REMOTEC|@");
            Image img;
            using (var bmpTemp = new Bitmap("C:\\Users\\tewni\\Desktop\\nain\\now.png"))
            {
                img = new Bitmap(bmpTemp);
                panel1.BackgroundImage = img;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0) { return; }
            label2.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }

        private void RMote_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            f.SendData("CLICK|" + x + "@" + y);
        }
    }
}
