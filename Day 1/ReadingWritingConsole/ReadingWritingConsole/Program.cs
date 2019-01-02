using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadingWritingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Please enter your name ");
            string oName = Console.ReadLine();

            Console.WriteLine("Hello " + UserName);//writing by concartenation
            Console.WriteLine("Hello {0},{1}", UserName,oName);//writing by placeholder
            Console.ReadLine();
 
        }
    }
}
