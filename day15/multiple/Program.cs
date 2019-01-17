using System;

namespace multiple
{


    class A {
        public virtual void print(){
        Console.WriteLine("Class A Implementation");
        }
    }
    class B:A {
        public override void print(){
        Console.WriteLine("Class B Implementation");
        }
    }
    class C : B {
        public override void print(){
        Console.WriteLine("Class C Implementation");
        }
    }
    class D ,B,C{

    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.print();
        }
    }
}
