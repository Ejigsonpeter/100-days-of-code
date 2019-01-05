using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 types of parameters ==> Value parameter,
            //==> reference ==>out parameters and
            //parameters arrays

            //You can pass by value and by ref
            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine(i);

            int total =0 ;
            int prod = 0;
            Calculate(10, 20, out total, out prod);
            Console.WriteLine("SUM = {0}  && PRODUCT = {1}", total, prod);


            int[] Numbers = new int[3];
            Numbers[0] = 1;
            Numbers[1] = 4;
            Numbers[2] = 5;
            ParamMethod();
            ParamMethod(Numbers);
            ParamMethod(1, 2, 3, 4, 5, 6, 7, 8);
            Console.ReadKey();

        }
        
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        //out parameter

        public static void  Calculate(int fn,int sn,out int sum, out int product)
        {
            sum = fn + sn;
            product = fn * sn;
            
        }

        //parameter arrays

        public static void ParamMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }


    }
}
