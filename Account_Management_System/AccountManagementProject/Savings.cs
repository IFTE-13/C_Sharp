using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementProject
{
    class Savings : Account
    {
        private double withdraw;
        private double diposite;

        internal double Diposite
        {
            get { return this.diposite; }
            set { this.diposite = value; }
        }

        internal double Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        internal Savings(uint id, string name, double balance, OpeningDate openingDate, Address address) : base(id, name, balance, openingDate, address)
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


        public double WithdrawAmmount(int ammount)
        {
            base.PrintInfo();
            Console.WriteLine("\nTransaction\n--------------");

            if(ammount > 2000)
            {
                Console.WriteLine("Withdraw amount = {0}", ammount);
                Console.WriteLine("Maximum Withdraw Limit: 2000Taka");
            }
            else if(ammount > this.Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                this.Withdraw = ammount;
                Console.WriteLine("Withdraw : {0}", this.Withdraw);
                Console.WriteLine("New Banalce : {0}", this.Balance - this.Withdraw);
            }

            return Withdraw;
        }
    }
}
