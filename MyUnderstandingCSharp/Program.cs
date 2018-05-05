using MyUnderstandingCSharp._01_First._02_Two;
using MyUnderstandingCSharp._01_First._03_Three;
using System;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _02_Type.StaticTest();
            _02_Type type = new _02_Type();
            type.Test();
            while(true)
            {
                Console.ReadLine();
            }
        }
    }
}
