using System;
//abstract class has no implementation. it is an incomplete class.
//abstract class cannot be instantiated,they can only be used as base class for other classes
namespace abstractclasses
{
public abstract class Customer{
    public abstract void print();
}
   public class Program : Customer
    {
        public override void print(){
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
           Program p = new Program();
           p.print();
        }
    }c
}
