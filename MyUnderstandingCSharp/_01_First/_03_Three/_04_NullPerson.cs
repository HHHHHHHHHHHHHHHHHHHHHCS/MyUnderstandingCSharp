using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _04_NullPerson
    {
        DateTime birth;
        DateTime? death;
        string name;

        public TimeSpan Age
        {
            get
            {
                if(death==null)
                {
                    return DateTime.Now - birth;
                }
                else
                {
                    return death.Value - birth;
                }
            }

        }

        public _04_NullPerson(string _name ,DateTime _birth,
            DateTime? _death = null)
        {
            name = _name;
            birth = _birth;
            death = _death;
        }

        public static void Test()
        {
            _04_NullPerson p1 = new _04_NullPerson("XX"
                , new DateTime(1912, 6, 23), new DateTime(1954, 6, 7));
            Console.WriteLine( p1.Age);
            _04_NullPerson p2 = new _04_NullPerson("XX", new DateTime(2000, 6, 23));
            Console.WriteLine(p2.Age);
        }
    }
}
