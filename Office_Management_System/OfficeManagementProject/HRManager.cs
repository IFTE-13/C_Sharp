using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    class HRManager : Employee
    {
        private double kPI;

        internal double KPI
        {
            get { return this.kPI; }
            set { this.kPI = value; }
        }

        internal HRManager(string name, string id, DateOfBirth dateOfBirth, JoiningDate joiningDate, string bloodGroup, Address address, double salary, double kPI) : base(name, id, dateOfBirth, joiningDate, bloodGroup, address, salary)
        {
            this.KPI = kPI;
        }

        internal void ShowHRManager()
        {
            base.ShowInfo();
            Console.WriteLine("Position : HR Manager");
            Console.WriteLine("KPI: {0}\n", this.KPI);
            Console.WriteLine("Salary wilth additional KPI: {0}", this.KPI + this.Salary);
        }
    }
}
