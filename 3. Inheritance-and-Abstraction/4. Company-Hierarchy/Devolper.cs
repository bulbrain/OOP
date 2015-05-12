using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Company_Hierarchy
{
    class Devolper : Employee
    {
        public LinkedList<string> Projects { get; set; }

        public Devolper(LinkedList<string> projects, int id, string firstName, string LastName, double salary, string department) : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Salary = salary;
            this.Department = department;
        }
    }
}
