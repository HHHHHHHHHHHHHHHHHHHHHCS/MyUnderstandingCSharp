using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _06_IEnumerator
    {
        private int[] values = { 1, 2, 3, 4, 5, 6 };

        //因为C#1的迭代器过于冗长不想写...


        private IEnumerator<int> GetEnumberator(int startIndex)
        {
            for (int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startIndex) % values.Length];
            }
        }

        public void Test01()
        {
            _06_IEnumerator t = new _06_IEnumerator();
            var ie = t.GetEnumberator(3);
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        }


        private string padding = new string('/', 30);

        private IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine("{0}Start of CreateEnumerable()", padding);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}About to yeild{1}", padding, i);
                yield return i;
                Console.WriteLine("{0}Aftaer yeild", padding);
            }

            Console.WriteLine("{0}Yeilding final value", padding);

            yield return -1;

            Console.WriteLine("{0}End ofCreateEnumerable()", padding);
        }

        public void Test02()
        {
            IEnumerable<int> iterable = CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("Starting to iterate");

            while (true)
            {
                Console.WriteLine("Calling movenext");
                bool result = iterator.MoveNext();
                Console.WriteLine("...MoveNext result={0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("Fetching Current...");
                Console.WriteLine("...Current result ={0}", iterator.Current);
            }
        }

        private IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (DateTime.Now >= limit)
                    {
                        yield break;
                    }
                    yield return i;
                }
            }
            finally
            {
                Console.WriteLine("Stopping!!!");
            }
        }

        public void Test03()
        {
            DateTime stop = DateTime.Now.AddSeconds(3);

            foreach (int i in CountWithTimeLimit(stop))
            {
                Console.WriteLine("Received:{0}", i);
                Thread.Sleep(300);
            }
        }

        public void Test04()
        {
            DateTime stop = DateTime.Now.AddSeconds(3);

            foreach (int i in CountWithTimeLimit(stop))
            {
                Console.WriteLine("Received:{0}", i);
                if (i > 3)
                {
                    Console.WriteLine("Returning");
                    return;
                }
                Thread.Sleep(300);
            }
        }

        public void Test05()
        {
            DateTime stop = DateTime.Now.AddSeconds(3);
            IEnumerable<int> iterable = CountWithTimeLimit(stop);
            using (IEnumerator<int> iterator = iterable.GetEnumerator())
            {

                iterator.MoveNext();
                Console.WriteLine("Received:{0}", iterator.Current);

                iterator.MoveNext();
                Console.WriteLine("Received:{0}", iterator.Current);

                iterator.Dispose();
            }
        }


        private string str06Path = @"Test06.txt";

        public void Test06_01()
        {
            Console.WriteLine("Test06_01:");
            using (TextReader reader = File.OpenText(str06Path))
            {
                string line;
                while((line=reader.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        private IEnumerable<string> ReadLines_06()
        {
            using (TextReader reader = File.OpenText(str06Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        public void Test06_02()
        {
            Console.WriteLine("Test06_02:");
            foreach (var item in ReadLines_06())
            {
                Console.WriteLine(item);
            }
        }


        private IEnumerable<string> ReadLines_07(Func<TextReader> provider)
        {
            using (TextReader reader = provider())
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        private IEnumerable<string> ReadLines_07(string filename)
        {
            return ReadLines_07(delegate {
                return File.OpenText(filename);
            });
        }

        private IEnumerable<string> ReadLines_07()
        {
            return ReadLines_07(str06Path);
        }

        public void Test07()
        {
            Console.WriteLine("Test07:");
            foreach (var item in ReadLines_07())
            {
                Console.WriteLine(item);
            }
        }
    }
}
