/*
 David Wilkins
 Lab 1 - room calculator
 01/22/18

 This program gets user input for dimensions of a room and then 
 calculates the area, perimeter, and volume of the room and displays it back to the user;

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcLab1
{
    class Program
    {

        public static void room()
        {
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;


            Console.WriteLine("*** Welcome to the Grand Circus' Room Detail Generator ***");
            Console.WriteLine();
            try
            {
                Console.Write("Please enter the width of the room: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Please enter the length of the room: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Please enter the height of the room: ");
                height = Convert.ToDouble(Console.ReadLine());


                area = length * width;
                perimeter = length + length + width + width;
                volume = length * width * height;

                Console.WriteLine("\nThe perimeter of the room is: " + perimeter +
                    "\nThe area of the room is: " + area +
                    "\nThe volume of the room is: " + volume);

                Console.Write("\nPress 'Y' to enter a new room or any other key to exit: ");
                string again = "n";
                again = Console.ReadLine();
                again = again.ToLower();
                if (again == "y")
                {
                    Console.Clear();
                    room();
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("You can only enter numbers for the room dimensions. Please try again. \n\n");
        
                room();
            }
            
        }
        static void Main(string[] args)
        {

            room();

            Console.ReadLine();



        }
    }
}
