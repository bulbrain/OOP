using System;

namespace _4.Inheritance_and_Abstraction
{
    public abstract class People
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public People(string name, string details)  {
            this.Name = name;
            this.Details = details;
        }
    }
}
