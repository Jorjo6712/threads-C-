using System;
using System.Threading;

namespace Assignment2 
{
    internal class Assignment2 
    {
        private char ch = '*';

        internal static void Main(string[] args) 
        {
            Assignment2 assignment2 = new Assignment2();
            Thread printer = new Thread(new ThreadStart(assignment2.Printer));
            Thread reader = new Thread(new ThreadStart(assignment2.Reader));

            printer.Start();
            reader.Start();
        }

        internal void Printer() 
        {
            while (true)
            {
                Thread.Sleep(500);
                Console.WriteLine(ch);
            }
        }

        internal void Reader() 
        {
            while (true)
            {
                ch = Console.ReadKey().KeyChar;
            }
        }
    }
}
