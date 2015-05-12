using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double age, string gender, string breed) : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Breed = breed;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau");
        }
    }
}
