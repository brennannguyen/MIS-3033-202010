using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WPFClasses3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        /// <summary>
        /// Default/empty constructor.
        /// </summary>
        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;
        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Major = major;
            this.GPA = gpa;
        }

        public string CalculateDistinction()
        {
            string distinction;
            if (GPA <= 4.00 & GPA >= 3.80)
            {
                distinction = "summa cum laude";
            }
            else if (GPA <= 3.79 & GPA >= 3.60)
            {
                distinction = "manga cum laude";
            }
            else if (GPA <= 3.59 & GPA >= 3.40)
            {
                distinction = "cum laude";
            }
            else
            {
                distinction = "No Distinction";
            }
            return distinction;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address address = new Address(streetNumber, streetName, state, city, zipcode);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    
}
