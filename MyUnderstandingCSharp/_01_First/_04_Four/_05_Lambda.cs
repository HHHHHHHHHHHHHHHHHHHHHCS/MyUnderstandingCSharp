using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }


    public class _05_Lambda
    {
        public void Test01()
        {
            Func<string, int> returnLength;
            returnLength = delegate (string text) { return text.Length; };
            Console.WriteLine(returnLength("Hello World"));

            returnLength = (string text) => { return text.Length; };
            Console.WriteLine(returnLength("Hello World"));

            returnLength = (text) => { return text.Length; };
            Console.WriteLine(returnLength("Hello World"));

            returnLength = (text) => text.Length;
            Console.WriteLine(returnLength("Hello World"));

            returnLength = text => text.Length;
            Console.WriteLine(returnLength("Hello World"));
        }

        public void Test02()
        {
            var films = new List<Film>
            {
                new Film {Name="A",Year=1 },
                new Film {Name="B",Year=2 },
                new Film {Name="C",Year=3 },
                new Film {Name="D",Year=4 },
                new Film {Name="E",Year=5 },
                new Film {Name="F",Year=6 },
                new Film {Name="G",Year=7 },
                new Film {Name="H",Year=8 },
                new Film {Name="I",Year=9 },
            };

            Action<Film> print =
                film => Console.WriteLine("Name={0} , Year={1}", film.Name, film.Year);

            films.ForEach(print);

            Console.WriteLine("------------------------");
            films.FindAll(f => f.Year < 4).ForEach(print);

            Console.WriteLine("------------------------");
            films.Sort((f1, f2) => -f1.Year.CompareTo(f2.Year));
            films.ForEach(print);
        }
    }
}
