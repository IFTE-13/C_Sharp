using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    class MarketAnalyst : Employee
    {
        private double comission;

        internal double Comission
        {
            get { return this.comission; }
            set { this.comission = value; }
        }

        internal MarketAnalyst(string name, string id, DateOfBirth dateOfBirth, JoiningDate joiningDate, string bloodGroup, Address address, double salary, double comission) : base(name, id, dateOfBirth, joiningDate, bloodGroup, address, salary)
        {
            this.Comission = comission;
        }

        internal void ShowMarketAnalyst()
        {
            base.ShowInfo();
            Console.WriteLine("Position : Market Analyst");
            Console.WriteLine("Comission: {0}", this.Comission);
            Console.WriteLine("After Adding Comission: {0}", this.Comission + this.Salary);
        }
    }
}
