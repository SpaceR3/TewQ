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
    public partial class File_Manager : Form
    {
        public File_Manager()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        void GetDir(string path = @"C:\")
        {
            f.SendData("SHOWDIR|" + path + "@");
        }
        void GetFiles(string path = @"C:\", string jh = "")
        {
            f.SendData("SHOWFILE|" + path + "@");
            string oks = File.ReadAllText(@"C:\Users\tewni\Desktop\nain\temps.txt");
            foreach (String name in oks.Split('@'))
            {
                //    MessageBox.Show(name);
                string name2 = name.Replace("/", "\\");
                try { MessageBox.Show(name2.Replace("C:\\", ""), "");  File.WriteAllText(@"C:\Users\tewni\Desktop\nain\FOLDER\" + name2.Replace("C:\\", ""),""); } catch { }
            }
        }
        private void File_Manager_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"C:\Users\tewni\Desktop\nain\FOLDER");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private async void panel1_Click(object sender, EventArgs e)
        {

        }

        private async void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string newone = webBrowser1.Url.ToString().Replace("FOLDER/","").Substring(webBrowser1.Url.ToString().LastIndexOf("FOLDER"));
            GetDir(@"C:\" + newone.Replace("/","\\"));
            GetFiles(@"C:\" + newone.Replace("/", "\\"),newone);
            //await Task.Delay(1500);
            string oks = File.ReadAllText(@"C:\Users\tewni\Desktop\nain\temp.txt");
            foreach (String name in oks.Split('@'))
            {
                //    MessageBox.Show(name);
                string name2 = name.Replace("/","\\");
                try {  Directory.CreateDirectory(@"C:\Users\tewni\Desktop\nain\FOLDER\" + name2.Replace("C:\\", "")); } catch { }
            }
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
