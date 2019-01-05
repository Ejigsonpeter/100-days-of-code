using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcoffeecost = 0;
            Start:
            Console.WriteLine("Select Coffee option \n 1. Capacino \n 2. Black \n 3. Chocolate Coffee");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    totalcoffeecost += 1;
                    break;
                case 2:
                    totalcoffeecost += 2;
                    break;
                case 3:
                    totalcoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("You have selected an Invalid Choice {0}",choice);
                    goto Start;
            }
            decide:
            Console.WriteLine("Do you want to buy another Coffee ? yes or no");
            string decicion = Console.ReadLine();
            switch (decicion.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    goto decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("your Bill amount is {0}", totalcoffeecost);

            
            Console.ReadKey();

            
        }
    }
}
