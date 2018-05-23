using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Timer_Threading = System.Threading;
using Timer_Timer= System.Timers;


namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class Timer { }

    public class _09_Namespace
    {
        public void Test01()
        {
            Console.WriteLine(typeof(Timer_Threading.Timer));
            Console.WriteLine(typeof(Timer_Timer.Timer));
        }

        public void Test02()
        {
            Console.WriteLine(typeof(Timer_Threading::Timer));
            Console.WriteLine(typeof(Timer_Timer::Timer));
        }

        public void Test03()
        {
            Console.WriteLine(typeof(global::System.Threading.Timer));
            Console.WriteLine(typeof(global::System.Timers.Timer));
        }

        public void Test04()
        {
            Console.WriteLine(typeof(global::System.Threading.Timer));
            Console.WriteLine(typeof(global::System.Timers.Timer));
            Console.WriteLine(typeof(global::MyUnderstandingCSharp._01_First._03_Three.Timer));
        }
    }
}
