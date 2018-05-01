using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _06_DynamicClass
    {
        /// <summary>
        /// C# .net3仍然是静态语言 只是编译而已
        /// </summary>
        public void Test_Net_3()
        {
            var biJi = new { Name = "BiJi", Age = "1" };
            var caiBi = new { Name = "CaiBi", Age = "2333",Skill="ChiFan" };
        }

        /// <summary>
        /// C# .net4 用了dynmamic才是动态语言
        /// </summary>
        public void Test_Net_4()
        {
            dynamic o = "Hello";
            Console.WriteLine(o.Length);
            o = new string[] { "hi", "every", "one" };
            Console.WriteLine(o.Length);
        }
    }
}
