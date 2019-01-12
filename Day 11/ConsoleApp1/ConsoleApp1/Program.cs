using System;



class Customer{
    string _firstname;   
    string _lastname;

    //constructor doesnt have a return type
    public Customer(string firstName,string lastName)
    {
        this._firstname = firstName;
        this._lastname = lastName;
    }

    //parameterless contructors
    public Customer ()
        :this("No Firstname Paramter","No Last name Parameter"){

        }

     

    public void printDetails()
    {
        Console.WriteLine("Full Name = {0}", this._firstname + " " + this._lastname);
       
    }

    //distructor
    ~Customer()
    {

    }

    
    }

class program
{
    public static void Main()
    {
        Customer C1 = new Customer("Pargim", "Tech");
        C1.printDetails();

        //parameterless constructor;
        Customer C2 = new Customer();
        C2.printDetails();
        Console.ReadKey();
    }
}