using System;
using CSharpIntermediate.Casting;
using CSharpIntermediate.Models;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2020, 1, 1));
            person.Name = "Melissa";
            person.Introduce("Good Morning");
            person.SetGender("Female");
            //Console.WriteLine(person.Age);



            Console.WriteLine(person.GetGender());

            // Object Initialization - Used instead of 
            var objectInitalisedPerson = new Person(new DateTime(2000, 10, 7))
            {
                Name = "Andrew",
            };
            Console.WriteLine(objectInitalisedPerson.Name);
            Console.WriteLine(objectInitalisedPerson.Age);
            Console.WriteLine(objectInitalisedPerson.Birthdate);


            var customer = new Customer(1, "Melissa");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


            var cookie = new HttpCookie();
            cookie["name"] = "Deno";
            Console.WriteLine(cookie["name"]);

            // Inheritance
            var Animal = new Animal();
            Animal.Eat();
            Animal.Sleep();

            var Dog = new Dog();
            Dog.Eat();
            Dog.Sleep();


            // Composition
            var migrator = new Migrator(new Logger());
            var installer = new Installer(new Logger());

            migrator.Migrate();
            installer.Install();

            // Constructor Inheritance (base executed first & are not inherited)
            var car = new Car("123asdf");

            // Casting - both reference the same object but both has different views
            // Upcasting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);
        }
    }
}
