using System;

namespace _2.Human_Student_Worker
{
    class Student : Human
    {
        public string FaultyNumber 
        {
            get { return this.FaultyNumber; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Faulty number must be set.");
                }
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faulty number must be between 5 and 10 characters/numbers");
                }
                this.FaultyNumber = value;
            }
        }
        
        public Student(string firstName, string lastName, string faultyNumber) : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}, Last name: {1}, Faulty number: {2}", FirstName, LastName, FaultyNumber);
        }
    }
}
