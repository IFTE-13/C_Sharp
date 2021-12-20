using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(01, "Ifte", 25000, new OpeningDate(01, "Jan", 2009), new Address(7, 13, "Dhaka", "Bangladesh"));
            a1.PrintInfo();

            Savings savings = new Savings(01, "Siam", 2500, new OpeningDate(01, "Jan", 2009), new Address(7, 13, "Dhaka", "Bangladesh"));
            savings.WithdrawAmmount(2100);
            savings.DipositAmmount(1000);

            Loan lone = new Loan(01, "Sajid", 1000, new OpeningDate(01, "Jan", 2009), new Address(7, 13, "Dhaka", "Bangladesh"));
            lone.DipositAmmount(1000);
            lone.LoanProcess(960);
            
            Current current = new Current(01, "Sami", 4000, new OpeningDate(01, "Jan", 2009), new Address(7, 13, "Dhaka", "Bangladesh"));
            current.DipositeAmmount(100);
            current.WithdrawAmmount(4500);
            
        }
    }
}
