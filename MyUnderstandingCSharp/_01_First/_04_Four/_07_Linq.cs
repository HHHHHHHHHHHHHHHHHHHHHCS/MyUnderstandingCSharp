using System;
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
}
