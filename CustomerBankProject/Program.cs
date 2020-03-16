using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CustomerBankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the banking app");
            Console.WriteLine("How many customers would you like to generate?");

            string generateCustomerNum = Console.ReadLine();
            int generateCustomerInt;

            generateCustomerInt = Convert.ToInt32(generateCustomerNum); // convert to int



            int PersonIDCounter = 0; // incremental counter "cus1 cus2... etc"
            List<Customer> Customers = new List<Customer>(); // used to store all the customers generated




            for (int i = 0; i < generateCustomerInt; i++) //generate 100 customers
            {
                if(i < generateCustomerInt * 0.25)
                { Console.ForegroundColor = ConsoleColor.Red; }

                else if (i < generateCustomerInt * 0.50)
                { Console.ForegroundColor = ConsoleColor.Yellow; }

                else if (i < generateCustomerInt * 0.75)
                { Console.ForegroundColor = ConsoleColor.Green; }




                //generate new customer and add to list
                Customers.Add(new Customer(PersonIDCounter));
                // finish generating and adding to list

                
                Console.WriteLine("Generated user:" + PersonIDCounter); //print last customer generated
                PersonIDCounter++; // don't be dumb


            }


            Console.ResetColor(); // reset colour
            Console.Clear();







            foreach (Customer customer in Customers) //used to loop through every customer and perform action
            {
                
                Random rndDepChoiceNum = new Random();
                int depChoice;

                Console.WriteLine(customer.FirstName + " walked into the bank");
                Console.WriteLine("Bank Teller negotiating with client... ");



                depChoice = rndDepChoiceNum.Next(1, 100);

               Thread.Sleep(1000);



                if (customer.BaseAcceptanceChance > depChoice)
                {
                    Console.WriteLine("Success!");

                    Console.WriteLine("The customer is entering their info and setting up an account");

                    Thread.Sleep(2000);

                    Console.WriteLine("");

                    Console.WriteLine("Bank account creation successful");
                    Console.WriteLine("New bank account details:");
                    Console.WriteLine("Account Name: " + customer.LastName + " " + customer.FirstName);
                    Console.WriteLine("Account Number: " + customer.UniqueID);
                    Console.WriteLine("Current balance: 0");

                    Console.WriteLine("");


                    int depositPercentageInt;
                    float depositPercentageFloat;
                    depositPercentageInt = rndDepChoiceNum.Next(10, 70); // after division will be between 0.1 to 0.7
                    depositPercentageFloat = depositPercentageInt / 100.0f;

                    int depositAmount = Convert.ToInt32(customer.CustomerMoney * depositPercentageFloat); // calculate deposit amount


                    Console.WriteLine("The customer has: £" + customer.CustomerMoney + " and would like to deposit: £" + depositAmount);




                }

                else
                {
                    Console.WriteLine("The customer wasn't impressed and left...");
                }






               // Console.WriteLine(customer.UniqueID); // this is the action 
              //  Console.WriteLine(customer.LastName); // this is the action 
               // Console.WriteLine(customer.FirstName); // this is the action 
              //  Console.WriteLine("£" + customer.CustomerMoney); // this is the action 
             //   Console.WriteLine(customer.BaseAcceptanceChance + "%"); // this is the action 

                Console.WriteLine("");
            }

        }
    }
}
