using System;

namespace exinterface
{
    interface I1
    {
        void interfacemethod();
    }
    interface I2
    {
        void interfacemethod();
    }
    class Program : I1,I2
    {
        //explicit implementation of interfaces
         void I1.interfacemethod(){
            Console.WriteLine("I1 inteface Method");
        }
         void I2.interfacemethod(){
            Console.WriteLine("I2 inteface Method");
        }

        public static void Main(string[] args)
        {
           Program P = new Program ();
           ((I1)P).interfacemethod();
            ((I2)P).interfacemethod();
            //or
            I1 il = new Program();
            I2 ol = new Program();
            il.interfacemethod();
            ol.interfacemethod();
        }

    }
}
