using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    class _05_AnonymousDelegate
    {
        private Action<string> printDoubleString = delegate (string s)
          {
              s += s;
              Console.WriteLine(s);
          };

        private static void SortAndShowFiles(string title, Comparison<FileInfo> sortOrder)
        {
            FileInfo[] files = new DirectoryInfo(@"C:\").GetFiles();
            Array.Sort(files, sortOrder);
            Console.WriteLine(title);
            foreach (FileInfo file in files)
            {
                Console.WriteLine("{0}  [{1} bytes]", file.Name, file.Length);
            }
        }

        public void Test1()
        {
            printDoubleString("Test");
        }

        public void Test2()
        {
            SortAndShowFiles("Sort by Name:", delegate (FileInfo f1, FileInfo f2)
             { return f1.Name.CompareTo(f2.Name); });
            SortAndShowFiles("Sort by Length:", delegate (FileInfo f1, FileInfo f2)
            { return f1.Length.CompareTo(f2.Length); });
        }

        public void Test3()
        {
            string str = "before x is created";
            Console.WriteLine(str);
            Action act = delegate
            {
                Console.WriteLine(str);
                str = "change x  is changed";
            };
            str = "x will invoke";
            act();
            Console.WriteLine(str);
            str = "x have invoked";
            act();
            Console.WriteLine(str);
        }


        private Action Test4Delegate()
        {
            int counter = 5;
            Action t = delegate
            {
                Console.WriteLine("Action:" + counter);
                counter++;
            };
            t();
            Console.WriteLine("Test4Delegate:" + counter);
            return t;
        }

        public void Test4()
        {
            Action act = Test4Delegate();

            act();

            act();
        }

        private List<Action> Test5Delegate()
        {
            List<Action> list = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                int counter = i * 10;
                list.Add(delegate
                {
                    Console.WriteLine(counter);
                    counter++;
                });

            }
            return list;
        }

        public void Test5()
        {
            Console.WriteLine("-----Test5-----");
            List<Action> actList = Test5Delegate();

            actList[0]();
            actList[0]();
            actList[0]();

            actList[1]();
        }

        private List<Action> Test6Delegate()
        {
            List<Action> list = new List<Action>();
            int counter;
            for (int i = 0; i < 5; i++)
            {
                counter = i * 10;
                list.Add(delegate
                {
                    Console.WriteLine(counter);
                    counter++;
                });

            }
            return list;
        }

        public void Test6()
        {
            Console.WriteLine("-----Test6-----");
            List<Action> actList = Test6Delegate();

            actList[0]();
            actList[0]();
            actList[0]();

            actList[1]();
        }
    }
}
