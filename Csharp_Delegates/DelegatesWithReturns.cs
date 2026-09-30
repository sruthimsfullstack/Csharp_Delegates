using System;

namespace DelegatesWithReturns
{

    // Delegate that returns a string (for order preparation messages)
    public delegate string OrderPreparation(string order);

    // Delegate that returns void (for order confirmation)
    public delegate void OrderConfirmation(string order);

    // Delegate that returns bool (to check availability)
    public delegate bool OrderAvailability(string order);

    public class Restaurant
    {
        // Returns preparation message as a string
        public string PrepareMainCourse(string order)
        {
            return $"Main Course Chef is preparing: {order}";
        }

        // Confirms the order (void delegate)
        public void ConfirmOrder(string order)
        {
            Console.WriteLine($"Order confirmed: {order}");
        }

        // Checks if the order is available using a foreach loop
        public bool CheckOrderAvailability(string order)
        {
            string[] availableItems = { "Pasta", "Ice Cream", "Mojito" };

            // Iterate through each item in the availableItems array
            foreach (string item in availableItems)
            {
                // Compare the current item with the requested order (ignoring case)
                if (item.Equals(order))
                {
                    return true;  // If a match is found, return true (item is available)
                }
            }
            return false;  // If no match is found, return false (item is not available)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();  // Create a Restaurant object

            // Create delegates for different tasks
            OrderPreparation preparationDelegate = restaurant.PrepareMainCourse;  // Delegate to prepare orders
            OrderConfirmation confirmationDelegate = restaurant.ConfirmOrder;  // Delegate to confirm orders
            OrderAvailability availabilityDelegate = restaurant.CheckOrderAvailability;  // Delegate to check availability

            // Customer places an order for "Pasta"
            string order = "Pasta";

            Console.WriteLine("Checking order availability...");
            // Check if the order is available
            if (availabilityDelegate(order))
            {
                // Get and print the preparation message
                Console.WriteLine(preparationDelegate(order));

                // Confirm the order
                confirmationDelegate(order);
            }
            else
            {
                Console.WriteLine($"Sorry, {order} is not available.");
            }

            Console.WriteLine("\nCustomer places an order for Sushi...");

            order = "Sushi";

            // Check if Sushi is available
            if (availabilityDelegate(order))
            {
                // Get and print the preparation message
                Console.WriteLine(preparationDelegate(order));

                // Confirm the order
                confirmationDelegate(order);
            }
            else
            {
                Console.WriteLine($"Sorry, {order} is not available.");
            }
        }
    }
}



/********************************* End of File ***********************************/

/*
 * Explanation about the code
   --------------------------

    1.At each delegate definition: Explained what the delegate does (string, void, bool return types).
    2.Inside the CheckOrderAvailability method: Explained the logic for checking the order using the foreach loop.
    3.Main program flow: Step-by-step comments explaining the logic, from checking availability to 
    preparing and confirming the order.

 */
