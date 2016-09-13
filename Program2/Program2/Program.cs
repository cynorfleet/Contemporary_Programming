//  Christian Norfleet
//  Program 2
//  This is a console application that inputs three integers from the
//  user and displays the sum, average, and smallest and largest of the numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        // Function displays a welcome message to user
        static void Welcome()
        {
            Console.Write("This is a console application that accepts three integers from\n");
            Console.Write("the user and displays the sum, average, smallest and largest\n");
            Console.Write("of the numbers.\n\n");
        }

        //  Function will display prompt to enter values
        //  Will then add the values to List
        static void Instructions(int index, List<int> values)
        {
            Console.Write("Please enter integer ", index);
            // convert string to int and store in list
            values.Add(Int32.Parse(Console.ReadLine()));
        }

        //  Function will Display the min/max/mean/sum of values in the list
        static void Do_Opperation(List<int> values, Operation oper)
        {

            // Definitions for processing each operation
            switch (oper)
            {
                case Operation.min:
                    Console.WriteLine("The minimum is: {0}", values.Min());
                    break;
                case Operation.max:
                    Console.WriteLine("The maximum is: {0}", values.Max());
                    break;
                case Operation.mean:
                    Console.WriteLine("The mean is: {0}", (int)values.Average());
                    break;
                case Operation.sum:
                    Console.WriteLine("The sum is: {0}", values.Sum());
                    break;
            }
        }

        // Pause function will accept a string to display before pausing program
        static void Pause(string msg)
        {
            Console.Write(msg);
            Console.ReadKey();
        }

        // Add a blank line
        static void Blank_line() { Console.WriteLine(); }

        // declares the type of operation to be performed 
        enum Operation { min, max, mean, sum };

        static void Main(string[] args)
        {
            // Variable holding number of values to be entered
            const int numb_values = 3;
            // Creates a List to hold values
            List<int> user_input = new List <int>();

            // Show welcome message
            Welcome();

            // Loop for amount of values to be entered
            for(int i=1; i <=numb_values; i++)
            {
               Instructions(i, user_input);
            }

            Blank_line();
            // Call appropriate functions to process operations
            Do_Opperation(user_input, Operation.min);
            Do_Opperation(user_input, Operation.max);
            Do_Opperation(user_input, Operation.sum);
            Do_Opperation(user_input, Operation.mean);
            Blank_line();
            // Call the pause function before exiting program
            Pause("Press any key to exit");
        }
    }
}
