using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Test
    {
        //params
        public void Summation(params int[] arr)
        {
            int count = 0, sum = 0;
            while (count < arr.Length)
            {
                sum += arr[count];
                count++;
            }
            Console.WriteLine("{0}", sum);
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a:{0},b:{1}", a, b);
        }

        public void M1(out int c)
        {
            //z = 8;
            c = 0;
        }

        public void M2(int w, string q, Calculator u, double[] r, ref bool z, out ushort t, params byte[] p)
        {
            t = 0;
        }

        public void M3(int x = 1, int y = 2, int z = 3)
        {
        }

        public void M4(int p, int q, int r)
        {
        }

        public void M5(ref bool w)
        {
        }
        
        //public void M5(out bool w)
        //{
        //}
    }
}
