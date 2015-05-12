using System;

    public class Persons 
    {
        private string name;
        private int age;
        private string email;

        public Persons(string name, int age, string email = "")
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Persons(string name, int age) : this(name, age, string.Empty)
        {
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name is empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get 
            { 
                return this.age; 
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid age.");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get 
            { 
                return this.email; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.email = "(No email)";
                }
                else if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Age, this.Email);
        }

        public class Test
        {
            public static void Main(string[] args)
            {
                Persons test1 = new Persons("Gosho", 23, "gosho@mail.com");
                Persons test2 = new Persons("Gosho", 23);

                Console.WriteLine(test1);
                Console.WriteLine(test2);
                Console.ReadLine();
            }
        }
    }
