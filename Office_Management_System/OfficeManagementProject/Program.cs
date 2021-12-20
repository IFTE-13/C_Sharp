using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Sami", "E-0000", new DateOfBirth(01, "JAN", 1987), new JoiningDate(31, "DEC", 2018), "AB+", new Address("Double Morring", "Chittagong", "01324567891"), 21000);
            e.ShowInfo();

            ITExcutive i1 = new ITExcutive("Mariam", "E-0001", new DateOfBirth(29, "SEP", 1990), new JoiningDate(31, "OCT", 2015), "AB+", new Address("Polton", "Chittagong", "01324567891"), 40000, 500);
            i1.ShowITExcutive();

            HRManager h2 = new HRManager("Iftekhar", "E-0002", new DateOfBirth(09, "MAR", 1886), new JoiningDate(01, "SEP", 2015), "B-", new Address("Bandor", "Mongla", "01324567891"), 45000, 700);
            h2.ShowHRManager();

            MarketAnalyst a3 = new MarketAnalyst("Siam", "E-0003", new DateOfBirth(09, "DEC", 1886), new JoiningDate(17, "AUG", 2019), "B-", new Address("Airport", "Dhaka", "01324567891"), 30000, 1000);
            a3.ShowMarketAnalyst();

            PartTimer p4 = new PartTimer("Sajid", "E-0004", new DateOfBirth(09, "APR", 1992), new JoiningDate(01, "SEP", 2021), "B-", new Address("Pathantui", "Chittagong", "01324567891"), 15000);
            p4.ShowPartTimer();
        }
    }
}
