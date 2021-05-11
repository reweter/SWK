using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace SWK_Server
{
    public class Server
    {
        public string Ip { get; set; }
        public int Port { get; set; }

        public bool Status { get { return Listener.Server.Connected; } }

        public TcpListener Listener { get; set; }

        public Thread ServerProcess { get; set; }

        public static object locker = new object();

        public UserData Users { get; set; }

        public Server(string ip, int port)
        {
            Ip = ip;
            Port = port;
            Users = new UserData();
            Listener = new TcpListener(System.Net.IPAddress.Parse(ip), port);
            Listener.Start();
            ServerProcess = new Thread(Process);
            ServerProcess.Start();
        }

        public byte[] SendDataUser(User user, byte[] data)
        {
            try
            {
                lock (locker)
                {
                    BinaryWriter bw = new BinaryWriter(user.Stream);
                    bw.Write(data.Length);
                    bw.Write(data);

                    byte[] ResponseData;

                    do
                    {
                        BinaryReader br = new BinaryReader(user.Stream);
                        int length = br.ReadInt32();
                        ResponseData = br.ReadBytes(length);
                    }
                    while (user.Stream.DataAvailable);

                    return ResponseData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server.SendDataUser Exception: " + ex.Message);
                return Encoding.Default.GetBytes("Server.SendDataUser Exception: " + ex.Message);
            }
        }

        public void Process()
        {
            try
            {
                while (true)
                {
                    TcpClient Client = Listener.AcceptTcpClient();
                    User User = new User(Client);
                    Users.Add(User);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server.Process Exception: " + ex.Message);
            }
        }
    }
}
