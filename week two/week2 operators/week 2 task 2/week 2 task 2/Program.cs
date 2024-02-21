using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int monsterDamage = 70;
            playerHealth -= monsterDamage;
            
            if(playerHealth < 0)
            {
                playerHealth = 0;
            }

            Console.WriteLine("A Monster attacked you and did " + monsterDamage + " damage, you have " + playerHealth + " health left");
            
            if(playerHealth == 0)
            {
                Console.WriteLine("you dies.game over.");

            }
            else if(playerHealth > 0)
            {
                Console.WriteLine("the monster prepares to attack you again. ");
            }
            else if(monsterDamage > 50)
            {
                Console.WriteLine("the monster is very strong");
            }
            Console.ReadKey();





        }
    }
}
