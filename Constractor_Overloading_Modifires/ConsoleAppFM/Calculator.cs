using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Calculator
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("{0}", a + b);
        }
        
        public void Addition(int a, int b, int c)
        {
            Console.WriteLine("{0}", a + b + c);
        }
        
        public void Addition(int a, int b, int c, int d)
        {
            Console.WriteLine("{0}", a + b + c + d);
        }

        public void Addition(string a, int b)
        {
            Console.WriteLine("{0}", a + b);
        }
        
        public void Addition(int a, string b)
        {
            Console.WriteLine("{0}", a + b);
        }
        
        public void Addition(char a, char b)
        {
            Console.WriteLine("{0}", a + b);
        }
        
        public void Addition(int a, int b, string c)
        {
            Console.WriteLine("{0}", a + b + c);
        }
        
        public void Addition(string a, int b, int c)
        {
            Console.WriteLine("{0}", a + b + c);
        }
        
        public int Addition()
        {
            Console.WriteLine("{0}");
            return 4;
        }

        public void Addition(int[] arr)
        {
            int count = 0, sum = 0;
            while (count < arr.Length)
            {
                sum += arr[count];
                count++;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
