using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    public class _04_Delegate
    {
        public delegate void MouseEventHandler(object sender, EventArgs e);

        private static void HandleDemoEvent(object sender,EventArgs e)
        {
            Console.WriteLine("Debug log Demo");
        }

        public void Test()
        {
            //1、C# .net1 指定委托类型和方法  最老的最麻烦的方法
            EventHandler handler;
            handler = new EventHandler(HandleDemoEvent);
            handler(this, EventArgs.Empty);

            //2、C# .net2 隐式转换 可以+ - = 操作
            //handler = HandleDemoEvent;
            handler += HandleDemoEvent;
            handler(this, EventArgs.Empty);

            //3、内部匿名方法
            handler = delegate (object sender, EventArgs e)
              {
                  Console.WriteLine("Debug log Demo");
              };
            handler(this, EventArgs.Empty);

            //4、匿名方法 但是不能使用参数
            handler = delegate
            {
                Console.WriteLine("Debug log Demo");
            };
            handler(this, EventArgs.Empty);

            //5、lambda方法 可以使用参数
            handler = (sendder,e)=>
            {
                Console.WriteLine("Debug log Demo");
            };
            handler(this, EventArgs.Empty);

            //6、委托的逆变性 协变性 
            //逆变性：参数的兼容性   协变性：返回类型的兼容性
            MouseEventHandler meh = HandleDemoEvent;
            handler(this, EventArgs.Empty);
        }
    }
}
