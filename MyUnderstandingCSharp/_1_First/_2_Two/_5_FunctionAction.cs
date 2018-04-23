using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._1_First._2_Two
{
    public class _5_FunctionAction
    {
        public void Test(string a1,double x,double y)
        {
            Action<string> a = (t) => { Console.WriteLine(t); };
            a(a1);
            Func<double, double, double> f = (t1, t2) => { return t1 * t2; };
            Console.WriteLine(f(x,y));
        }
    }
}
