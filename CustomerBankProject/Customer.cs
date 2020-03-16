using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            UniqueID = ID; //customer ID, uses the main counter so each customer is the previous customer plus 1

            Random rndName = new Random();
            Random rndAge = new Random();
            Random rndMoney = new Random();
            Random rndBaseChance = new Random();



            String[] fname_List = new String[30];
            fname_List[0] = "James";
            fname_List[1] = "Peter";
            fname_List[2] = "Lucy";
            fname_List[3] = "Erin";
            fname_List[4] = "Alex";
            fname_List[5] = "Joseph";
            fname_List[6] = "Charles";
            fname_List[7] = "Karen";
            fname_List[8] = "Betty";
            fname_List[9] = "Kimberly";
            fname_List[10] = "Kenneth";
            fname_List[11] = "Ronald";
            fname_List[12] = "Jason";
            fname_List[13] = "Michelle";
            fname_List[14] = "Emily";
            fname_List[15] = "Stephanie";
            fname_List[16] = "Rebecca";
            fname_List[17] = "Ryan";
            fname_List[18] = "Eric";
            fname_List[19] = "Larry";
            fname_List[20] = "Brandon";
            fname_List[21] = "Pamela";
            fname_List[22] = "Emma";
            fname_List[23] = "Aaron";
            fname_List[24] = "Joyce";
            fname_List[25] = "Peter";
            fname_List[26] = "Keith";
            fname_List[27] = "Andrea";
            fname_List[28] = "Terry";
            fname_List[29] = "Albert";


            String[] lname_List = new String[30];
            lname_List[0] = "DAVIS";
            lname_List[1] = "TAYLOR";
            lname_List[2] = "JACKSON";
            lname_List[3] = "KING";
            lname_List[4] = "GONZALEZ";
            lname_List[5] = "PEREZ";
            lname_List[6] = "PHILLIPS";
            lname_List[7] = "ROGERS";
            lname_List[8] = "RAMIREZ";
            lname_List[9] = "BARNES";
            lname_List[10] = "WOOD";
            lname_List[11] = "BRYANT";
            lname_List[12] = "DIAZ";
            lname_List[13] = "HAMILTON";
            lname_List[14] = "ORTIZ";
            lname_List[15] = "PORTER";
            lname_List[16] = "GORDON";
            lname_List[17] = "HOLMES";
            lname_List[18] = "DUNN";
            lname_List[19] = "ARNOLD";
            lname_List[20] = "SNYDER";
            lname_List[21] = "CUNNINGHAM";
            lname_List[22] = "LAWRENCE";
            lname_List[23] = "CARR";
            lname_List[24] = "BANKS";
            lname_List[25] = "MORRISON";
            lname_List[26] = "LITTLE";
            lname_List[27] = "GEORGE";
            lname_List[28] = "BURKE";
            lname_List[29] = "CARLSON";

            // first name
            int NameChoice = rndName.Next(0,30);
            FirstName = fname_List[NameChoice];

            // last name
            NameChoice = rndName.Next(0,30);
            LastName = lname_List[NameChoice];


           
            
            int moneyGroup = 0;
            moneyGroup = rndMoney.Next(1,101);

            if(moneyGroup < 75)
            {                
               CustomerMoney = rndMoney.Next(100, 1000);
            }
           else if (moneyGroup < 95)
            {
                CustomerMoney = rndMoney.Next(1000, 5000);
            }
           else
            {
                CustomerMoney = rndMoney.Next(100000, 10000000);
            }

            BaseAcceptanceChance = rndBaseChance.Next(0,100);


        }
    }
}
