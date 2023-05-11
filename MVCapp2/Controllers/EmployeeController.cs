using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCapp2.Models;
using MVCapp2.ViewModels;

namespace MVCapp2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult Ddetails()
        {
            Employee employee1 = new Employee()
            {
                EmployeeId = 1,
                Name = "Shahzar",
                Gender="Male",
                Department="IT",
                Salary=50000,
                AddressId=800
            };
            Employee employee2 = new Employee()
            {
                EmployeeId = 2,
                Name = "Mazhar",
                Gender = "Male",
                Department = "IT",
                Salary = 50000,
                AddressId = 900
            };
            Employee employee3 = new Employee()
            {
                EmployeeId = 3,
                Name = "Anzar",
                Gender = "Male",
                Department = "IT",
                Salary = 50000,
                AddressId = 1000
            };
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(employee1);
            employeelist.Add(employee2);
            employeelist.Add(employee3);

            Address address1 = new Address()
            {
                AddressId = 800,
                Country="India",
                State="U.P",
                City="Meerut",
                Pin="5008"
            };
            Address address2 = new Address()
            {
                AddressId = 900,
                Country = "India",
                State = "U.P",
                City = "Meerut",
                Pin = "6528"
            };
            Address address3 = new Address()
            {
                AddressId = 1000,
                Country = "India",
                State = "U.P",
                City = "Meerut",
                Pin = "7555"
            };
            List<Address> addresslist = new List<Address>();
            addresslist.Add(address1);
            addresslist.Add(address2);
            addresslist.Add(address3);

            EmployeesDetail viewModel = new EmployeesDetail()
            {
                Employee = employeelist,Address = addresslist,PageTitle="EmployeeDetailPage",PageHeader="EmployeesDetail"
            };

            return View(viewModel);
        }
    }
}