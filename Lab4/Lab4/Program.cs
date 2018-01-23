/*
 David Wilkins
 Lab 4- Factorals
 01/22/18

 This program gets an input from the user and then finds its factoral 
 and displays it back to the user
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        public static long factoral(long input)
        {
            //stops the loop from continuing forever. 
           if (input == 0)
            {
                //0 returns 0, 2 returns double the actual answer.
                // ie with 4, it calls 4 * 3 * 2 * 1 * 1
                return 1; 
            }
            

            return input * factoral(input - 1);
        }

        public static void userInput()
        {
            Console.WriteLine("***  Factorals   ***");

            Console.Write("Please enter an integer between 1 and 59: ");


            try
            {
                long input = long.Parse(Console.ReadLine());

                if (input < 1 || input > 59)
                {
                    Console.WriteLine("Integer MUST be between 1 and 59");
                    userInput();
                }

                //calls factoral method and prints out the result
                Console.WriteLine("Result: " + factoral(input));


                Console.Write("\nPress 'Y' to enter a new number or any other key to exit: ");
                string again = "n";
                again = Console.ReadLine();
                again = again.ToLower();
                if (again == "y")
                {
                    Console.Clear();
                    userInput();
                }
                else
                {
                    Console.WriteLine("****    Goodbye!   ******");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input - you must enter an integer between 1 and 10");
                userInput();
            }
        }
        static void Main(string[] args)
        {

            userInput();

            Console.ReadLine();
        }
    }
}
