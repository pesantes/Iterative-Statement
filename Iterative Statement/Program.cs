/*
Author: Fernando Pesantes
Date: 1/21/2019
Assignment: Iterative Statement for ISM 4300 Class Project

 */

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value between 1 and 100: " +
                "");



            // Try-catch to make sure no invalid input is inputted. 
            try
            {
                // This variable will gather input from the user
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);

                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("A For Loop will execute");
                    Console.WriteLine("You have entered: " + value_of_input.ToString());

                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("This is the current integer in the loop: " + i.ToString());
                    }
                    Console.WriteLine("To exit please press any key");
                    Console.ReadKey(true);
                }
                // If the user types a value outside of the range.
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try

            catch
            {
                Console.WriteLine("Please type a whole integer between 1 and 100 next time");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
           
            } // End of catch
        } // End of main
    }
}
