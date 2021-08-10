using System;
namespace CSharpIntermediate.Models
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
}
