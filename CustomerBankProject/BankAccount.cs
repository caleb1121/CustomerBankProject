using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankProject
{
    class BankAccount
    {
        public int accountNumber { set; get; } // Unique account number which is based off of a customers uniqueID (should the customer also have the number saved to their object?)

        public int accountName { set; get; } // last name and first name of account owner

        public int moneyInAccount { set; get; } // The current amount of money in the account

        public int accountType { set; get; } // used to store account type

    }
}
