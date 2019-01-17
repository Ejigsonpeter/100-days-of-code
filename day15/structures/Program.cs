using System;

namespace structures
{

    public struct Custommer{
        private int _id;
        private string _name;
    public int id{
        get{return this._id;}
        set{this._id = value; }
        
    }
    public string Name{
        get{return this._name; }
        set{this._name = value;}
    }
    public Custommer(int Id,string Name){
        this._id = Id;
        this._name = Name;
    }
    public void print(){
        Console.WriteLine("Id = {0} && Name = {1}",this._id, this._name);
    }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Custommer c1 =  new Custommer(101,"peter");
            c1.print();
            Custommer c2 = new Custommer();
            c2.id= 201;
            c2.Name = "ejigson";
            c2.print();

            //using object initilizer syntax... it used to initiazea an object or a class/
            Custommer c3 = new Custommer{
                id = 3,
                Name = "peter ejigosn"
            };
            c3.print();
        }
    }
}
