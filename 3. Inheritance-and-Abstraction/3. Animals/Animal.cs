using System;
using System.Linq;

namespace Animals
{
    abstract class Animal : ISound
    {

        public string Name { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, double age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public abstract void ProduceSound();
    }

    public class test
    {

        public static void Main()
        {
            Dog[] dogArray = new Dog[4];
            dogArray[0] = new Dog("Sharo", 7, "m", "pudel");
            dogArray[1] = new Dog("Maro", 2, "m", "pekines");
            dogArray[2] = new Dog("Paro", 6, "m", "labrador");
            dogArray[3] = new Dog("Garo", 1, "m", "pudel");
            Console.WriteLine(dogArray.Average(p => p.Age));
            
            Console.ReadLine();
        }
    }
}
