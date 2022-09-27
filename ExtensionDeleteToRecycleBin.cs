using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ALL_LEGIT
{
    /// <summary>  
    /// ExtensionDeleteToRecycleBin.cs  
    /// </summary>  
    public static class ExtensionDeleteToRecycleBin
    {
        public static Dictionary<string, string> DeleteDict = new Dictionary<string, string>();

        /// <summary>  
        /// Delete File To Recycle Bin  
        /// WARMING: NETWORK FILES DON'T GO TO RECYCLE BIN  
        /// </summary>  
        /// <param name="file"></param>  
        public static void FileRecycle(this string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file,
                    Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                    Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch
            {
                CmdKILL("7zfm");
                CmdKILL("7z");
                FileRecycle(file);
            }
        }
        /// <summary>  
        /// Delete Path To Recycle Bin  
        /// WARMING: NETWORK PATHS DON'T GO TO RECYCLE BIN  
        /// </summary>  
        /// <param name="path"></param>  
        public static void DirectoryRecycle(this string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(path,
                        Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch
            {
                CmdKILL("7zfm");
                CmdKILL("7z");
                FileRecycle(path);
            }

        }
        public static void CmdKILL(string appname)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                if (process.ProcessName.Contains(appname))
                {
                    ProcessStartInfo info = new ProcessStartInfo(@"cmd.exe");
                    info.UseShellExecute = true;
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    info.UseShellExecute = true;
                    info.Arguments = $"/C WMIC PROCESS WHERE \"Name Like '%{appname}%'\" CALL Terminate 1>nul 2>nul";
                    Process.Start(info);
                }
            }

        }
    }
}