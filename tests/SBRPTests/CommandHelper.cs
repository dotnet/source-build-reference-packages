using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SBRPTests;
internal class CommandHelper
{
    public static string CommandOutput(string command, string arguments,
                                       string workingDirectory = "")
    {
        try
        {
            ProcessStartInfo procStartInfo;
            procStartInfo = new ProcessStartInfo(command, arguments);
            procStartInfo.RedirectStandardError = procStartInfo.RedirectStandardInput = procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            if ("" != workingDirectory)
            {
                procStartInfo.WorkingDirectory = workingDirectory;
            }

            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();
            return output;
        }
        catch (Exception objException)
        {
            return $"Error in command: {command}, {objException.Message}";
        }
    }
}