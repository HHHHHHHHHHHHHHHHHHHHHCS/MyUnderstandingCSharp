using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _10_ListAndArrayList
    {
        ArrayList arrayList = new ArrayList();
        List<int> list = new List<int>();

        public void AddArrayListInt()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    arrayList.Add(i * j);
                }
            }
            sw.Stop();
            Console.WriteLine("AddArrayListInt:" + sw.Elapsed);
        }


        public void AddListInt()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    list.Add(i * j);
                }
            }
            sw.Stop();
            Console.WriteLine("AddListInt:" + sw.Elapsed);
        }
    }
}
