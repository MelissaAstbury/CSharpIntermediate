using System;

namespace CSharpIntermediate.Models
{
    public class Car : Vehicle
    {
        public Car(string regNum)
            : base(regNum)
        {
            Console.WriteLine($"Car is being initialsied with registration number of: {regNum}");
        }
    }
}
