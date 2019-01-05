using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[3];
            array[0] = 3;
            array[1] = 4;
            array[2] = 7;
            int i = 0;

            for (int h = 0; h <=20; h++)
            {
                if(h % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(h);
            }

            foreach (int k in array)
            {
                Console.WriteLine(k );
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
            Console.ReadKey();

            

            
        }
    }
}
