using System;

namespace GamesConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Games Console Calculator";

            //Variables
            string Fullname;
            decimal Budget;


            Console.WriteLine("Welcome to the System!");
            Console.WriteLine("\n\nPress any key to start...");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Please enter your full name:  ");
            Fullname = Console.ReadLine();

            Console.Write("What is your budget? :  £ ");
            Budget = Convert.ToDecimal(Console.ReadLine());

            if (Budget >= 650)
            {
                Console.Clear();
                Console.WriteLine(Fullname + " you have £" + Budget + " to spend\n");
                Console.WriteLine("You could buy a: ");
                Console.WriteLine("Gaming PC\nXbox One X\nNintendo Switch\nNintendo Switch Lite\nPlaystation One Mini\nNES Mini\nSNES Mini\n2DS XL");
                Console.ReadKey();

            }
            else if (Budget >= 350)
            {
                Console.Clear();
                Console.WriteLine(Fullname + " you have £" + Budget + " to spend\n");
                Console.WriteLine("You could buy a: ");
                Console.WriteLine("Xbox One X\nNintendo Switch\nNintendo Switch Lite\nPlaystation One Mini\nNES Mini\nSNES Mini\n2DS XL");
                Console.ReadKey();

            }
            else if (Budget >= 220)
            {
                Console.Clear();
                Console.WriteLine(Fullname + " you have £" + Budget + " to spend\n");
                Console.WriteLine("You could buy a: ");
                Console.WriteLine("Nintendo Switch\nNintendo Switch Lite\nPlaystation One Mini\nNES Mini\nSNES Mini\n2DS XL");
                Console.ReadKey();

            }else if (Budget >= 130)
            {
                Console.Clear();
                Console.WriteLine(Fullname + " you have £" + Budget + " to spend\n");
                Console.WriteLine("You could buy a: ");
                Console.WriteLine("Playstation One Mini\nNES Mini\nSNES Mini\n2DS XL");
                Console.ReadKey();

            }else if(Budget < 130)
            {
                Console.Clear();
                Console.WriteLine(Fullname + " you have £" + Budget + " to spend\n");
                Console.WriteLine("You could buy a: ");
                Console.WriteLine("Playstation One Mini\nNES Mini\nSNES Mini\n2DS XL");
                Console.ReadKey();
            }

            

        }

    }
}
