using System;
namespace csharpinheritance {
    class Employee{
        public string firstname;
        public string lastname;
        public string email;
    public void printfullname(){
        Console.WriteLine(firstname + "  " + lastname);
    }
    }
    class fullTimeEmployee : Employee{
        public float yearlyIncome = 0;
    }
    class partTimeEmployee : Employee {
        public float hourlyIncome = 0;
    }
    class program{
        public static void Main(string [] args){
            fullTimeEmployee FTE = new fullTimeEmployee();
            FTE.firstname = "Peter";
            FTE.lastname = "Ejigson";
            FTE.email = "ejigsonpeter@gmail.com";
            FTE.yearlyIncome = 1000000;
            FTE.printfullname();

            partTimeEmployee PTE = new partTimeEmployee();
            PTE.firstname = "Ugo";
            PTE.lastname = "Endy";
            PTE.email = "ugoendy@gmail.com";
            PTE.hourlyIncome = 50000;
            PTE.printfullname();

            partTimeEmployee TP = new partTimeEmployee();
            TP.firstname = "PRISCA";
            TP.lastname = "PRISCA";
            TP.email = "prisca@gmail.com";
            TP.printfullname();
        }
    }


}
