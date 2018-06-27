using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._05_Five
{
    public class _02_T
    {
        public void Test01()
        {
            //list Capacity 是它的默认长度  如果长度不够则创建一个新的 再讲老的复制过去 有性能开销
            //list Capacity *2的扩大

            List<int> list1 = new List<int>(10);

            Console.WriteLine(list1.Capacity);

            List<int> list2 = new List<int>();
            Console.WriteLine(list2.Capacity);
            for (int i=0;i<17;i++)
            {
                list2.Add(i);
                Console.WriteLine(i+"///"+list2.Capacity);
            }
        }

    }
}
