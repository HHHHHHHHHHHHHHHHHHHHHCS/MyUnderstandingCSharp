using System;
using System.Collections;
using System.Collections.Generic;
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
            foreach(var item in newList01)
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
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 ,"First", "Second", "Third" };
            IEnumerable<int> li = list.OfType<int>();
            li.ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-------------------");
        }

        public void Test05()
        {
            ArrayList list = new ArrayList {"Zero", "First", "Second", "Third" };
            IEnumerable<string> strings = from string e in list
                          select e.Substring(0, 3);
            foreach(var item in strings)
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
            ,Func<T,bool> predicate)
        {
            Console.WriteLine("Where called");
            return dummy;
        }
    }

    public class Dummy<T>
    {
        public Dummy<U> Select<U>( Func<T, U> selector)
        {
            Console.WriteLine("Select called");
            return new Dummy<U>();
        }
    }
}
