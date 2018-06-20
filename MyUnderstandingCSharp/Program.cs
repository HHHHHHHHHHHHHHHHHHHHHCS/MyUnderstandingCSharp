
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
            //_09_Async t = new _09_Async();
            _09_Async.SumCharacterAsync("abcdefg");

            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
