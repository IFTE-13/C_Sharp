using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OurAddress a1 = new OurAddress(12, 21, 4000, "Chittgong");
            Student s1 = new Student();
            s1.SetId(100);
            s1.SetName("Bruce");
            s1.SetCGPA(6.67);
            s1.SetBloodGroup("O+ ve");
            s1.SetAddress(a1);
            s1.ShowStudentInfo();

            Student s2 = new Student(200, "Clerk", -3.12, "O- ve", new OurAddress(12, 21, 4000, "Chittgong"));
            s2.ShowStudentInfo();
        }
    }
}
