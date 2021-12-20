using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Parent
    {
        internal Parent() : this(12)
        {
            Console.WriteLine("Parent DC");
        }

        internal Parent(int a)
        {
            Console.WriteLine("Parent PC-I " + a);
        }
        
        internal Parent(string a) : this()
        {
            Console.WriteLine("Parent PC-S " + a);
        }
    }
}
