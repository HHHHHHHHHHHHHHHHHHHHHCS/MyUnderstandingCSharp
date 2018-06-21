using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._05_Five
{
    public class _01_LinqOther
    {
        public void Test01()
        {
            List<int> numbers = Enumerable.Range(0, 10).ToList();

            Console.WriteLine("Sum:{0}", numbers.Sum());
            Console.WriteLine("Count:{0}", numbers.Count());
            Console.WriteLine("Average:{0}", numbers.Average());
            Console.WriteLine("LongCount:{0}", numbers.LongCount(x => x % 2 == 0));
            Console.WriteLine("Min:{0}", numbers.Min(x => x % 2 == 0));
            Console.WriteLine("Max:{0}", numbers.Max(x => x % 2 == 0));
            Console.WriteLine("Aggregate:{0}", numbers.Aggregate("seed"
                , (current, item) => current + item, result => result.ToUpper()));
        }

        public void Test02()
        {
            List<int> numbers = Enumerable.Range(0, 10).ToList();

            numbers = numbers.Concat(new[] { 1, 2, 3, 4, 5 }).ToList();
            numbers.ForEach(x => Console.WriteLine(x));
        }
    }
}
