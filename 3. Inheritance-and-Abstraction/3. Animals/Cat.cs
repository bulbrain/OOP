using System;

namespace Animals
{
    abstract class Cat : Animal
    {
        public string Color { get; set; }
        public Cat(string name, double age, string gender, string color) : base(name, age, gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.Color = color;
        }
    }
}
