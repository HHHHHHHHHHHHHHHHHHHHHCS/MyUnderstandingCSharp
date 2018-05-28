using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
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
            Console.WriteLine("{0}/{1}",tom.Name,tom.Age);
            var bob = new { Name = "Tom", Age = 9, Sex = true };
            Console.WriteLine(bob);
            Console.WriteLine("{0}/{1}/{2}", bob.Name, bob.Age, bob.Sex);
            var jon = new { Name = "Tom", Age = 9, Home = new { Country = "USA", Town = "2333" } };
            Console.WriteLine(jon);
            Console.WriteLine(jon.Home);
            Console.WriteLine("{0}/{1}/{2}/{3}", jon.Name, jon.Age, jon.Home.Country, jon.Home.Town);

        }
    }


}
