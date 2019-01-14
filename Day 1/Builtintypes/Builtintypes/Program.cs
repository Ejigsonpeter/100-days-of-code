using System;


namespace Builtintypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool b = true;
            //getting minimum and Maximum Value of a Type
            Console.WriteLine("The Minimun size of Integer is {0}", int.MinValue);
            Console.WriteLine("The Maximum size of Integer is {0}", int.MaxValue);
           
            //String Types and Literals
            string Name = "Hello Peter";
            Console.WriteLine(Name);

            //escape Sequence
            string l = "\"Prince \"";
            Console.WriteLine(l);

            Console.ReadLine();
        }
    }
}
