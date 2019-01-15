//csharp methd hiding
using System;
namespace csharpmethodhiding{
    class Employee{
        public string firstName;
        public string lastName;
        public string email ="@" ;

        //print method
        public void printFullName(){
            Console.WriteLine(firstName +" "+lastName);
        }

    }
    class fullTimeEmployee:Employee{

    }
    class partTimeEmployee:Employee{
        public new void  printFullName(){
            base.printFullName();
            //Console.WriteLine(lastName +" "+firstName + "-Contractor");
        }

    }
    class program{
        public static void Main(string [] args){
            fullTimeEmployee FTE = new fullTimeEmployee();
            FTE.lastName = "Uyo";
            FTE.firstName = "Meyo";
            FTE.printFullName();

            partTimeEmployee PTE = new partTimeEmployee();
            PTE.lastName = "Uyo";
            PTE.firstName = "kayo";
            PTE.printFullName();
            //un the unhiding the method
            ((Employee)PTE).printFullName();

        }
    }
}

