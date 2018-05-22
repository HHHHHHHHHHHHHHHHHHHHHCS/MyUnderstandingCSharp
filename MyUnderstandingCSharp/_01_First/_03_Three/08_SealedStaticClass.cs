using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public sealed class _08_SealedClass
    {
        private _08_SealedClass()
        {

        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }

    public static class _08_StaticClass
    {
        public static void PrintNull()
        {
            Console.WriteLine("Null");
        }
    }
}
