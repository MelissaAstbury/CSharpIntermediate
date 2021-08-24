using System;

namespace CSharpIntermediate.Models
{
    public class Vehicle
    {
        private readonly string _regNum;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialsied");
        //}

        public Vehicle(string regNum)
        {
            _regNum = regNum;
            Console.WriteLine($"Vehicle is being initialsied with registration number of: {regNum}");
        }
    }
}
