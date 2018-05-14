using MyUnderstandingCSharp._01_First._02_Two;
using MyUnderstandingCSharp._01_First._03_Three;
using System;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _05_AnonymousDelegate t = new _05_AnonymousDelegate();
            t.Test1();
            t.Test2();
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
