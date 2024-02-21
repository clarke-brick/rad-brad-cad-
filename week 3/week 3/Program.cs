using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you where entered into contest by steve  and your job is to decide if you would take $150 or the sum of your hight in 20c coins.");



            Console.WriteLine(" step one is to enter your height in cm");
            int height = Convert.ToInt32 (Console.ReadLine());


            //0.25 = the height of coin
            //o.20 = amount coin value 


            float total = (height / 0.25f) * 0.2f;


            if (total == 150) 
            {
                Console.WriteLine("your height in 20x coins is the same as $150");

            }
            else if (total > 150)
            {
                Console.WriteLine("your height in 20c coins is more than $150. It is" + total);
            }
            else
            {
                Console.WriteLine("take the $150");
            }
            Console.ReadKey();


        }
    }
}
