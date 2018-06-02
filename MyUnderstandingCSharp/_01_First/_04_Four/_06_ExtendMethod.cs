using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public class _06_ExtendMethod
    {

        public void Test01()
        {
            WebRequest request = WebRequest.Create("http://www.baidu.com/");
            using (WebResponse response = request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream output = File.Create("response01.txt"))
                    {
                        StreamUtil01.Copy(responseStream, output);
                    }
                }
            }
        }

        public void Test02()
        {
            WebRequest request = WebRequest.Create("http://www.qq.com/");
            using (WebResponse response = request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream output = File.Create("response02.txt"))
                    {
                        responseStream.Copy(output);
                    }
                }
            }
        }
    }

    public static class StreamUtil01
    {
        private const int bufferSize = 1024;

        public static void Copy(Stream input, Stream output)
        {
            byte[] buffer = new byte[bufferSize];
            int read;
            while ((read = input.Read(buffer, 0, bufferSize)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                Copy(input, tempStream);
                return tempStream.ToArray();
            }
        }
    }

    public static class StreamUtil02
    {
        private const int bufferSize = 1024;

        public static void Copy(this Stream input, Stream output)
        {
            byte[] buffer = new byte[bufferSize];
            int read;
            while ((read = input.Read(buffer, 0, bufferSize)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static byte[] ReadFully(this Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                Copy(input, tempStream);
                return tempStream.ToArray();
            }
        }
    }
}
