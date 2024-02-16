using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        //Type conversion
        int i = 1;
        byte a = (byte)i;
        Console.WriteLine(a);

        //Other way
        try
        {
            var number = "1234";
            byte b = Convert.ToByte(number);
            //Convert.ToBoolean
            Console.WriteLine(b);
        }
        catch (Exception)
        {
            Console.WriteLine("The Numner could not be Converted to a byte.");
        }
    }
}
