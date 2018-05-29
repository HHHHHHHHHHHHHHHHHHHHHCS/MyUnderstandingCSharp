using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public class _04_Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class _04_AnonymousType
    {
        public void MyMethod01(string[] names)
        {
            names.ToList().ForEach((p) => { Console.Write(p + "/"); });
            Console.WriteLine();
        }

        public void Test01()
        {
            string[] names01 = { "A", "B", "C", "D" };
            MyMethod01(names01);

            MyMethod01(new string[] { "A", "B", "C", "D" });

            MyMethod01(new[] { "A", "B", "C", "D" });
        }


        public void Test02()
        {
            var tom = new { Name = "Tom", Age = 9 };
            Console.WriteLine(tom);
            Console.WriteLine("{0}/{1}", tom.Name, tom.Age);
            var bob = new { Name = "Tom", Age = 9, Sex = true };
            Console.WriteLine(bob);
            Console.WriteLine("{0}/{1}/{2}", bob.Name, bob.Age, bob.Sex);
            var jon = new { Name = "Tom", Age = 9, Home = new { Country = "USA", Town = "2333" } };
            Console.WriteLine(jon);
            Console.WriteLine(jon.Home);
            Console.WriteLine("{0}/{1}/{2}/{3}", jon.Name, jon.Age, jon.Home.Country, jon.Home.Town);

        }

        public void Test03()
        {
            List<_04_Person> family = new List<_04_Person>
            {
                new _04_Person { Name="A",Age=1},
                new _04_Person { Name="B",Age=2},
                new _04_Person { Name="C",Age=3},
                new _04_Person { Name="D",Age=4},
                new _04_Person { Name="E",Age=5},
                new _04_Person { Name="F",Age=6},

            };

            var co = family.ConvertAll((p) =>
            {
                return new { p.Name, IsAdult = p.Age >= 18 };
            });

            foreach (var p in co)
            {
                Console.WriteLine("{0} is an adult ? {1}", p.Name, p.IsAdult);
            }
        }
    }


}
