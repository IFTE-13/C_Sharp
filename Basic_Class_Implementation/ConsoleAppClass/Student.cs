using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
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

        public uint GetId()
        {
            return this.id;
        }
        public void SetId(uint id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCGPA()
        {
            return this.cgpa;
        }
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 4)
                this.cgpa = cgpa;
            else
                this.cgpa = -1;
        }

        public string GetBloodGroup()
        {
            return this.bloodGroup;
        }
        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }

        public OurAddress GetAddress()
        {
            return this.address;
        }

        public void SetAddress(OurAddress address)
        {
            this.address = address;
        }



        // Default constructor
        public Student()
        {

        }

        // Perameterized constructor
        public Student(uint id, string name, double cgpa, string bloodGroup, OurAddress address)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetCGPA(cgpa); //this.cgpa = cgpa;
            this.SetBloodGroup(bloodGroup);
            this.SetAddress(address);
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Info\n------------------");
            Console.WriteLine("Student Id: {0}", this.GetId());
            Console.WriteLine("Student Name: {0}", this.GetName());
            Console.WriteLine("Student CGPA: {0}", this.GetCGPA());
            Console.WriteLine("Student BloodGroup: {0}\n", this.GetBloodGroup());
            this.GetAddress().PrintAddress();
        }
    }
}
