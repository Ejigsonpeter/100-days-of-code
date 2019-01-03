using System;

 class Program
    {
        static void Main(string[] args)
        {
        //Nullable Types example
            bool? areyouokay = null;
            if (areyouokay == true)
            {
                Console.WriteLine("He is OK");
            }
            else if (areyouokay == false)
            {
                Console.WriteLine("He is not ok");
            }
            else
            {
                Console.WriteLine("Hello World! not sure ");
            }

            //null collaescing operator.

            int?  ticket = 100;
            int av;
            if (ticket == null)
            {
                av = 0;
            }
            else
            {
                av = (int)ticket;// type conversion
            }
            Console.WriteLine("Available Ticket {0}", av);

             
            Console.ReadKey();

            
        }
    }

