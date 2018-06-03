using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _03_Boxing
    {

        public void Test01()
        {
            int i = 5;
            object o = i;
            o = 10;
            int j = (int)o;

            Console.WriteLine(string.Format("{0},{1},{2}", i, o, j));
        }

        public void Test02()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<Parent> list = new List<Parent>();

            for (int i = 0; i < 50000; i++)
            {
                list.Add(new Son1());

            }
            for (int i = 0; i < 50000; i++)
            {
                list.Add(new Son2());
            }


            for (int i = 0; i < 50000; i++)
            {
                list[i].Add();
            }
            for (int i = 50000; i < 100000; i++)
            {
                list[i].Add();
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public void Test03()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<Son1> list1 = new List<Son1>();
            List<Son2> list2 = new List<Son2>();

            for (int i = 0; i < 50000; i++)
            {
                list1.Add(new Son1());

            }
            for (int i = 0; i < 50000; i++)
            {
                list2.Add(new Son2());
            }


            for (int i = 0; i < 50000; i++)
            {
                list1[i].Add();
            }
            for (int i = 0; i < 50000; i++)
            {
                list1[i].Add();
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }

    public class Parent
    {
        public virtual int Add()
        {
            return 0;
        }
    }

    public class Son1 : Parent
    {
        public override int Add()
        {
            return 1 + 1;
        }
    }

    public class Son2 : Parent
    {
        public override int Add()
        {
            return 2 + 2;
        }
    }
}
