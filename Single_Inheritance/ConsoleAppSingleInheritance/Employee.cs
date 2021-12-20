using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Employee : Person
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value >= 0)
                    this.salary = value;
                else
                    this.salary = -1;
            }
        }

        internal Employee(int id, string name, string bloodGroup, double salary) : base(id, name, bloodGroup)
        {
            this.Salary = salary;
        }

        internal void ShowEmployeeInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: {0}\n", this.Salary);
        }
    }
}
