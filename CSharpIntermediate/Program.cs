using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce(string greeting)
        {
            Console.WriteLine($"{greeting}, I am {Name} and I am {Age} year old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Name = "Melissa";
            person.Age = 23;
            person.Introduce("Good Morning");
        }
    }
}
