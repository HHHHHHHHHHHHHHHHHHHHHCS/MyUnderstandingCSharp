using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _09_StaticClass1
    {
        private static float number;

        public _09_StaticClass1(float _number)
        {
            number = _number;
        }

        /// <summary>
        /// 只有在全局第一次实例化的时候才会调用
        /// </summary>
        static _09_StaticClass1()
        {
            Console.WriteLine("static class one");
        }

        public void Print()
        {
            Console.WriteLine("_9_StaticClass1 " +number);
        }
    }

    public class _09_StaticClass2<T>
    {
        /// <summary>
        /// 只有在T不一样且全局第一次实例化的时候才会调用
        /// </summary>
        static _09_StaticClass2()
        {
            Console.WriteLine("static class two"+typeof(T));
        }
    }
}
