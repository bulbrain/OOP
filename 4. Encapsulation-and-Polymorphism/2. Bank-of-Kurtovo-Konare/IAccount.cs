using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank_of_Kurtovo_Konare
{
    interface IAccount
    {
        void DepositMoney(decimal money);

        decimal CalculateInterest(decimal money, int months);
    }
}
