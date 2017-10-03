; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Baby Tracker"
#define MyAppVersion "1.0"
#define MyAppPublisher "Brandon Grow"
#define MyAppURL "brandongrow@me.com"
#define MyAppExeName "Baby Tracker.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{37A7C8B1-2A9B-4378-A1CF-A5F3B4A95E48}
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
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\x64\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\x86\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\Baby Tracker.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.barcodes.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.barcodes.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.forms.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.io.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.io.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.kernel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.kernel.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.layout.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.layout.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.pdfa.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.pdfa.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.sign.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itext.sign.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itextsharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\itextsharp.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\System.Data.SQLite.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\System.Data.SQLite.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\System.Data.SQLite.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\bin\Release\System.Data.SQLite.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyBoy1.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyBoy2.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyGirl1.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyGirl2.png"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Dirs]
Name: {app}; Permissions: users-full

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
