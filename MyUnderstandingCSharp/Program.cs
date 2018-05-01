using MyUnderstandingCSharp._1_First._1_One;
using MyUnderstandingCSharp._1_First._2_Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _9_StaticClass1 c101 = new _9_StaticClass1(1);
            _9_StaticClass1 c102 = new _9_StaticClass1(2);
            _9_StaticClass2<string> c201 = new _9_StaticClass2<string>();
            _9_StaticClass2<int> c202 = new _9_StaticClass2<int>();
            _9_StaticClass2<decimal> c203 = new _9_StaticClass2<decimal>();
            _9_StaticClass2<string> c204 = new _9_StaticClass2<string>();

            c101.Print();
            c102.Print();
            while (Console.ReadLine() != null)
            {

            }
        }
    }
}
