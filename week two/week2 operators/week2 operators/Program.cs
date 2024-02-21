using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace week2_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healths = 90;
            
            Console.WriteLine("You have " + healths + " health.");
            healths = 90 + 10;
            Console.WriteLine("You have " + healths + " health.");
            Console.ReadKey();



            int health = 90;
            int healthBonus = 10;
            Console.WriteLine("You have " + health + " health.");
            health -= healthBonus;
            Console.WriteLine("You have " + health + " health.");
            Console.ReadKey();





            int score = 0;
            int pointValue = 5;
            int combo = 5;

            Console.WriteLine("The Player's score is: " + score + " points");

            combo++;
            score += pointValue * combo;
            Console.WriteLine("You scored! New score is: " + score + " points");
          
            combo++;
                score += pointValue * combo;
            Console.WriteLine("You scored! New score is: " + score + " points");

            Console.ReadKey();

            int myVariable = 5;

            Console.WriteLine("vale of variable before: " + myVariable);

            myVariable /= 3;

            Console.WriteLine("Value of Variable after: " + myVariable);
            Console.ReadKey();



            int myVariables = 5;

            Console.WriteLine("vale of variable before: " + myVariables);

            myVariable /= 3;

            Console.WriteLine("Value of Variable after: " + myVariables);
            Console.ReadKey();

           float myVariabless = 5;

            Console.WriteLine("vale of variable before: " + myVariabless);

            myVariable /= 3;

            Console.WriteLine("Value of Variable after: " + myVariabless);
            Console.ReadKey();




            int dog = 10;
            int cats = 10;


            if (dog <= cats);

            Console.WriteLine("mored cats ");
            Console.ReadKey();

           int time = 11;
            if (time < 16);
                 Console.WriteLine("good morning");
          
        }

    }
}
