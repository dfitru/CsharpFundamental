using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07__Inheritance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PersonExample()
        {
            var person = new Person();
            person.FirstName = "Eyasu";
            person.ToString();

            var customer = new Customer(true, "Eyasu");
            customer.ToString();
            customer.FirstName = "Lawrence";
            customer.IsPrimium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmloyee = new HouryEmployee();

            List<Person> people = new List<Person>();
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmloyee);


            
        }
    }
}
