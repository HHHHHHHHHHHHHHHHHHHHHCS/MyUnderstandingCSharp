
//extern alias 不搞了
using MyUnderstandingCSharp._01_First._02_Two;
using MyUnderstandingCSharp._01_First._03_Three;
using System;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _09_Namespace t = new _09_Namespace();
            t.Test01();
            t.Test02();
            t.Test03();
            t.Test04();
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
