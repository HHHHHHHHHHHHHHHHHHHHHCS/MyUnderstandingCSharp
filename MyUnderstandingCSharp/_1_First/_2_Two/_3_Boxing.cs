﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._1_First._2_Two
{
    public class _3_Boxing
    {

        public void Test()
        {
            int i = 5;
            object o = i;
            o = 10;
            int j = (int)o;

            Console.WriteLine(string.Format("{0},{1},{2}", i, o, j));
        }
    }
}
