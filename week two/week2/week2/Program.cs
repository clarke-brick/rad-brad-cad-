using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";

            Console.WriteLine("enter first name");
            firstName = Console.ReadLine();

            Console.WriteLine("enter last name");
            lastName = Console.ReadLine();

            string fullName = firstName.ToUpper() + lastName.ToUpper();
        
            Console.WriteLine(fullName);
            Console.ReadKey();
           
        }
    }
}
