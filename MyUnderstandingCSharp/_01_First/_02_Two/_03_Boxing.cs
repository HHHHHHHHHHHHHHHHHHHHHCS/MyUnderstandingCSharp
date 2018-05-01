using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _03_Boxing
    {

        public void Test()
        {
            int i = 5;
            object o = i;
            o = 10;
            int j = (int)o;

            Console.WriteLine(string.Format("{0},{1},{2}", i, o, j));
        }
    }
}
