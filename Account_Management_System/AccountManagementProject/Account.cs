using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementProject
{
    struct Address
    {
        private byte apartmentNo;
        private byte roadNo;
        private string district;
        private string country;

        public Address(byte apartmentNo, byte roadNo, string district, string country)
        {
            this.apartmentNo = apartmentNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address: ");
            Console.WriteLine("Appartment No: {0}", this.apartmentNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}", this.country);
        }
    }

    struct OpeningDate
    {
        private byte day;
        private string month;
        private ushort year;

        public OpeningDate(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void PrintOpeningDate()
        {
            Console.WriteLine("Joining Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    class Account
    {
        private uint id;
        private string name;
        private Address address;
        private OpeningDate openingDate;
        private double balance;

        internal uint ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set 
            { 
                if(value > 0)
                {
                    this.balance = value;
                }
                else
                {
                    this.balance = 0;
                }
            }
        }

        internal Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal OpeningDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        internal Account(uint id, string name, double balance, OpeningDate openingDate, Address address)
        {
            this.ID = id;
            this.Name = name;
            this.Balance = balance;
            this.OpeningDate = openingDate;
            this.Address = address;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("\nInformation\n------------------");
            Console.WriteLine("Id: {0}", this.ID);
            Console.WriteLine("Name: {0}", this.Name);
            this.OpeningDate.PrintOpeningDate();
            this.Address.PrintAddress();
            Console.WriteLine("Balance {0}", this.Balance);
        }
    }
}
