using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Inheritance_and_Abstraction
{
    class School
    {
        public static void Main()
        {
            Student stud = new Student(12, "Ivan");
            Console.WriteLine(stud);
            Console.ReadLine();
        }
    }
}
