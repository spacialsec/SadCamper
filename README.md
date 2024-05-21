# SadCamper
SadCamper is a tool designed for security personnel to prevent the exfiltration of critically sensitive files from an organization.  It works by preemptively relocating files, adding an additional layer of security by potentially thwarting attackers' attempts to identify and exfitrate these files.

### ⚠️ Warning
SadCamper manipulates critical sensitive files to prevent threat actor access.  It may cause a small amount of impact to the systems containing these files.

### How it works
RFLR works by utilizing various state of the art techniques to prevent the identification and exfiltration of sensitive files.  This means that even if attackers can navigate a system's defenses and execute code, identifying files for exfiltration can lead them to a halt. For example, by relocating all the files on a windows filesystem to the recycling bin, data exfiltraiton scripts that rely on sensitive files being in certain directories (C:\Users, C:\Windows) will be stopped in their tracks.  This approach, while simple, adds a significant hurdle for attackers, especially those relying on automated tools and scripts that expect these binaries to reside at known locations.

You can learn more about RFLR here: https://www.spatial-sec.com/blog/post/21/index.html
