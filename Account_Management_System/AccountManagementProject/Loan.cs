using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementProject
{
    class Loan : Account
    {
        private double loanAmmount; 
        private double diposite;

        internal double Diposite
        {
            get { return this.diposite; }
            set { this.diposite = value; }
        }

        internal double LoanAmmount
        {
            get { return this.loanAmmount; }
            set { this.loanAmmount = value; }
        }

        internal Loan(uint id, string name, double balance, OpeningDate openingDate, Address address) : base(id, name, balance, openingDate, address)
        {

        }
        public double DipositAmmount(int ammount)
        {
            base.PrintInfo();
            Console.WriteLine("\nTransaction\n--------------");
            this.Diposite = ammount;
            Console.WriteLine("Diposit : {0}", this.Diposite);
            Console.WriteLine("New Banalce : {0}", this.Balance + this.Diposite);

            return Diposite;
        }

        public double LoanProcess(int ammount)
        {
            base.PrintInfo();
            Console.WriteLine("\nTransaction\n--------------");
            Console.WriteLine("Loan: {0} taka", ammount);
            Console.WriteLine("Charge: 50 Taka");
            Console.WriteLine("Total: {0} taka", ammount + 50);

            if (ammount + 50 <= this.Balance)
            {
                this.LoanAmmount = ammount;
                Console.WriteLine("New Banalce : {0}", this.Balance - (ammount + 50));
            }
            else
            {
                Console.WriteLine("Ammount short: {0} taka", -(this.Balance - (ammount + 50)));
                Console.WriteLine("Insufficient Balance");
            }
            return LoanAmmount;
        }
    }
}

