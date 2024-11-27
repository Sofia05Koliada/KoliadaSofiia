using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2222
{
    internal class Class1
    {
        // A simple method to print a greeting message
        public void PrintMessage()
        {
            Console.WriteLine("Hello, World! Welcome to modul2222.");
        }
    }

    // Example of how to use the class
    class Program
    {
        static void Main(string[] args)
        {
            Class1 example = new Class1();  // Create an instance of Class1
            example.PrintMessage();         // Call the method to print the message

            Console.ReadLine();             // Keeps the console window open
        }
    }
}
