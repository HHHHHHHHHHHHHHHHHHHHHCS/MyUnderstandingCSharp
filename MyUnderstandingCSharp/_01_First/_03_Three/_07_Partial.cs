using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public partial class _07_PartialClass<T1, T2> : IEquatable<string> where T1 : class
    {
        public bool Equals(string other)
        {
            return false;
        }
    }

    public partial class _07_PartialClass<T1, T2> : EventArgs, IDisposable 
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class _07_Partial
    {
        public void Test()
        {
            _07_PartialClass<string, string> pc = new _07_PartialClass<string, string>();
            pc.Equals("2333");
            pc.Dispose();
        }
    }
}
