//csharp methd hiding
using System;
namespace csharpmethodhiding{
    class Employee{
        public string firstName;
        public string lastName;
        public string email;

        //print method
        public void printFullName(){
            Console.WriteLine(firstName +" "+lastName);
        }

    }
    class fullTimeEmployee:Employee{

    }
    class partTimeEmployee:Employee{

    }
    class program{
        public static void Main(string [] args){
            fullTimeEmployee FTE = new fullTimeEmployee();
            FTE.lastName = "Uyo";
            FTE.lastName = "Meyo";
            FTE.printFullName();

            partTimeEmployee FTE = new partTimeEmployee();
            PTE.lastName = "Uyo";
            PTE.lastName = "Meyo";
            PTE.printFullName();

        }
    }
}

