using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{



    class _02_GetSetSturct
    {
        public struct Foo1
        {
            public int Value { get; private set; }

            public Foo1(int _value)
            {
                Value = _value;
            }
        }

        /// <summary>
        /// 这里显式调用了无参的构造函数
        /// </summary>
        public struct Foo2
        {
            public int Value { get; private set; }

            public Foo2(int _value):this()
            {
                Value = _value;
            }
        }


        public void Test()
        {
            Foo1 fo1 = new Foo1(3);
            Console.WriteLine(fo1.Value);
            Foo2 fo2 = new Foo2(5);
            Console.WriteLine(fo2.Value);
        }
    }
}
