using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace week_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string greeting = "Hello there, Travaler ";
            int playerScore = 0;
            string displayScore = "your score currently is " + playerScore + ".";

            Console.WriteLine(greeting);
            Console.WriteLine(displayScore);

            playerScore = 10;
                displayScore = "your score is now" + playerScore + ".";
            Console.WriteLine(displayScore);
            Console.ReadKey();

            /// the code it writen to so that a game player can sent ints name and details onto the console with the use of writenlines along side this Readline to show the imput of ones name  . 

            //This is a comment
            /*
             The codeis writen to so that a game player can send ints name and details onto the console with 
            the use of writenlines, along side this comand Readline is oporating as a reader tp the imput of ones name  . 
            */



            Console.WriteLine("my name is steve");
            string firstName;
            string midleName;
            string lastName;
            Console.WriteLine("Hello! What is your first name?");//This line relates to the sumarry where write line is being use as output to introduce text 
            firstName = Console.ReadLine(); //THe code of line uses Readline to show the imput of ones name  
            Console.WriteLine("What is your midle name?");
            midleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("nice to meet you," + firstName + " " + midleName + " " + lastName);
            
           
            Console.ReadKey();

            string greetings = "Hello, user";
            int playerScores = 10;
            string displayScores = "your score currently is " + playerScores + ".";

            Console.WriteLine(greetings);
            Console.WriteLine(displayScores);

            playerScores = 20;
            displayScores = "your score is now" + playerScores + ".";
            Console.WriteLine(displayScores);
            Console.WriteLine("press back key to quit");
            Console.ReadKey();
            

        }
        

    }
}
