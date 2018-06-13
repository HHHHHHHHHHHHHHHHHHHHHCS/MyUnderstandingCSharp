using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public class _08_SampleCode
    {
        public void Test01()
        {
            Method01(3, z: 2);
        }

        public void Method01(int x,int y=0,int z=0)
        {

        }

        public void Test02()
        {
            Method02((object)3,3);

            Method02(a:3, b: 3);
        }

        public void Method02(int x, int y )
        {

        }


        public void Method02(object a , int b )
        {

        }


        public void Test03()
        {
            var list =  Enumerable.Range(0, 5);
            Console.WriteLine(list.DynammicSum());
        }


    }

    public static class DynammicClass
    {
        public static T DynammicSum<T>(this IEnumerable<T> source)
        {
            dynamic total = default(T);
            foreach (T item in source)
            {
                total += (T)item;
            }
            return total;
        }
    }

}
