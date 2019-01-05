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
            Console.WriteLine("Enter a Target");
            int val = int.Parse(Console.ReadLine());

            int start = 0;
            while (start <= val)
            {
                Console.WriteLine(start);
                start += 2;
            }
           
            Console.ReadKey();

            
        }
    }
}
