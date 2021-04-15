using System;
using System.IO;
using System.Net;

namespace Updater
{
    internal class Program
    {
        private static WebClient webClient = null;
        private static readonly string FolderUrl = "https://www.dropbox.com/sh/h5py02wtv8jrv5g/AACp_YOIjTZmrfGESkLoRiX0a?dl=0";
        private static readonly string DownloadFolder = $"{Environment.GetLogicalDrives()[0]}/Users/{Environment.UserName}/Downloads";

        [STAThread]
        internal static void Main(string[] args)
        {
            if (!CheckUpdate())
            {
                LealPassword.Program.Run(args, "1.8.5.0");
                return;
            }

            webClient = new WebClient();
            webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(FolderUrl, $"{DownloadFolder}/LealPassword.zip");
            webClient.Dispose();
        }

        private static bool CheckUpdate()
        {
            

            return false;
        }
    }
}
