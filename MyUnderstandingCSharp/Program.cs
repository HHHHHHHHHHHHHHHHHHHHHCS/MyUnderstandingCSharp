
//extern alias 不搞了
using MyUnderstandingCSharp._01_First._02_Two;
using MyUnderstandingCSharp._01_First._03_Three;
using MyUnderstandingCSharp._01_First._04_Four;
using System;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _04_AnonymousType t = new _04_AnonymousType();
            t.Test01();
            t.Test02();
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
