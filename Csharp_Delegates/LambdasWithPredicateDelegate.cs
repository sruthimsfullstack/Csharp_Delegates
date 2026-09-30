using System;

namespace LambdasWithPredicateDelegate
{
    class Program
    {
        // Delegate that returns a bool
        delegate bool CheckAvailability(string order);

        static void Main(string[] args)
        {

            // Anonymous method for checking availability using a simple loop (returns a bool)
            //CheckAvailability isAvailable = delegate (string orderName)
            //{
            //    string[] availableItems = { "Pasta", "Pizza", "Salad" };

            //    // Loop through the available items
            //    for (int i = 0; i < availableItems.Length; i++)
            //    {
            //        if (availableItems[i].Equals(orderName))
            //        {
            //            return true;  // Order is available
            //        }
            //    }
            //    return false;  // Order not available
            //};


            // Using Predicate delegate to check availability of an order
            Predicate<string> isAvailablePredicate = (string orderName) =>
            {
                string[] availableItems = { "Pasta", "Pizza", "Salad" };

                // Loop through available items
                for (int i = 0; i < availableItems.Length; i++)
                {
                    if (availableItems[i].Equals(orderName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;  // Order is available
                    }
                }
                return false;  // Order not available
            };

            // Check if the order is available
            bool isAvailable = isAvailablePredicate("Pasta");
            Console.WriteLine("Is Pasta available? " + isAvailable);

            Console.WriteLine("\n--- Checking Staff Availability ---");

            // Using Predicate delegate to check the availability of staff
            Predicate<string> isStaffAvailablePredicate = (string staffName) =>
            {
                string[] availableStaff = { "John", "Doe", "Smith" };

                //availableStaff.Join()

                // <databaserecords>.Where((x) => x == "John");

                // Loop through available staff members
                for (int i = 0; i < availableStaff.Length; i++)
                {
                    if (availableStaff[i].Equals(staffName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;  // Staff is available
                    }
                }
                return false;  // Staff not available
            };

            // Check if a specific staff member is available
            bool isStaffAvailable = isStaffAvailablePredicate("Doe");
            Console.WriteLine("Is Doe available? " + isStaffAvailable);

            Console.ReadLine();
        }
    }
}

/*
 * Explanation:
 * ------------
 * 1. This program demonstrates replacing **anonymous methods** with **lambda expressions (`=>`)** using the built-in `Predicate` delegate.
 * 2. The `Predicate` delegate takes a single input parameter and returns a boolean value, often used to apply conditions or filters.
 * 3. The program defines two `Predicate` delegates:
 *    - `isAvailablePredicate`: Checks if the requested order is available.
 *    - `isStaffAvailablePredicate`: Checks if a specific staff member is available.
 * 4. The `Predicate` delegate is a **generic delegate**, meaning it can work with any data type.
 * 5. This program highlights how `Predicate` delegates provide a concise and flexible way to evaluate conditions.
 */
