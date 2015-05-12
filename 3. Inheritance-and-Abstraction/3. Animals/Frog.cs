using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        public string Type{ get; set; }
    
        public Frog(string name, double age, string gender, string type) : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = type;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Croc");
        }
    }
}
