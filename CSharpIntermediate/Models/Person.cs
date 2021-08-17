using System;
namespace CSharpIntermediate.Models
{
    public class Person
    {
        // When you have auto-implemented properties such as get & set CSharp automatically sees this as a private field
        // I have set the 'setter' to private because we have a method to work that out so it should never be changed by us
        public DateTime Birthdate { get; private set; }
        public string Name;
        private string _gender; 

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }


        public void Introduce(string greeting)
        {
            Console.WriteLine($"{greeting}, I am called {Name} and I am {Age} years old.");
        }


        // Encapsulation
        // This method hides the method in which we use the date given
        public void SetGender(string gender)
        {
            _gender = gender;
        }
        // This method display the end result only - only part we show to the user
        public string GetGender()
        {
            return _gender;
        }
    }
}
