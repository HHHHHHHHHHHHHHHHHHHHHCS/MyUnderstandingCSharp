using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public partial class _07_PartialClass01<T1, T2> : IEquatable<string> where T1 : class
    {
        public bool Equals(string other)
        {
            return false;
        }
    }

    public partial class _07_PartialClass01<T1, T2> : EventArgs, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public partial class _07_PartialClass02
    {
        public _07_PartialClass02()
        {
            OnCreate();
            Console.WriteLine("Doing");
            OnEnd();
        }

        partial void OnCreate();
        partial void OnEnd();
    }

    public partial class _07_PartialClass02
    {
        partial void OnCreate()
        {
            Console.WriteLine("OnCreate");
        }
    }

    public class _07_Partial
    {
        public void Test01()
        {
            _07_PartialClass01<string, string> pc = new _07_PartialClass01<string, string>();
            pc.Equals("2333");
            pc.Dispose();
        }

        public void Test02()
        {
            _07_PartialClass02 pc = new _07_PartialClass02();
        }
    }
}
