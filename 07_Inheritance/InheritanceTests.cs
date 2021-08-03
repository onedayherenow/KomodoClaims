using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
	[TestClass]
	public class InheritanceTests
	{
		[TestMethod]
		public void PersonExamples()
		{
			//var person = new person();//assigning person class to person
			//person.firstname = "joshua";
			//person.tostring();  //is an inherited method from the object class

			var customer = new Customer(true, "Daniel", "Zuluaga", "123456889", "onedayzhearnows@gmail.com");
			customer.ToString();
			customer.FirstName = "Lawrence";
			customer.IsPremium = true;

			var employee = new Employee();
			employee.FirstName = "Luke";
			employee.HireDate = DateTime.Today;

			var hourlyEmployee = new HourlyEmployee();

			List<Person> people = new List<Person>();

			List<int> numbers = new List<int>();
			people.Add(person);
			people.Add(customer);
			people.Add(employee);
			people.Add(hourlyEmployee);

			
			
		}
	}
}
