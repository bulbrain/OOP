using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Company_Hierarchy
{
    abstract class Employee : Person
    {
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(int id, string firstName, string lastName, double salary, string department) : base(id, firstName, lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Department = department;
        }
    }
}