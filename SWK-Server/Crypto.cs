using System.Text;

namespace SWK_Server
{
    public static class Crypto
    {
        public static string BytesToString(byte[] data)
        {
            return Encoding.Default.GetString(data);
        }

        public static byte[] StringToBytes(string data)
        {
            return Encoding.Default.GetBytes(data);
        }
    }
}
