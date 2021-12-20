using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent("c#");
            //Child c = new Child("ds");//IS-A

            Person p = new Person(100, "Bruce", "B+");
            Student s = new Student(200, "Clark", "AB+", 3.21);
            Employee e = new Employee(300, "Diana", "A-", 12000);

            p.ShowInfo();
            Console.WriteLine();
            s.ShowStudentInfo();
            e.ShowEmployeeInfo();
        }
    }
}
