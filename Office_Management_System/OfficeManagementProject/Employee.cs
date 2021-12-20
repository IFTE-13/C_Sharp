using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementProject
{
    struct DateOfBirth
    {
        private byte day;
        private string month;
        private ushort year;

        public DateOfBirth(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void PrintDateOfBirth()
        {
            Console.WriteLine("Date of birth - {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    struct JoiningDate
    {
        private byte day;
        private string month;
        private ushort year;

        public JoiningDate(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void PrintJoiningDate()
        {
            Console.WriteLine("Joining Date - {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    struct Address
    {
        private string thana;
        private string district;
        private string phoneNo;

        public Address(string thana, string district, string phoneNo)
        {
            this.thana = thana;
            this.district = district;
            this.phoneNo = phoneNo;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address : ");
            Console.WriteLine("Thana {0}", this.thana);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Phone No: {0}", this.phoneNo);
        }
    }
    class Employee
    {
        private string name;
        private string id;
        private DateOfBirth dateOfBirth;
        private JoiningDate joiningDate;
        private string bloodGroup;
        private Address address;
        private double salary;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        internal Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal DateOfBirth DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        internal JoiningDate JoiningDate
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }

        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        internal Employee(string name, string id, DateOfBirth dateOfBirth, JoiningDate joiningDate, string bloodGroup, Address address, double salary)
        {
            this.Name = name;
            this.ID = id;
            this.DateOfBirth = dateOfBirth;
            this.JoiningDate = joiningDate;
            this.BloodGroup = bloodGroup;
            this.Address = address;
            this.Salary = salary;

        }

        public void ShowInfo()
        {
            Console.WriteLine("\nInformation\n------------------");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Id: {0}", this.ID);
            this.DateOfBirth.PrintDateOfBirth();
            this.JoiningDate.PrintJoiningDate();
            Console.WriteLine("Blood Group {0}", this.BloodGroup);
            Console.WriteLine("Salary {0}", this.Salary);
            this.Address.PrintAddress();
        }
    }
}
