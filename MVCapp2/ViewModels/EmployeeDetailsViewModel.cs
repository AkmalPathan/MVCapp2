using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCapp2.Models;

namespace MVCapp2.ViewModels
{
    public class EmployeesDetail
    {
        public List<Employee> Employee { get; set; }
        public List<Address> Address { get; set; }
        
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }


    }
}