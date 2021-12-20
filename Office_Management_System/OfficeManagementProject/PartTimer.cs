using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    class PartTimer : Employee
    {
        internal PartTimer(string name, string id, DateOfBirth dateOfBirth, JoiningDate joiningDate, string bloodGroup, Address address, int salary) : base(name, id, dateOfBirth, joiningDate, bloodGroup, address, salary)
        {
        }

        internal void ShowPartTimer()
        {
            base.ShowInfo();
            Console.WriteLine("Position : Part Timer");
        }
    }
}
