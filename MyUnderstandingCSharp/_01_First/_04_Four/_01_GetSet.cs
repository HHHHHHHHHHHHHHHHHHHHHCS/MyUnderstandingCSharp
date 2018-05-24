using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public class _01_GetSet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private static int InstanceCounter { get; set; }
        private static readonly object counterLock = new object();

        public _01_GetSet(string _name,int _age)
        {
            Name = _name;
            Age = _age;

            //虽然本来应该用别的锁的  这里为了方便快捷
            lock(counterLock)
            {
                InstanceCounter++;
            }
        }
    }
}
