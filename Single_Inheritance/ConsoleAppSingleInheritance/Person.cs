using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Person
    {
        private int id;
        private string name;
        private string bloodGroup;

        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        //internal Person()
        //{
        //}

        internal Person(int id, string name, string bloodGroup)
        {
            this.Id = id;
            this.Name = name;
            this.BloodGroup = bloodGroup;
        }

        internal void ShowInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Blood Group: {0}", this.BloodGroup);
        }
    }
}
