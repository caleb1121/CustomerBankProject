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
           
            string generateCustomerNum = Console.ReadLine(); // Set the amount of customers to generate



            Console.WriteLine("type 1 for manual mode"); // used to allow the user to generate users by button press

            string manORautochoice = Console.ReadLine();



            Console.WriteLine("type 1 for easy read mode"); // used to allow the user to generate users by button press

            string easyReadchoice = Console.ReadLine();



            Console.Clear();
            
            
            
            
            int generateCustomerInt; // create variable to store conversion from string to int
            generateCustomerInt = Convert.ToInt32(generateCustomerNum); // convert to int



            int PersonIDCounter = 0; // incremental counter "customer1 customer2... etc"
            List<Customer> Customers = new List<Customer>(); // used to store all the customers generated using a list




            for (int i = 0; i < generateCustomerInt; i++) //generate specified number of customers
            {
               
                // if statements below used to set console colour to represent progress of generating customers
                
                if(i < generateCustomerInt * 0.25)
                { Console.ForegroundColor = ConsoleColor.DarkRed; }

                else if (i < generateCustomerInt * 0.50)
                { Console.ForegroundColor = ConsoleColor.Red; }

                else if (i < generateCustomerInt * 0.75)
                { Console.ForegroundColor = ConsoleColor.Yellow; }

                else if (i < generateCustomerInt * 0.99)
                { Console.ForegroundColor = ConsoleColor.Green; }




                //generate new customer and add to list
                Customers.Add(new Customer(PersonIDCounter));
                // finish generating and adding to list

                
                Console.WriteLine("Generated user:" + PersonIDCounter); //print last customer generated
                PersonIDCounter++; // used to keep track of how many customers have been generated

                Thread.Sleep(50);


            }


           
            
            Console.ResetColor(); // reset colour after changing colour to represent generation progress
            Console.Clear(); // clear console to remove customer generation data from the screen





            foreach (Customer customer in Customers) //used to loop through every customer and perform action
            {
                
                Random rndDepChoiceNum = new Random();
                int depChoice;

                Console.WriteLine(customer.FirstName + " walked into the bank");
                Console.WriteLine("Bank Teller negotiating with client... ");



                depChoice = rndDepChoiceNum.Next(1, 100); // compared to "baseacceptancechance" to decide whether the customer stays with the bank

                Thread.Sleep(250);



                if (customer.BaseAcceptanceChance > depChoice) // The customer wishes to take out an account
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success!");
                    Console.ResetColor();

                    Console.WriteLine("The customer is entering their info and setting up an account");

                    Thread.Sleep(1); // can be used to slow program down to make it easier to read

                    Console.WriteLine("");

                    Console.WriteLine("Bank account creation successful");
                    Console.WriteLine("New bank account details:");
                    Console.WriteLine("Account Name: " + customer.LastName + " " + customer.FirstName);
                    Console.WriteLine("Account Number: " + customer.UniqueID);
                    Console.WriteLine("Current balance: 0");

                    Console.WriteLine("");


                    int depositPercentageInt; // how much of the customers money they wish to deposit
                    float depositPercentageFloat; // same as above butused to convert it into a float
                    depositPercentageInt = rndDepChoiceNum.Next(10, 70); // after division will be between 0.1 to 0.7
                    depositPercentageFloat = depositPercentageInt / 100.0f;

                    int depositAmount = Convert.ToInt32(customer.CustomerMoney * depositPercentageFloat); // calculate deposit amount


                    Console.WriteLine("The customer has: £" + customer.CustomerMoney + " and would like to deposit: £" + depositAmount); // print the total money and how much the customer wants to deposit


                    Console.WriteLine("Convincing customer to deposit more money..."); 

                    int depositNegotiate;
                    depositNegotiate = rndDepChoiceNum.Next(0, 2); // random number used to decide whether the user deposits more money

                    if(depositNegotiate == 1) // deposit more
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Success!");
                        Console.ResetColor();

                        depositAmount = depositAmount + depositAmount / 10; // calculate new deposit amount

                        Console.WriteLine("New deposit amount: £" + depositAmount);
                    }

                    else // don't deposit more
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Failed...");
                        Console.ResetColor();
                    }




                }



                else // customer leaves the bank without opening an account
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The customer wasn't impressed and left...");
                    Console.ResetColor();
                }






               // Console.WriteLine(customer.UniqueID); // this is the action 
              //  Console.WriteLine(customer.LastName); // this is the action 
               // Console.WriteLine(customer.FirstName); // this is the action 
              //  Console.WriteLine("£" + customer.CustomerMoney); // this is the action 
             //   Console.WriteLine(customer.BaseAcceptanceChance + "%"); // this is the action 

                Console.WriteLine("");

                if(manORautochoice == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to generate next customer...");
                    Console.ReadKey();

                    if(easyReadchoice == "1")
                    { Console.Clear(); }
                    
                }
                
            }


            Console.ReadKey();
        }
    }
}
