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

            bool runProgram = true;





            Console.WriteLine("Welcome to the banking app");
            Console.WriteLine("How many customers would you like to generate? (1-500 for best performance)");
           
            string generateCustomerNum = Console.ReadLine(); // Set the amount of customers to generate
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

                
                Console.WriteLine("Generated user:" + PersonIDCounter + " of " + generateCustomerInt); //print last customer generated
                PersonIDCounter++; // used to keep track of how many customers have been generated

                Thread.Sleep(50);


            }


           
            
            Console.ResetColor(); // reset colour after changing colour to represent generation progress
            Console.Clear(); // clear console to remove customer generation data from the screen

            runprogram();


            void runprogram()
            {
                while(runProgram)
                {
                    Console.Clear(); // used to remove end of day report

                    Console.WriteLine("Please choose one of the following options:");
                    Console.WriteLine("1. Simulate next day");
                    Console.WriteLine("2. search bank records");
                    Console.WriteLine("3. Quit");

                    string Userchoice = Console.ReadLine();

                    Console.Clear();


                    if (Userchoice == "1")
                    { simulateBankDay(); } 


                    if (Userchoice == "3")
                    { System.Environment.Exit(0); }




                    void simulateBankDay()
                    {
                        int simProgress = 0; // used to store current sim progress

                        int totalDeposits = 0; // used to display total money put into bank at the end of each day
                        int customerIn = 0; // customers that have entered the bank
                        int customerOut = 0; // customer that have walked past the bank


                        foreach (Customer customer in Customers) //used to loop through every customer and perform action
                        {

                            Random rndDepChoiceNum = new Random();
                            int depChoice;



                            depChoice = rndDepChoiceNum.Next(1, 200); // compared to "baseacceptancechance" to decide whether the customer stays with the bank (was originally 1, 100)

                            Thread.Sleep(10); // used to slow sim down to help random number generator



                            if (customer.BaseAcceptanceChance > depChoice) // The customer walks into the bank 
                            {                               

                                Thread.Sleep(1); // can be used to slow program down to make it easier to read



                                int depositPercentageInt; // how much of the customers money they wish to deposit
                                float depositPercentageFloat; // same as above but used to convert it into a float
                                depositPercentageInt = rndDepChoiceNum.Next(10, 70); // after division will be between 0.1 to 0.7
                                depositPercentageFloat = depositPercentageInt / 100.0f; // this is the division

                                int depositAmount = Convert.ToInt32(customer.CustomerMoney * depositPercentageFloat); // calculate deposit amount


                                

                                int depositNegotiate; // used to decide whether the customer is convinced to deposit more money by the bank teller
                                depositNegotiate = rndDepChoiceNum.Next(0, 2); // random number used to decide whether the user deposits more money

                                if (depositNegotiate == 1) // deposit more
                                {
                                    depositAmount = depositAmount + depositAmount / 10; // calculate new deposit amount                                    
                                }

                                else // don't deposit more
                                {

                                }

                               
                                customer.CustomerBankAccountMoney = customer.CustomerBankAccountMoney + depositAmount; // customer money is put into the bank
                                customer.CustomerMoney = customer.CustomerMoney - depositAmount; // removing customer money from customer (because it is now in the bank account)

                                // everything below is used to calculate end of day report

                               totalDeposits = totalDeposits + depositAmount; // add each customers deposit to total deposits
                               customerIn = customerIn+1; // count customer that have entered the bank

                            }



                            else // customer walks past the bank instead
                            {
                                customerOut = customerOut+1; // count customers that have walked past the bank
                            }

                            
                            simProgress = simProgress + 1; // plus one to current progress
                            Console.Clear(); // clear console before displaying new progress
                            Console.WriteLine("Sim progress: " + simProgress + "/" + generateCustomerNum); // display current progress

                        } //simulate a bank day

                        Console.Clear(); // clear bank progress counter
                        Console.WriteLine("End of day report:");
                        Console.WriteLine("Total deposits: £" + totalDeposits); // Format into currency at some point!!!
                        Console.WriteLine("Customers that entered the bank: " + customerIn);
                        Console.WriteLine("Customers that walked past the bank: " + customerOut);

                        Console.ReadKey();


                    }

                }
            }

            
        }
    }
}
