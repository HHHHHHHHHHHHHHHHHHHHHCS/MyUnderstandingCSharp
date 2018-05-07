using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _03__NullableValue
    {
        static void Display(int? x)
        {
            Console.WriteLine("HasValue:{0}",x.HasValue);
            if(x.HasValue)
            {
                Console.WriteLine("Value:{0}", x.Value);
                Console.WriteLine("Explicit conversion:{0}", (int)x);
            }
            Console.WriteLine("GetValueOrDefault():{0}", x.GetValueOrDefault());
            Console.WriteLine("GetValueOrDefault(10):{0}", x.GetValueOrDefault(10));
            Console.WriteLine("ToString:{0}", x.ToString());
            Console.WriteLine("GetHashCode:{0}", x.GetHashCode());
        }
        

        public void Test()
        {
            int? x = 5;
            x = new int?(5);
            Console.WriteLine("Instance With Value:");
            Display(x);

            x = new int?();
            Console.WriteLine("Instance With Value:");
            Display(x);
        }
    }
}
