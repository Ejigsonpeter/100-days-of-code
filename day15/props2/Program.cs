using System;

namespace properties
{

    public class  student{
        private int _id;
        private string _name;
        private int _passmark = 35;

//by using the get accessor a value becomes readonly
        public int  getPassmark{
            get{
            return this._passmark;
            }

        }


        //compiler can help us generate auto implemented properties
        public string city{
            get;
            set;
        }
        public string  email{
            get;
            set;
        }

        //by using the  get and set accessor . a value bcomes read and write
        public int Id {
            set{
            if (value <= 0){
                throw new Exception("Student id cannot be negative");
            }
             this._id = value;
       
        }
        get{
            return this._id;

        }
        }
     

    public string  Names{

        set{
        if(string.IsNullOrEmpty(value)){
            throw new Exception("Name space canot be Empty");
        }
        this._name = value;
    }
    get{
    
        return  string.IsNullOrEmpty(this._name) ? "No Name provided" : this._name;
    }

    }
    }

    

   
    class Program
    {
        static void Main(string[] args)
        {
            student c1 = new student();
            c1.Id = 101;
            c1.email = "ejigsonpeter@gmail.com";
            c1.city = "Rio De Jainero";
            Console.WriteLine("StudentID = {0}",c1.Id);
            c1.Names = "Ijecoma";
            
            Console.WriteLine("Name = {0}",c1.Names);
            Console.WriteLine("pass mark = {0}",c1.getPassmark);
            Console.WriteLine("City = {0}",c1.city);
            Console.WriteLine("Email = {0}",c1.email);
        }
    }
}
