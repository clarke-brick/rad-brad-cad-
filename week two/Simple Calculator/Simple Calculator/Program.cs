using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // users intoface 
            float number1;
            float number2;
            string userOperation;
            Console.WriteLine("welcome to the calculater ");

            Console.WriteLine("enter first number");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            number2 = float.Parse(Console.ReadLine());


            Console.WriteLine("enter operation: + - / *");
            userOperation = Console.ReadLine();
            // the input of code 




            float result = 0; 
                
       

            switch (userOperation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;

                    


            }
            Console.WriteLine("Result is " + result);
            Console.ReadKey();

            if (userOperation == "+")
            {
                Console.WriteLine("not right");
            }
            else if (userOperation == "-")
            {
                Console.WriteLine("not right");
            }
            else if (userOperation == "/")
            {
                Console.WriteLine("not right");
            }
            else if (userOperation == "*")
            {
                Console.WriteLine("not right");
            }

            Console.ReadKey();



        }
    }
}
