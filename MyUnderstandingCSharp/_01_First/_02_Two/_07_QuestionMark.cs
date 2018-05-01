using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _07_QuestionMark
    {
        public void Test01()
        {
            int a = 4;
            int b = -4;
            int c = b > 0 ? b : a;//三元表达式
        }

        public void Test02()
        {
            int? a = null;//强制为null
            if(a==null)
            {
                a = 5;
                int y = a.Value;
                Console.WriteLine(y);
                a = null;
            }
            int z = a ?? 10; //null的联合操作符
        }

    }
}
