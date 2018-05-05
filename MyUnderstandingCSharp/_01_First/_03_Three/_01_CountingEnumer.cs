using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _01_CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return  new _01_CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class _01_CountingEnumerator : IEnumerator<int>
    {

        private int current = -1;

        public int Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return current;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            current++;
            Console.WriteLine("MoveNext:" + current);
            return current < 10;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
