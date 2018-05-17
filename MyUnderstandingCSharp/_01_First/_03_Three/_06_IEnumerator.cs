using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _06_IEnumerator
    {
        private int[] values = { 1, 2, 3, 4, 5, 6 };

        //因为C#1的迭代器过于冗长不想写...


        public IEnumerator<int> GetEnumberator(int startIndex)
        {
            for (int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startIndex) % values.Length];
            }
        }

    }
}
