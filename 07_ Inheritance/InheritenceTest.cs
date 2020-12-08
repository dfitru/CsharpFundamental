using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07__Inheritance
{
   abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  PhoneNumber { get; set; }
        public string  Email { get; set; }
        public Person() { }
        public Person(string firstName,string lastName, string phoneNumber,string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
    class Customer : Person
    {
        public bool IsPrimium { get; set; }
        public Customer() { }
        public Customer(bool isPrimium, string firstName, string lastName, string phoneNumber, string email)
            : base(firstName, lastName, phoneNumber, email)
        {
            IsPrimium = isPrimium;

        }
    }

    class Employee : Person
    {
       public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
    }
    class HouryEmployee : Employee
    {
        public decimal HourlayWage { get; set; }
            public double Hours { get; set; }

    }
    class SalaryEmployee : Employee
    {
        public double Salary { get; set; }

    }
}
