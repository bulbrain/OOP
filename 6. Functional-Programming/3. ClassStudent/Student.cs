using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ClassStudent
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public static void Main(String[] args)
        {
            List<int> marks1 = new List<int>(new int[] { 2, 2, 3 });
            Student student1 = new Student("Pesho", "Peshev", 23, 21312312, "0888912312", "pesho@pestera.com", marks1, 2);

            List<int> marks2 = new List<int>(new int[] { 4, 2, 5 });
            Student student2 = new Student("Ivan", "Ivanov", 23, 21312312, "0888912312", "pesho@pestera.com", marks2, 2);

            List<int> marks3 = new List<int>(new int[] { 6, 6, 5 });
            Student student3 = new Student("Petya", "Petkova", 23, 21312312, "0888912312", "pesho@pestera.com", marks3, 1);

            List<Student> students = new List<Student>(new Student[] { student1, student2, student3 });
        }
    }
}
