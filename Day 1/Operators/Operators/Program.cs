using System;
//C# operators

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            bool isNumber10;

            int t = 10;
            bool y;

            if (Number == 10)
            {
                isNumber10 = true;

            }
            else
            {
                isNumber10 = false;

            }
            Console.WriteLine("Number == 10 is {0}", isNumber10);
            

            //using tenary operator
            y = t == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", y);
            Console.ReadLine();
        }
    }
}
