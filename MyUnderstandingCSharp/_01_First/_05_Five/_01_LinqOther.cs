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

        public void Test03()
        {
            object[] stringArray = { "a", "b", "c", "d", "e" };
            object[] objectArray = { "a", 'b', 3, 4f, 5d,6m,0x22,false,"dddd" };

            Console.WriteLine("stringArray.Cast<string>()");
            foreach(var item in  stringArray.Cast<string>())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("stringArray.OfType<string>()");
            foreach (var item in stringArray.OfType<string>())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("objectArray.Cast<string>()");
            try
            {
                foreach (var item in objectArray.Cast<string>())
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("objectArray.OfType<string>()");
            foreach (var item in objectArray.OfType<string>())
            {
                Console.WriteLine(item);
            }
        }

        public void Test04()
        {
            string[] stringArray = { "aa", "ab", "ac", "bb", "bc","d","e" };

            Console.WriteLine("ToList");
            stringArray.ToList().ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("ToDictionary");
            foreach (var item in stringArray.ToDictionary(x => x))
            {
                Console.WriteLine("Key{0}  Value:{1}", item.Key, item.Value);
            }
            Console.WriteLine("ToList");
            foreach (var item in stringArray.ToLookup(x => x[0]))
            {
                Console.WriteLine("------------{0}--------------", item.Key);
                foreach (var info in item)
                {
                    Console.WriteLine(info);
                }
            }
        }
    }
}
