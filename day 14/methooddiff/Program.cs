using System;
namespace vs{
    class baseClass{
        public virtual void print(){
            Console.WriteLine("I am a Base Class");
        }

    }
    class derrivedClass : baseClass{
        public override void print(){
            Console.WriteLine("I am a derrived class");
        }

    }
    class program{
        public static void Main(string [] args){
            baseClass B = new derrivedClass();
            B.print();

        }
    }
}
