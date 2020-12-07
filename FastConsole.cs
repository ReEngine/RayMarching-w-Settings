using System;
using System.IO;
using System.Text;

namespace SmthRender
{
    public static class FastConsole
    {
        private static readonly BufferedStream str;

        static FastConsole()
        {
            Console.OutputEncoding = Encoding.Unicode;  // crucial

            // avoid special "ShadowBuffer" for hard-coded size 0x14000 in 'BufferedStream' 
            str = new BufferedStream(Console.OpenStandardOutput(), 0x15000);
        }

        public static void WriteLine(string s)
        {
            Write(s + "\r\n");
        }

        public static void Write(string s)
        {
            // avoid endless 'GetByteCount' dithering in 'Encoding.Unicode.GetBytes(s)'
            byte[] rgb = new byte[s.Length << 1];
            Encoding.Unicode.GetBytes(s, 0, s.Length, rgb, 0);

            lock (str)   // (optional, can omit if appropriate)
            {
                str.Write(rgb, 0, rgb.Length);
            }

            Flush();
        }

        public static void Flush()
        {
            lock (str)
            {
                str.Flush();
            }
        }
    };
}
