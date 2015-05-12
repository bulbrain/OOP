using System;

namespace _4.Inheritance_and_Abstraction
{
    class Student : People
    {
        public int ClassNumber { get; set; }

        public Student(int classNumber, string name, string details = null) : base(name, details)
        {
            this.ClassNumber = classNumber;
        }
    }
}
