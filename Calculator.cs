using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            //Variables
            int Number1 = 23;
            int Number2 = 10;
            int Answer;

            Console.WriteLine("Number 1: " + Number1);
            Console.WriteLine("Number 2: " + Number2);
            Answer = Number1 + Number2;
            Console.WriteLine("\n" + Number1 + " + " + Number2 + " = " + Answer);
            Answer = Number1 - Number2;
            Console.WriteLine("\n" + Number1 + " - " + Number2 + " = " + Answer);
            Answer = Number1 * Number2;
            Console.WriteLine("\n" + Number1 + " x " + Number2 + " = " + Answer);
            Answer = Number1 / Number2;
            Console.WriteLine("\n" + Number1 + " / " + Number2 + " = " + Answer);
            Console.ReadLine();


        }
    }
}
