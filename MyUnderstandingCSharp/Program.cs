
//extern alias 不搞了
using MyUnderstandingCSharp._01_First._02_Two;
using MyUnderstandingCSharp._01_First._03_Three;
using MyUnderstandingCSharp._01_First._04_Four;
using MyUnderstandingCSharp._01_First._05_Five;
using System;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _01_LinqOther t = new _01_LinqOther();
            t.Test04();

            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
