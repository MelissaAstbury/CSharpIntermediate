using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    // THIS WAY OF USING CONSTRUCTORS IS NOT USED - I HAVE DONE THIS TO UNDERSTAND THE CONSEPT ONLY!
    // CONSTRUCTORS SHOULD ONLY BE USED WHEN NECCESSARY AS THIS CAN GET COMPLICATED
    public class Customer
    {
        public int Id;
        public string Name;
        // Use readonly so initialisation is once. You can not change the data
        public readonly List<Order> Orders;

        // We can remove the empty constructor with the following field instead:
        // public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            // This line initialises the empty list.
            // If this was not here then the system would crash as it would be a null reference
            Orders = new List<Order>();
        }

        public Customer(int id)
            // Using the 'this' key word means that I do not have to initalise the List in each constructor
            // The code will read the parameterless constructor and then the one it should read
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            // The 'this' keyword can also be used to direct which constructor you want to use
            // In this example I have defined the one with the id but the id will also go back to the original once again so it's a chain
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
