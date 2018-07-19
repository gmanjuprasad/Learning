using System;

namespace LearnProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer()
            {
                ID = 1,
                FirstName = "Manju",
                LastName = "Prasad",
            };

            
            Console.WriteLine("The Cutomer Full Name is " + cus.FullName + "");
        }
    }
}
