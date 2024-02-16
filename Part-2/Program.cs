using System;
namespace Program
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            var john=new Person();
            john.FirstName="John";
            john.LastName="Smith";
            john.Introduce();
        }
    }
}
