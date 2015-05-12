using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Company_Hierarchy
{
    class SalesEmployee : Employee
    {
        public LinkedList<string> Sales { get; set; }

        public SalesEmployee(LinkedList<string> sales, int id, string firstName, string lastName, double salary, string department) : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Department = department;
        }
    }
}
