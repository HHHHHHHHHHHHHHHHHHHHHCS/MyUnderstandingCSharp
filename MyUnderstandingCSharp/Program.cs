using MyUnderstandingCSharp._1_First._1_One;
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
            _6_LinqProduct a = new _6_LinqProduct();
            a.FilterBySupplierAndPrice();
            Console.ReadLine();
        }
    }
}
