using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Customer
    {
        string _firstname;
        string _lastname;
        //constructor
        public Customer(string firstname, string lastname)
        {
            this._firstname = firstname;
            this._firstname = lastname;

        }
        //parameter less constructor
        public Customer() 
            : this("No first name entered","no lastname added")
        {

        }

        //print 
        public void printfullname()
        {
            Console.WriteLine("The fullname {0} and lastname  {1}",this._firstname,this._lastname);
        }

        ~Customer()
        {
            //destroy
        }
        

        

    }


    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            c1.printfullname();
            Console.ReadKey();
        }
    }
}
