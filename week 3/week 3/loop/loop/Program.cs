using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("would you like to play again (y/n)");


                string userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "Y")
                    isRunning = true;
                else
                    isRunning = false;

                
            }
            Console.WriteLine("thanks for playing");
            Console.ReadKey();
            

            bool isRunnings = true;

            Random rnd = new Random();
            int number;


            while (isRunning)
            {
                number = rnd.Next(1, 100);

                Console.WriteLine("would you like to play again(y / n");
                string userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "y")
                    isRunnings = true;
                else 
                    isRunning = false;

                number = rnd.Next(1, 100);

                Console.WriteLine("Guess my number within 5 turns....");

                for(int i = 0; i < 5; i++)
                {
                    int guess = int.Parse(Console.ReadLine());
                    
                    if (guess == number)
                    {
                        Console.WriteLine("congrats! you guessed correct!");
                        break;

                    }
                    else if (guess>number)
                    {
                        Console.WriteLine("lower...");
                    }
                    else
                    {
                        Console.WriteLine("higher...");
                    }
                }

                Console.WriteLine("would you like to play again (y/n?");

            }
        }
    }
}
