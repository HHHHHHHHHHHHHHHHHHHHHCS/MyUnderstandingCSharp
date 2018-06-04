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

        public void Test03()
        {
            object y = null;
            Console.WriteLine(y.IsNull());
            int x = 3;
            Console.WriteLine(x.IsNull());
            string z = "2333";
            Console.WriteLine(z.IsNull());
        }

        public void Test04()
        {
            RangeEnumerable.Range01();
            RangeEnumerable.Range02();
            RangeEnumerable.Range03();
            RangeEnumerable.Range04();
            RangeEnumerable.Range05();
            RangeEnumerable.Range06();
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

    public static class NullUtil
    {
        public static bool IsNull(this object o)
        {
            return o == null;
        }

        public static bool IsNull(this string o)
        {
            return string.IsNullOrEmpty(o);
        }
    }

    public static class RangeEnumerable
    {
        public static void Range01()
        {
            var collection = Enumerable.Range(0, 10);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public static void Range02()
        {
            var collection = Enumerable.Range(0, 10).Reverse();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public static void Range03()
        {
            var collection = Enumerable.Range(0, 10)
                .Where(x => x % 3 == 0)
                .Reverse();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public static void Range04()
        {
            var collection = Enumerable.Range(0, 10)
                .Where(x => x % 3 == 0)
                .Select(x => new { Old = x, New = x * x })
                .Reverse();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public static void Range05()
        {
            var collection = Enumerable.Range(-5, 11)
                .Select(x => new { Old = x, New = x * x })
                .OrderBy(x => x.New)
                .ThenBy(x => x.Old);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public static void Range06()
        {
            var collection = Enumerable.Range(0, 36)
                .GroupBy(x => { var sqrt = Math.Sqrt(x); return sqrt == (int)sqrt; })
                .Select(x => new { Key =x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Key);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.WriteLine("//////////");
            }
            Console.WriteLine("----------------------------");
        }
    }

}
