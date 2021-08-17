using System;

namespace CSharpIntermediate.Models
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Default eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Default sleeping");
        }
    }
}
