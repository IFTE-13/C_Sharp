using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[5] {12, 43, 1, 4, 92};
            int[] n2 = new int[8] {193, 59, 33, 12, 43, 1, 4, 92};
            //Calculator c = new Calculator();
            //c.Addition(9, "8");
            //c.Addition(1, 2, 3, 4);
            //c.Addition();
            //c.Addition(n1);
            //c.Addition(n2);

            //Test t = new Test();
            //t.Summation(23, 45, 2, 1, 4);
            //t.Summation(3, 5, 9, 44, 1, 54, 4, 24, 63, 90);
            //t.Summation(3, 45);
            //t.Summation();
            //t.Summation(6, 3, 1);
            //t.Summation(n1);

            //int x = 10, y = 20, z;
            //t.Swap(ref x, ref y);
            //Console.WriteLine("x:{0},y:{1}", x, y);
            //t.M1(out z);

            //t.M3(10, 20);
            //t.M4(r:5, p:6, q:7);//named

            Sample s = new Sample();
            int r = Sample.y;
            int k = s.z;
            Console.WriteLine("{0}", Days.Sunday);
        }
    }
}
