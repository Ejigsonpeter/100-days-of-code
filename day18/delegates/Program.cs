using System;
// a delegate is a function pointer
namespace delegates
{
    class Employee {
        public int ID{set;get;}
        public string Name{set;get;}
        public int Salary {set;get;}
        public int Expirience{set;get;}

        public void PromoteEmployees(list <Employee> EmployeeList,isPromotable Iseligible){
            for each(Employee employee in EmployeeList ){
                if (employee.Expirience >= 5){
                        Console.WriteLine(employee.Name +" Promoted");
                }
            }
        }
    }

    public delegate void hellofunction(string Message);
    public delegate bool isPromotable(Employee empl);
    class Program
    {
        public static void Main(string[] args)
        {
            hellofunction del  = new hellofunction(hello);
            del("hello");
            List <employee> emplist = new List<employee>();
            emplist.Add(new Employee{ID = 101, Name = "EJIGA PETER",Expirience = 5, Salary = 5000});
            emplist.Add(new Employee{ID = 102, Name = "EJIGA PEACE",Expirience = 4, Salary = 4000});
            emplist.Add(new Employee{ID = 103, Name = "EJIGA TIMOTHY",Expirience = 3, Salary = 3000});
            emplist.Add(new Employee{ID = 104, Name = "EJIGA VICTOR",Expirience = 2, Salary = 2000});
            emplist.Add(new Employee{ID = 105, Name = "EJIGA FRED",Expirience = 1, Salary = 1000});
            //using inline lambda expression
            Employee.PromoteEmployees(emplist,emp => 5);

        }
        

        public static void hello(string strmessage){
            Console.WriteLine(strmessage);
        }
    }
}
