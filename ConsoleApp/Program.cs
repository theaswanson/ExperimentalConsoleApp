using System;

namespace ConsoleApp
{
    public class Program
    {
        /// <summary>
        /// A simple command-line application using DragonFruit.
        /// </summary>
        /// <param name="number">The integer to print</param>
        /// <param name="verbose">Flag to print verbose output</param>
        static void Main(int number, bool verbose = false)
        {
            var output = verbose ? $"The numeric representation of the value you have just entered is expressed with the following characters on your display: {number}" : $"Number: {number}";
            Console.WriteLine(output);
        }
    }
}
