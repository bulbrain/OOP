using System;
using System.Collections.Generic;

namespace _4.Inheritance_and_Abstraction
{
    class Discpiline
    {
        public string Name { get; set; }
        public int Lecture { get; set; }
        public List<Student> Students { get; set; }
        public string Details { get; set; }

        public Discpiline(string name, int lecture, List<Student> students, string details = null)
        {
            this.Name = name;
            this.Lecture = lecture;
            this.Students = students;
            this.Details = details;
        }

    }
}
