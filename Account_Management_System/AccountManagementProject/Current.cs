using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementProject
{
    class Current : Account
    {
        private double currentWithdraw;
        private double diposite;

        internal double Diposite
        {
            get { return this.diposite; }
            set { this.diposite = value; }
        }

        internal double CurrentWithdraw
        {
            get { return this.currentWithdraw; }
            set { this.currentWithdraw = value; }
        }

        internal Current(uint id, string name, double balance, OpeningDate openingDate, Address address) : base(id, name, balance, openingDate, address)
        {

        }

        public double DipositeAmmount(int ammount)
        {
            base.PrintInfo();
            Console.WriteLine("\nTransaction\n--------------");
            if (ammount < 500)
            {
                Console.WriteLine("Minimum Diposite Limit: 200Taka");
                Console.WriteLine("Diposite : {0} taka", ammount);
            }
            else
            {
                Console.WriteLine("Diposite : {0} taka", ammount);
                Console.WriteLine("New Banalce : {0}", this.Balance + ammount);
            }
            return Diposite;
        }

        public double WithdrawAmmount(int ammount)
        {
            base.PrintInfo();
            Console.WriteLine("\nTransaction\n--------------");
            if (ammount > 5000)
            {
                Console.WriteLine("Attempted withdraw amount = {0}", ammount);
                Console.WriteLine("Maximum Withdraw Limit: 5000Taka");
            }
            else if (ammount > this.Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                this.CurrentWithdraw = ammount;
                Console.WriteLine("Withdrawing : {0}", this.CurrentWithdraw);
                Console.WriteLine("New Banalce : {0}", this.Balance - this.CurrentWithdraw);
            }
            return CurrentWithdraw;
        }
    }
}

