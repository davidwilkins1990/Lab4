/*
 David Wilkins
 Lab 3 - powers
 01/22/18

 This program asks the user for a number and then displays from 1 to that number
 squared and cubed.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {

        public static void powers()
        {
            Console.WriteLine("***  Powers   ***");
            Console.Write("Please enter an integer: ");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input > 1000)
                {
                    Console.WriteLine("Please use a more realistic number...");
                    powers();
                }
                Console.WriteLine("Number     Squared      Cubed");
                Console.WriteLine("=======    =======     =======");

                //for numbers 1 - user input, list the number, the number squared, and cubed.
                for (int i = 1; i <= input ; i++)
                {
                    Console.WriteLine(i + "          " + i*i + "           " + i*i*i);
                }

                Console.Write("\nPress 'Y' to enter a new number or any other key to exit: ");
                string again = "n";
                again = Console.ReadLine();
                again = again.ToLower();
                if (again == "y")
                {
                    Console.Clear();
                    powers();
                }
                else
                {
                    Console.WriteLine("****    Goodbye!   ******");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input - please enter a whole number.");
                powers();
            }
        }

        static void Main(string[] args)
        {
            powers();

            Console.ReadLine();


        }
    }
}
