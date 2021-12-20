using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    struct OurAddress
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public OurAddress(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Student Address");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }
    class Student
    {
        // Default access modifire is private
        private uint id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private OurAddress address;


        public uint Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name =  value; }
        }

        public double Cgpa
        {
            get { return this.cgpa; }
            set 
            {
                if (value >= 0 && value <= 4)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        public string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }
        

        public OurAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }


        // Default constructor
        public Student()
        {

        }

        // Perameterized constructor
        public Student(uint id, string name, double cgpa, string bloodGroup, OurAddress address)
        {
            this.Id = id;
            this. Name = name;
            this.Cgpa = cgpa;
            this.BloodGroup = bloodGroup;
            this.Address = address;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Info\n------------------");
            Console.WriteLine("Student Id: {0}", this.Id);
            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student CGPA: {0}", this.Cgpa);
            Console.WriteLine("Student BloodGroup: {0}\n", this.BloodGroup);
            this.Address.PrintAddress();
        }
    }
}
