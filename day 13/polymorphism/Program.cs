using System;
namespace  employeeprogram
{
   public class Employee{
    public string firstname = "FN";
    public string lastname = "LN";

    public virtual void printFullname (){
        Console.WriteLine(firstname +" "+lastname);
    }
}
public class partTimeEmployee:Employee{
    public override void printFullname(){
        Console.WriteLine(firstname +" "+lastname + "-PartTime Employee");
    }

}
public class fullTimeEmployee:Employee{
     public override void printFullname(){
        Console.WriteLine(firstname +" "+lastname + "-FullTime Employee");
    } 
}
public class temporaryEmployee:Employee{
     public override void printFullname(){
        Console.WriteLine(firstname +" "+lastname + "-TemporaryTime Employee");
    }

}

public class program {
    public static void  Main(string [] args){
        Employee [] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new  partTimeEmployee();
        employee[2] = new fullTimeEmployee();
        employee[3] = new temporaryEmployee();

        foreach (Employee e in employee){
            e.printFullname();

        }
       

    }
}
}
