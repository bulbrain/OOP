using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Customer
{
    class Customer : ICloneable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public int Id { get; set; }
        public int Phone { get; set; }
        public CustomerType CustType { get; set; }

        public Customer(string firstName, string middleName, string lastName, string address, string email, List<Payment> payments, int id, int phone, CustomerType custType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.Payments = payments;
            this.Id = id;
            this.Phone = phone;
            this.CustType = custType;
        }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;
            if (customer == null)
                return false;
            if (!Object.Equals(this.FirstName, customer.FirstName))
                return false;
            if (!Object.Equals(this.LastName, customer.LastName))
                return false;
            if (!Object.Equals(this.MiddleName, customer.MiddleName))
                return false;
            if (!Object.Equals(this.Address, customer.Address))
                return false;
            if (!Object.Equals(this.Email, customer.Email))
                return false;
            if (!Object.Equals(this.Payments, customer.Payments))
                return false;
            if (!Object.Equals(this.CustType, customer.CustType))
                return false;
            if (this.Id != customer.Id)
                return false;
            if (this.Phone != customer.Phone)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ MiddleName.GetHashCode() ^ Address.GetHashCode() ^ Email.GetHashCode() ^ Payments.GetHashCode() ^ CustType.GetHashCode() ^ Id.GetHashCode() ^ Phone.GetHashCode();
        }


        public override string ToString()
        {
            return "First name: " + this.FirstName + " Middle name: " + this.MiddleName + " Last name: " + this.LastName + " Address: " + this.Address + " Email: " + this.Email + " Payments: " + this.Payments + " Id: " + this.Id + " Phone: " + this.Phone + " CustType: " + this.CustType;
        }

        public static bool operator ==(Customer customer1,
                                  Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1,
                           Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static void Main(String[] args)
        {
            Payment pay = new Payment("Vodka", 2);
            List<Payment> pays = new List<Payment>();
            pays.Add(pay);
            Customer cust = new Customer("Pesho", "Peshev", "Peshkov", "Rakovski 5", "asd@asd.com", pays, 1231412, 08882312, CustomerType.OneTime);
            Console.WriteLine(cust);
            Console.ReadLine();
        }
    }
}
