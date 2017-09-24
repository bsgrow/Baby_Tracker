; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Baby Tracker"
#define MyAppVersion "1.0"
#define MyAppPublisher "Brandon Grow"
#define MyAppURL "brandongrow@me.com"
#define MyAppExeName "Baby Tracker.exe"
#define DotNetRuntimeExe "NDP461-KB3102436-x86-x64-AllOS-ENU.exe"


[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A42ACEE4-520C-4D7C-9072-B84B94C24E74}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
OutputBaseFilename=Baby Tracker Installer
Compression=lzma
SolidCompression=yes



[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\x64\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\x86\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\Baby Tracker.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\BabyDatabase.sqlite"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\FirstNewTest.iss"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.barcodes.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.barcodes.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.forms.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.io.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.io.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.kernel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.kernel.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.layout.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.layout.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.pdfa.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.pdfa.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.sign.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itext.sign.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itextsharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\itextsharp.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\System.Data.SQLite.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\System.Data.SQLite.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\System.Data.SQLite.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Debug\System.Data.SQLite.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#DotNetRuntimeExe}"; DestDir: "{tmp}"; Flags: dontcopy nocompression noencryption

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Dirs]
Name: {app}; Permissions: users-full

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent; 



[CustomMessages]
InstallingDotNetFramework=Installing .NET Framework. This might take a few minutes...
DotNetFrameworkFailedToLaunch=Failed to launch .NET Framework Installer with error "%1". Please fix the error then run this installer again.
DotNetFrameworkFailed1602=.NET Framework installation was cancelled. This installation can continue, but be aware that this application may not run unless the .NET Framework installation is completed successfully.
DotNetFrameworkFailed1603=A fatal error occurred while installing the .NET Framework. Please fix the error, then run the installer again.
DotNetFrameworkFailed5100=Your computer does not meet the requirements of the .NET Framework. Please consult the documentation.
DotNetFrameworkFailedOther=The .NET Framework installer exited with an unexpected status code "%1". Please review any other messages shown by the installer to determine whether the installation completed successfully, and abort this installation and fix the problem if it did not.



[Code]
var
  requiresRestart: boolean;

// Detect .NET framework 4.6.1 is missing
// See https://msdn.microsoft.com/en-us/library/hh925568(v=vs.110).aspx
function DotNetIsMissing(): Boolean;
var
  readVal: cardinal;
  success: Boolean;
begin               
  success := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', readVal);
  success := success and ((readVal = 394254) or (readVal = 394271));
  Result := not success;
end;

// Adapted from https://blogs.msdn.microsoft.com/davidrickard/2015/07/17/installing-net-framework-4-5-automatically-with-inno-setup/
function InstallDotNet(): String;
var
  statusText: string;
  resultCode: Integer;
begin
  statusText := WizardForm.StatusLabel.Caption;
  WizardForm.StatusLabel.Caption := CustomMessage('InstallingDotNetFramework');
  WizardForm.ProgressGauge.Style := npbstMarquee;
  try
    ExtractTemporaryFile('{#DotNetRuntimeExe}');
    if not Exec(ExpandConstant('{tmp}\{#DotNetRuntimeExe}'), '/passive /norestart /showrmui /showfinalerror', '', SW_SHOW, ewWaitUntilTerminated, resultCode) then
    begin
      Result := FmtMessage(CustomMessage('DotNetFrameworkFailedToLaunch'), [SysErrorMessage(resultCode)]);
    end
    else
    begin
      // See https://msdn.microsoft.com/en-us/library/ee942965(v=vs.110).aspx#return_codes
      case resultCode of
        0: begin
          // Successful
        end;
        1602 : begin
          MsgBox(CustomMessage('DotNetFrameworkFailed1602'), mbInformation, MB_OK);
        end;
        1603: begin
          Result := CustomMessage('DotNetFrameworkFailed1603');
        end;
        1641: begin
          requiresRestart := True;
        end;
        3010: begin
          requiresRestart := True;
        end;
        5100: begin
          Result := CustomMessage('DotNetFrameworkFailed5100');
        end;
        else begin
          MsgBox(FmtMessage(CustomMessage('DotNetFrameworkFailedOther'), [IntToStr(resultCode)]), mbError, MB_OK);
        end;
      end;
    end;
  finally
    WizardForm.StatusLabel.Caption := statusText;
    WizardForm.ProgressGauge.Style := npbstNormal;
  end;
end;

function PrepareToInstall(var NeedsRestart: Boolean): String;
begin
  // 'NeedsRestart' only has an effect if we return a non-empty string, thus aborting the installation.
  // If the installers indicate that they want a restart, this should be done at the end of installation.
  // Therefore we set the global 'restartRequired' if a restart is needed, and return this from NeedRestart()

  if DotNetIsMissing() then
  begin
    Result := InstallDotNet();
  end;
end;

function NeedRestart(): Boolean;
begin
  Result := requiresRestart;
end