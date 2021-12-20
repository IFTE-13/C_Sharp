using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    internal class ITExcutive : Employee
    {
        private double bonous;

        internal double Bonous
        {
            get { return this.bonous; }
            set { this.bonous = value; }
        }

        internal ITExcutive(string name, string id, DateOfBirth dateOfBirth, JoiningDate joiningDate, string bloodGroup, Address address, double salary, double bonous) : base(name, id, dateOfBirth, joiningDate, bloodGroup, address, salary)
        {
            this.Bonous = bonous;
        }

        internal void ShowITExcutive()
        {
            base.ShowInfo();
            Console.WriteLine("Position : IT Excutive");
            Console.WriteLine("Bonous: {0}", this.Bonous);
            Console.WriteLine("After Adding Bonous: {0}", this.Bonous + this.Salary);
        }
    }
}
