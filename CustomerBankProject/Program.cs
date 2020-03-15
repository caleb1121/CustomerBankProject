using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int PersonIDCounter = 0;
            List<Customer> Customers = new List<Customer>(); // used to store all the customers generated




            for (int i = 0; i < 101; i++) //generate 100 customers
            {

                //generate new customer and add to list
                Customers.Add(new Customer(PersonIDCounter));
                // finish generating and adding to list

                
                Console.WriteLine("Generated user:" + PersonIDCounter); //print last customer generated
                PersonIDCounter++; // don't be dumb


            }


            



            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.UniqueID);
            }

        }
    }
}
