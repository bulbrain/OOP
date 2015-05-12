using System;
using System.Collections.Generic;

namespace _4.Inheritance_and_Abstraction
{
    public class Class
    {

        public string ClassID { get; set; }
        public string Details { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Class(string classID, List<Teacher> teachers, string details = null)
        {
            this.ClassID = classID;
            this.Details = details;
            this.Teachers = teachers;
        }
    }
}