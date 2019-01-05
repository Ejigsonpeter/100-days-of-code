using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            string target = "";
            do
            {
                Console.WriteLine("Enter a Target");
                int val = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= val)
                {
                    Console.WriteLine(start);
                    start += 2;
                }
               
                do
                {
                    //do while loop
                    Console.WriteLine("Do you want to continue - Yes ot no");
                    target = Console.ReadLine().ToUpper();
                    if (target != "YES" && target != "NO")
                    {
                        Console.WriteLine("Invalid Choice , please Sat yes or no");
                    }
                    else if (target == "NO")
                    {
                        continue;
                    }

                }
                while (target != "YES" && target != "NO");
            }
            while (target == "YES");




            Console.ReadKey();

            
        }
    }
}
