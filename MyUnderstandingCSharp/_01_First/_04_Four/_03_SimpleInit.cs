using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{


    public class _03_Location
    {
        public string Country { get; set; }
        public string Town { get; set; }
    }


    public class _03_Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        List<_03_Person> friends = new List<_03_Person>();
        public List<_03_Person> Friends { get { return friends; } }

        _03_Location home = new _03_Location();
        public _03_Location Home { get { return home; } }

        public _03_Person()
        {

        }

        public _03_Person(string _name)
        {
            Name = _name;
        }
    }

    public class _03_SimpleInit
    {
        public void Test01()
        {
            _03_Person p1 = new _03_Person();
            p1.Name = "Tom";
            p1.Age = 9;

            _03_Person p2 = new _03_Person("Tom");
            p2.Age = 9;


            _03_Person p3 = new _03_Person() { Name = "Tom", Age = 9 };
            _03_Person p4 = new _03_Person { Name = "Tom", Age = 9 };
            _03_Person p5 = new _03_Person { Age = 9, Name = "Tom", };
            _03_Person p6 = new _03_Person("Tom") { Age = 9 };
        }


        public void Test02()
        {
            _03_Person[] family = new _03_Person[]
                {
                    new _03_Person { Name = "Holly", Age = 9 },
                    new _03_Person { Name = "Jon", Age = 18 },
                    new _03_Person { Name = "Tom", Age = 27 },
                    new _03_Person { Name = "William", Age = 36 },
                    new _03_Person { Name = "Robin", Age = 45 },
                };
        }

        public void Test03()
        {
            _03_Person tom1 = new _03_Person("Tom");
            tom1.Age = 9;
            tom1.Home.Country = "CN";
            tom1.Home.Town = "Wulalalala";


            _03_Person tom2 = new _03_Person("Tom")
            {
                Age = 9,
                Home = { Country = "CN", Town = "Wulalalala" }
            };

        }

        public void Test04()
        {
            List<string> names1 = new List<string>();
            names1.Add("1");
            names1.Add("2");
            names1.Add("3");
            names1.Add("4");
            names1.Add("5");

            List<string> names2 = new List<string>()
            {
                "1","2","3","4","5","6"
            };

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                { 1,"1" },
                { 2,"2" },
                { 3,"3" },
            };

        }

        public void Test05()
        {
            _03_Person tom = new _03_Person
            {
                Name = "Tom",
                Age = 9,
                Home = { Town = "yoooo", Country = "CN" },
                Friends =
                {
                    new  _03_Person{ Name="A" },
                    new _03_Person("B"),
                    new _03_Person() { Name="Z",Age=7},
                    new _03_Person("F")
                    {
                        Age=666,
                        Home= {  Country="UK", Town="ZZZZ"}
                    }
                }
            };


        }
    }
}
