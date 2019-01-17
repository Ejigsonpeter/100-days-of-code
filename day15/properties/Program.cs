using System;

namespace properties
{

    public class  student{
        private int _id;
        private string _name;
        private int _passmark = 35;

        public int  getPassmark(){
            return this._passmark;

        }

        
        public void setID (int id){
            if (id <= 0){
                throw new Exception("Student id cannot be negative");
            }
             this._id = id;
        }
        public int GetId(){
            return this._id;
        }

         public void setName(string Name){
        if(string.IsNullOrEmpty(Name)){
            throw new Exception("Name space canot be Empty");
        }
        this._name = Name;
    }
    public string getName(){
        return  string.IsNullOrEmpty(this._name) ? "No Name provided" : this._name;
    }

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            student c1 = new student();
            c1.setID(11);
            Console.WriteLine("StudentID = {0}",c1.GetId());
            c1.setName("ijeoma");
            
            Console.WriteLine("Name = {0}",c1.getName());
            Console.WriteLine("pass mark = {0}",c1.getPassmark());
        }
    }
}
