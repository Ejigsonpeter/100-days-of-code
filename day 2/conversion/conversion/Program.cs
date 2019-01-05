using System;

   class Program
    {
        static void Main(string[] args)
        {

        //the datatype conversion . 

        //implicit conversion example
        int x = 200;
        float f = x;
        Console.WriteLine(f);
        //explicit conversion
        //by casting
        float y = 12222.789F;
        int c;
        c = (int)y;
        //by using the convert class
        int z = Convert.ToInt32(y);
        Console.WriteLine(y);
        //string conversion by parsing
        string num = "9929292TG";
        int h = int.Parse(num);
        int result = 0;
        // to avoid exception we uses a trpass method

        bool IsConversionokay = int.TryParse(num, out result);

        if (IsConversionokay)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("String is not a Valid Integer");
        }
            Console.ReadKey();

            
    }
}
