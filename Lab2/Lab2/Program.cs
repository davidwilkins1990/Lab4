/*
 David Wilkins
 Lab 2 - Numbers challenge
 01/22/18

 This program asks a user for a number between 1 and 100 and then displays a message
 that varies depending on the number range and if its odd or even.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {


        public static void numbers()
        {
            Console.WriteLine("*** Numbers Challenge ***");
            string name = "";
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            try
            {
                Console.Write(name +", please enter a number between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());
                if (input < 0 || input > 100)
                {
                    Console.WriteLine(name + ", you must enter a number between 1 and 100");
                    numbers();
                }

                bool odd = true;

                if (input % 2 == 0)
                {
                    odd = false;
                }

                if (odd == true && input < 60)
                {
                    Console.WriteLine(name +", your number: " + input +  ", is ODD.");
                }
                
                if (input >= 2 && input <=25)
                {
                    if (odd == false)
                    {
                        Console.WriteLine(name+ ", your number: " + input + ", is EVEN and less than 25");
                    }
                }

                if (input >= 26 && input <= 60)
                {
                    if (odd == false)
                    {
                        Console.WriteLine(name + ", your number: " + input + ", is EVEN and between 26 and 60");
                    }
                }

                if (input >60)
                {
                    if (odd == false)
                    {
                        Console.WriteLine(name + ", your number: " + input + ", is EVEN and greater than 60");
                    }
                    else
                    {
                        Console.WriteLine(name + ", your number: " + input + ", is ODD and greater than 60");
                    }
                }



                Console.Write("\n" + name +  ", press 'Y' to enter a new number or any other key to exit: ");
                string again = "n";
                again = Console.ReadLine();
                again = again.ToLower();
                if (again == "y")
                {
                    Console.Clear();
                    numbers();
                }
                else
                {
                    Console.WriteLine("**** Goodbye " + name + "!   ******");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine(name + ", please enter a whole number between 1 and 100 try again \n");
                numbers();
            }
        }

        static void Main(string[] args)
        {
            
            numbers();
            Console.ReadLine();
        }
    }
}
