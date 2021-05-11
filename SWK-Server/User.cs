using System;
using System.IO;
using System.Net.Sockets;
using static SWK_Server.ApplicationData;

namespace SWK_Server
{
    public class User
    {
        public string UserName { get; set; }
        public string Ip { get; set; }
        public string Path { get; set; }

        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }

        public User(TcpClient client)
        {
            try
            {
                Client = client;
                Stream = Client.GetStream();

                UserName = Crypto.BytesToString(server.SendDataUser(this, Crypto.StringToBytes("/UserName")));
                Ip = Crypto.BytesToString(server.SendDataUser(this, Crypto.StringToBytes("/ExternalIp")));

                Path = UsersDataPath + @"\" + UserName;

                if (!File.Exists(Path))
                    Directory.CreateDirectory(Path);

                using (StreamWriter sw = new StreamWriter(File.Open(Path + @"\Data.txt", FileMode.OpenOrCreate)))
                {
                    sw.WriteLine("UserName: " + UserName);
                    sw.WriteLine("Ip: " + Ip);
                    sw.WriteLine("Path: " + Path);
                    sw.WriteLine("ConnectTime: " + DateTime.Now.ToString("mm.HH dd.MM.yyyy"));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("User.ctor Exception: " + ex.Message);
            }
        }
    }
}
