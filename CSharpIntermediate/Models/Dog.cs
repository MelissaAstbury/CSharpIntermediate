using System;
namespace CSharpIntermediate.Models
{
    public class Dog : Animal
    {
       public override void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
