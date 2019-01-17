using System;

//an interface cannt contain a field,access modifier and implementation.it is public by difault.
//we can not create an instance of an interface but we can create
//a reference by using base class cd
namespace interfaces
{
    interface ICustomer
    {
        void print();
    }
//interfaces can inherit fromeach other
    interface I2 : ICustomer{
        void i2method(); 

    }
//classes must implement all the methods from the interface its inheriting from
    class Customer : I2{
        public void print(){
            Console.WriteLine("Hello World!");
        }
        public void i2method(){
            Console.WriteLine("Hello World!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           Customer c1 = new Customer();
           c1.print();
           c1.i2method();

        }
    }
}
