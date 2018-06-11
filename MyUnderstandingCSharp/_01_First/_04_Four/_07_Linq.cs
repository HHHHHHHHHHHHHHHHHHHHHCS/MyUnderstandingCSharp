using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public class _07_Linq
    {
        public void Test01()
        {
            var newList01 = from userList in User.GetDefaultUser()
                            where userList.From == User.Country.CN
                            select userList;
            foreach (var item in newList01)
            {
                Console.WriteLine(item);
            }

            var newList02 = User.GetDefaultUser()
                .Where(user => user.From == User.Country.USA)
                .Select(user => user.Name);
            foreach (var item in newList02)
            {
                Console.WriteLine(item);
            }
        }

        public void Test02()
        {
            var source = new Dummy<string>();
            var query = from dummy in source
                        where dummy.ToString() == "Ingored"
                        select "Anthing";
        }



        public void Test03()
        {
            ArrayList list = new ArrayList { "First", "Second", "Third" };
            IEnumerable<string> li = list.Cast<string>();
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test04()
        {
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5, "First", "Second", "Third" };
            IEnumerable<int> li = list.OfType<int>();
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test05()
        {
            ArrayList list = new ArrayList { "Zero", "First", "Second", "Third" };
            IEnumerable<string> strings = from string e in list
                                          select e.Substring(0, 3);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            strings = list.Cast<string>().Select(p => p.Substring(0, 3));
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
        }

        public void Test06()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> li = from temp in list
                                  where temp != 3 && temp != 5
                                  select temp;
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test07()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> li = from temp in list
                                  orderby temp descending
                                  select temp;
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test08()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("a",1),
                new KeyValuePair<string, int>("a",2),
                new KeyValuePair<string, int>("a",3),
                new KeyValuePair<string, int>("a",4),
                new KeyValuePair<string, int>("b",6),
                new KeyValuePair<string, int>("b",5),
                new KeyValuePair<string, int>("c",0),
                new KeyValuePair<string, int>("d",-1),
            };

            var li = from temp in list
                     orderby temp.Key descending, temp.Value ascending
                     select temp;
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test09()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aaaa","a"),
                new KeyValuePair<string, string>("bbbb","bb"),
                new KeyValuePair<string, string>("cccc","ccc"),
                new KeyValuePair<string, string>("dddd","dddd"),
                new KeyValuePair<string, string>("eeee","eeeee"),
            };

            var li = from temp in list
                     let k1 = temp.Key.Length
                     let k2 = temp.Value.Length
                     orderby k1 descending
                     select new { temp.Key, k1, k2 };
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test10()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aaaa","a"),
                new KeyValuePair<string, string>("bbbb","bb"),
                new KeyValuePair<string, string>("cccc","ccc"),
                new KeyValuePair<string, string>("dddd","dddd"),
                new KeyValuePair<string, string>("eeee","eeeee"),
            };

            var newList = list.Select(user => new { name = user.Key, length = user.Value.Length })
                .OrderByDescending(user => user.length)
                .Select(user => new { name = user.name, length = user.length });
            newList.ToList().ForEach(p => Console.WriteLine(p));

            Console.WriteLine("-------------------");
        }

        public void Test11()
        {
            List<KeyValuePair<string, string>> list1 = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aaaa","a"),
                new KeyValuePair<string, string>("bbbb","bb"),
                new KeyValuePair<string, string>("cccc","ccc"),
                new KeyValuePair<string, string>("dddd","dddd"),
                new KeyValuePair<string, string>("eeee","eeeee"),
            };
            List<KeyValuePair<string, bool>> list2 = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string, bool>("aaaa",true),
                new KeyValuePair<string, bool>("bbbb",false),
                new KeyValuePair<string, bool>("cccc",true),
                new KeyValuePair<string, bool>("dddd",false),
                new KeyValuePair<string, bool>("eeee",true),
            };

            var newList = from table1 in list1
                          join table2 in list2
                          on table1.Key equals table2.Key
                          select new { name = table1.Key, other = table1.Value, sex = table2.Value };
            newList.ToList().ForEach(p => Console.WriteLine(p));

            Console.WriteLine("-------------------");
        }

        public void Test12()
        {
            List<KeyValuePair<string, int>> list1 = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("aaaa",16),
                new KeyValuePair<string, int>("bbbb",17),
                new KeyValuePair<string, int>("cccc",18),
                new KeyValuePair<string, int>("dddd",19),
                new KeyValuePair<string, int>("eeee",20),
            };
            List<KeyValuePair<string, bool>> list2 = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string, bool>("aaaa",true),
                new KeyValuePair<string, bool>("bbbb",false),
                new KeyValuePair<string, bool>("cccc",true),
                new KeyValuePair<string, bool>("dddd",false),
                new KeyValuePair<string, bool>("eeee",true),
            };

            var newList1 = from table1 in list1
                           where table1.Value >= 18
                           join table2 in list2
                           on table1.Key equals table2.Key
                           select new { name = table1.Key, sex = table2.Value, age = table1.Value };
            newList1.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");

            var newList2 = from table2 in list2
                           join table1 in (from temp in list1
                                           where temp.Value < 18
                                           select temp)
                           on table2.Key equals table1.Key
                           select new { name = table1.Key, sex = table2.Value, age = table1.Value };
            newList2.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }


        public void Test13()
        {
            List<KeyValuePair<string, int>> list1 = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("aaaa",16),
                new KeyValuePair<string, int>("bbbb",17),
                new KeyValuePair<string, int>("cccc",18),
                new KeyValuePair<string, int>("dddd",19),
                new KeyValuePair<string, int>("eeee",20),
            };
            List<KeyValuePair<string, bool>> list2 = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string, bool>("aaaa",true),
                new KeyValuePair<string, bool>("bbbb",false),
                new KeyValuePair<string, bool>("cccc",true),
                new KeyValuePair<string, bool>("dddd",false),
                new KeyValuePair<string, bool>("eeee",true),
            };

            var newList1 = from table1 in list1
                           where table1.Value >= 18
                           join table2 in list2
                           on table1.Key equals table2.Key
                           into newTable
                           select new { age = table1.Value, table = newTable };
            newList1.ToList().ForEach(p =>
            {
                Console.WriteLine(p.age);
                p.table.ToList().ForEach(z => Console.WriteLine(z));
            });
            Console.WriteLine("-------------------");


        }

        public void Test14()
        {
            List<KeyValuePair<string, int>> list1 = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("aaaa",16),
                new KeyValuePair<string, int>("bbbb",17),
                new KeyValuePair<string, int>("cccc",18),
                new KeyValuePair<string, int>("dddd",19),
                new KeyValuePair<string, int>("eeee",20),
            };
            List<KeyValuePair<string, bool>> list2 = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string, bool>("a",true),
                new KeyValuePair<string, bool>("b",false),
                new KeyValuePair<string, bool>("c",true),
                new KeyValuePair<string, bool>("d",false),
                new KeyValuePair<string, bool>("e",true),
            };

            var newList1 = from table1 in list1
                           from table2 in list2
                           select new { table1, table2 };
            newList1.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test15()
        {
            var newList1 = from left in Enumerable.Range(1, 4)
                           from right in Enumerable.Range(11, left)
                           select new { left, right };
            newList1.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");

            var list2 = Enumerable.Range(1, 4).SelectMany(left => Enumerable.Range(1, left)
            , (left, right) => new { left = left, right = right });
            list2.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test16()
        {
            string logDir = "";
            var query = from file in Directory.GetFiles(logDir, "*.log")
                        from line in ReadLines(file)
                        let entry = new LogEntry(line)
                        where entry.type == LogEntry.LogType.Error
                        select entry;
            query.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test17()
        {
            var list = from right in Enumerable.Range(1, 5)
                       from left in Enumerable.Range(right, 5)
                       let x =new { right,left}
                       group x by x.left;
            list.ToList().ForEach(p => {
                p.ToList().ForEach(x=>Console.WriteLine(x));
                Console.WriteLine("================");
            });
            Console.WriteLine("-------------------");
        }

        public void Test18()
        {
            var list = from right in Enumerable.Range(1, 5)
                       from left in Enumerable.Range(right, 5)
                       let x = new { right, left }
                       select x;
            var query= list.GroupBy(x => x.right);
            query.ToList().ForEach(x => {
                x.ToList().ForEach(p =>
                {
                    Console.WriteLine(p);
                });
                Console.WriteLine("============");
            });
            Console.WriteLine("-------------------");
        }

        private string[] ReadLines(string fileName)
        {
            string[] strs = new string[0];
            var fs = File.OpenRead(fileName);
            var sr = new StreamReader(fs);
            strs[0] = sr.ReadLine();
            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();
            return strs;
        }
    }


}


public class User
{
    public enum Country
    {
        CN,
        USA,
        JP,
        UK

    }


    public string Name { get; set; }
    public int Age { get; set; }
    public Country From { get; set; }

    public override string ToString()
    {
        return string.Format("{0}/{1}/{2}", Name, Age, From);
    }

    public static List<User> GetDefaultUser()
    {
        return new List<User>
            {
                new User { Name="A",Age=15,From = Country.CN},
                new User { Name="B",Age=16,From = Country.USA},
                new User { Name="C",Age=17,From = Country.JP},
                new User { Name="D",Age=18,From = Country.UK},
                new User { Name="E",Age=19,From = Country.CN},
                new User { Name="F",Age=20,From = Country.USA},
                new User { Name="G",Age=21,From = Country.JP},
                new User { Name="H",Age=22,From = Country.CN},
            };

    }
}

public static class Extensions
{
    public static Dummy<T> Where<T>(this Dummy<T> dummy
        , Func<T, bool> predicate)
    {
        Console.WriteLine("Where called");
        return dummy;
    }
}

public class Dummy<T>
{
    public Dummy<U> Select<U>(Func<T, U> selector)
    {
        Console.WriteLine("Select called");
        return new Dummy<U>();
    }
}

public class LogEntry
{
    public enum LogType
    {
        Error,
        Warning,
        Log,
    }


    public LogType type;

    public LogEntry(string str)
    {
        type = LogType.Error;
    }

}
