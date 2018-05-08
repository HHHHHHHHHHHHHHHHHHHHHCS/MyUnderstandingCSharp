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
        
        /// <summary>
        /// 测试可空类型的值
        /// </summary>
        public void Test01()
        {
            int? x = 5;
            x = new int?(5);
            Console.WriteLine("Instance With Value:");
            Display(x);

            x = new int?();
            Console.WriteLine("Instance With Value:");
            Display(x);
        }

        /// <summary>
        /// 测试可空类型的类型
        /// </summary>
        public void Test02()
        {
            int? nullable = 5;

            object boxed = nullable;
            Console.WriteLine(boxed.GetType());

            int normal = (int)boxed;
            Console.WriteLine(normal.GetType());

            nullable =new int?();
            Console.WriteLine(nullable);
            Console.WriteLine(nullable == null);

            boxed = nullable;
            Console.WriteLine(boxed == null);

            nullable = (int?)boxed; 
            Console.WriteLine(nullable.HasValue);

            Console.WriteLine(nullable<10);
        }
    }
}
