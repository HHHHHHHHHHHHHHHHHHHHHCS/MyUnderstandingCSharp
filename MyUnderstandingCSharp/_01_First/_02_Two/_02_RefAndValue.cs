using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    class Point
    {
        public int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }


        public override string ToString()
        {
            return string.Format("x:{0},y:{1}",x,y);
        }
    }


    public class _02_RefAndValue
    {
        public void Test()
        {
            Point p1 = new Point(1, 2);
            var p2 = p1;

            p2.x = 3;p2.y = 4;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            ChangeClass(p1);
            Console.WriteLine(p1);
        }

        private void ChangeClass(Point p)
        {
            p.x = 100;
            p.y = 100; ;
            Console.WriteLine(p);
        }
    }
}
