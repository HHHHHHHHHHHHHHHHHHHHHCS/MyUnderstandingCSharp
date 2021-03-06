﻿using System;
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
            object[] objectArray = { "a", 'b', 3, 4f, 5d, 6m, 0x22, false, "dddd" };

            Console.WriteLine("stringArray.Cast<string>()");
            foreach (var item in stringArray.Cast<string>())
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("objectArray.OfType<string>()");
            foreach (var item in objectArray.OfType<string>())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("objectArray.OfType<string>()");
            foreach (var item in stringArray.ToList().ConvertAll<string>(x=>(string)x))
            {
                Console.WriteLine(item.GetType()+"///"+ item);
            }
        }

        public void Test04()
        {
            string[] stringArray = { "aa", "ab", "ac", "bb", "bc", "d", "e" };

            Console.WriteLine("ToList");
            stringArray.ToList().ForEach(x => Console.WriteLine(x));
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

        public void Test05()
        {
            string[] stringArray = { "aa", "ab", "ac", "bb", "bc", "d", "e" };
            string[] oneArray = { "aa" };
            string[] singleArray = { "aa", "AA", "aA", "Aa", "aa", "AA", "aA", "Aa", "aaaa" };

            Console.WriteLine("ElementAt:{0}", stringArray.ElementAt(2));
            Console.WriteLine("ElementAtOrDefault:{0}", stringArray.ElementAtOrDefault(10));
            Console.WriteLine("First():{0}", stringArray.First());
            Console.WriteLine("First(x=>x==\"ac\"):{0}", stringArray.First(x => x == "ac"));
            //Console.WriteLine("First(x => x == \"ae\"):{0}", stringArray.First(x => x == "ae"));//报错
            Console.WriteLine("FirstOrDefault(x => x == \"ae\"):{0}", stringArray.FirstOrDefault(x => x == "ae"));
            Console.WriteLine("Last():{0}", stringArray.Last());
            //Console.WriteLine("stringArray Single():{0}", stringArray.Single());//报错筛选后 只能存在一个
            Console.WriteLine("oneArray Single():{0}", oneArray.Single());
            Console.WriteLine("singleArray Single(x=>x.Length==2):{0}", singleArray.Single(x => x.Length == 4));
            Console.WriteLine("singleArray SingleOrDefault(x=>x.Length==4):{0}", singleArray.SingleOrDefault(x => x.Length == 2));
        }

        public void Test06()
        {
            string[] stringArray = { "one", "two", "three", "four" };
            Console.WriteLine(stringArray.SequenceEqual(new[] { "one", "two", "three", "four" }));
            Console.WriteLine(stringArray.SequenceEqual(new[] { "One", "Two", "Three", "Four" }));
            Console.WriteLine(stringArray.SequenceEqual(new[] { "One", "Two", "Three", "Four" }, StringComparer.OrdinalIgnoreCase));
        }

        public void Test07()
        {
            string[] stringArray = { "one", "two", "three", "four" };
            Console.WriteLine("-----stringArray DefaultIfEmpty------");
            stringArray.DefaultIfEmpty();
            foreach (var item in stringArray)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-----arr1 DefaultIfEmpty------");
            var x1 = new int[0];
            var arr1 = x1.DefaultIfEmpty();
            foreach (var item in arr1)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-----arr2 DefaultIfEmpty(10)------");
            foreach (var item in new int[5].DefaultIfEmpty(10))
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-----Enumerable.Range------");
            foreach (var item in Enumerable.Range(15,2))
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-----Enumerable.Repeat(15, 5)------");
            foreach (var item in Enumerable.Repeat(15, 5))
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-----Enumerable.Empty<int>()------");
            foreach (var item in Enumerable.Empty<int>())
            {
                Console.WriteLine(item + " ");
            }
        }

        public void Test08()
        {
            string[] names1 = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee" };
            string[] colors1 = new string[] { "ARed", "EBule", "BYellow", "CRed", "DBule" };

             Console.WriteLine("Join");
            var newArray = names1.Join(colors1, name => name[0], color => color[0], (name, color) => name + "---" + color);
            foreach(var item in newArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("GroupJoin");
            string[] names2 = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee" };
            string[] colors2 = new string[] { "ARed", "ABule", "BYellow", "BRed", "CBule" };

            newArray = names2.GroupJoin(colors2, name => name[0], color => color[0], (name, color) => name + "---" + String.Join("/",color));
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }

        public void Test09()
        {
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("-----Take-----");
            intArray.Take(2).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Skip-----");
            intArray.Skip(3).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----TakeWhile-----");
            intArray.TakeWhile(x=>x<4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----SkipWhile-----");
            intArray.SkipWhile(x => x <4).ToList().ForEach(x => Console.WriteLine(x));
        }

        public void Test10()
        {
            string[] words = { "aaa", "bbbb", "ccccc", "dddddd" };
            Console.WriteLine("-----Select-----");
            words.Select(word => word.Length).ToList().ForEach(x=>Console.WriteLine(x));

            Console.WriteLine("-----Select Index-----");
            words.Select((word,index) => word.Length+"///"+index).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----Select Many-----");
            words.SelectMany((word) => word.ToCharArray()).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----Select Many-----");
            words.SelectMany((word,index) => 
            {
                return Enumerable.Repeat(word,index);
            })
            .ToList().ForEach(x =>
            {

                foreach (var ch in x) { Console.Write("{0},", ch); };
                Console.WriteLine();
            });

        }

        public void Test11()
        {
            string[] names = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee", "Aa", "Bb", "Cc", "Dd", "Ee" };
            string[] colors = new string[] { "ARed", "ABule", "BYellow", "BRed", "CBule","DRed" };

            names.Zip(colors, (x, y) => x + "///" + y).ToList<string>()
                .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            names.Zip(colors.Take(3), (x, y) => x + "///" + y).ToList<string>()
                .ForEach(x => Console.WriteLine(x));
        }

        public void Test12()
        {
            string[] names = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee", "Aa", "Bb", "Cc", "Dd", "Ee" };
            string[] colors = new string[] { "ARed", "ABule", "BYellow", "BRed", "CBule", "DRed" };

            Console.WriteLine( names.All(x => x[0] == 'A'));
            Console.WriteLine(names.All(x => x.Length>1));
            Console.WriteLine(colors.Any(x => x[0] == 'Z'));
            Console.WriteLine(colors.Any(x => x== "ARed"));
            Console.WriteLine(colors.Contains("ARed"));
            Console.WriteLine(colors.Contains("ARED",StringComparer.OrdinalIgnoreCase));
        }

        public void Test13()
        {
            string[] names = new string[] { "Aa", "Bb", "Cc", "Dd", "Ee", "Aa", "Bb", "Cc", "Dd", "Ee" };
            string[] colors = new string[] { "ARed", "ABule", "BYellow", "BRed", "CBule", "DRed" };

            names.Where(x => x[0] == 'A').ToList().ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("-------------");
            colors.Where((x,index) => x.Length<=5&&index<3).ToList().ForEach(x => Console.WriteLine(x));
        }

        public void Test14()
        {
            char[] chs1 = { 'a', 'b', 'c', 'd', 'e','a','b' ,'c'};
            char[] chs2 = { 'd', 'e', 'f', 'g', 'h' };

            Console.WriteLine("-----Distinct-----");
            chs1.Distinct().ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Intersect-----");
            chs1.Intersect(chs2).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Union-----");
            chs1.Union(chs2).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Except-----");
            chs1.Except(chs2).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Except-----");
            chs2.Except(chs1).ToList().ForEach(x => Console.WriteLine(x));
        }

        public void Test15()
        {
            char[] chs1 = { 'a', 'b', 'c', 'd', 'e', 'a', 'b', 'c' };
            string[] str1 = { "f1", "e2", "d3", "c4", "b5", "a6", };
            string[] str2 = { "ee", "d","eee","aaa","aaaa","aa","bb","bbb","b","ccc","cc"};

            Console.WriteLine("-----OrderBy-----");
            chs1.OrderBy(x => x).ToList().ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("-----OrderByDescending-----");
            str1.OrderByDescending(x => x[1]).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----ThenByDescending-----");
            str2.OrderBy(x => x[0])
                .ThenByDescending(x=>x.Length)
                .ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----Reverse-----");
            chs1.Reverse().ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
