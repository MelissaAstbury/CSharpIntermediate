using System;
using CSharpIntermediate.Models;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Melissa";
            person.Age = 23;
            person.Introduce("Good Morning");

            // Object Initialization - Used instead of 
            var objectInitalisedPerson = new Person()
            {
                Name = "Andrew",
                Age = 26,
            };
            Console.WriteLine(objectInitalisedPerson.Name);
            Console.WriteLine(objectInitalisedPerson.Age);


            var customer = new Customer(1, "Melissa");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
