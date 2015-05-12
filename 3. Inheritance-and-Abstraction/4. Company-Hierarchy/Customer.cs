using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Company_Hierarchy
{
    class Customer : Person
    {
        public double PurchaseAmount { get; set; }

        public Customer(double purchaseAmount, int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PurchaseAmount = purchaseAmount;
        }
    }
}
