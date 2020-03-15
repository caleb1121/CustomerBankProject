using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankProject
{
    class Customer
    {
        


        public int UniqueID { set; get; } // Used to find people 

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public int CustomerMoney { set; get; } // The amount of money the person walks into the bank with

        public int BaseAcceptanceChance { set; get; } // The base acceptance chance of the person accepting a bank account


        public Customer(int ID)

        {
            UniqueID = ID;

            
        }
    }
}
