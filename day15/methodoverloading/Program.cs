using System;

namespace methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            add(2,7);
        }

        public static void add(int fn,int ln ){
            Console.WriteLine("sum = {0}",fn + ln);
        }
        public static void add(int fn,int ln, int tn){
            Console.WriteLine("sum = {0}",fn+ln);
        }

    }
}
