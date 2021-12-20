using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    internal class Student : Person
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if (value >= 0 && value <= 4)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        internal Student(int id, string name, string bloodGroup, double cgpa) : base(id, name, bloodGroup)
        {
            this.Cgpa = cgpa;
        }

        internal void ShowStudentInfo()
        {
            base.ShowInfo();
            Console.WriteLine("CGPA: {0}\n", this.Cgpa);
        }
    }
}
