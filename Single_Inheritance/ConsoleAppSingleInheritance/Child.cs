using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Child : Parent
    {
        internal Child() : this(78)
        {
            Console.WriteLine("Child DC");
        }
        
        internal Child(int q) : base("hello")
        {
            Console.WriteLine("Child PC-I " + q);
        }

        internal Child(string a) : this()
        {
            Console.WriteLine("Child PC-S " + a);
        }
    }
}
