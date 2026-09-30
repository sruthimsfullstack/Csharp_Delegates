using System;
using System.IO;
using System.Threading;

namespace NM_RestaurantDelegate
{
    delegate void KitchenSection(string order);  // Delegate representing the kitchen sections

    public class Restaurant
    {

        // Methods that will be assigned to the delegate
        public void MainCourseSection(string order)
        {
            Console.WriteLine($"Main Course  is preparing: {order}"); // Main course section
        }

        // Methods that will be assigned to the delegate
        public void DessertSection(string order)
        {
            Console.WriteLine($"Dessert is preparing: {order}"); // Dessert section
        }

        // Methods that will be assigned to the delegate
        public void DrinksSection(string order)
        {
            Console.WriteLine($"Drinks Section is preparing: {order}");// Drinks section
        }
    }

    class Restarent
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant();  // Create restaurant object
            //restaurant.MainCourseSection("Pasta");
            //restaurant.DessertSection("Ice Cream");
            //restaurant.DrinksSection("Mojitos");

            // "Waiter" acts as the delegate that routes orders
            KitchenSection waiter; // Create delegate object not assigned to any method

            Console.WriteLine("Customer places order for Pasta...");
            waiter = restaurant.MainCourseSection;  // Route to main course section
            waiter("Pasta"); // Call the delegate .
                             // Here the delegate calls the MainCourseSection method and passes the order as parameter
                             // The MainCourseSection method is then executed
                             // Here waiter is a delegate that points to the MainCourseSection method


            Console.WriteLine("\nCustomer places order for Ice Cream...");
            waiter = restaurant.DessertSection;  // Route to dessert section
            waiter("Ice Cream");// Call the delegate
                                // Here the delegate calls the DessertSection method and passes the order as parameter
                                // The DessertSection method is then executed
                                // Here waiter is a delegate that points to the DessertSection method

            Console.WriteLine("\nCustomer places order for a Mojito...");
            waiter = restaurant.DrinksSection;  // Route to drinks section
            waiter("Mojito");// Call the delegate
                             // Here the delegate calls the DrinksSection method and passes the order as parameter
                             // The DrinksSection method is then executed
                             // Here waiter is a delegate that points to the DrinksSection method
        }
    }
}


//Output
//Customer places order for Pasta...
//Main Course Chef is preparing: Pasta

//Customer places order for Ice Cream...
//Dessert Chef is preparing: Ice Cream

//Customer places order for a Mojito...
//Drinks Section is preparing: Mojito



/* Explanation about Delegate:
 *  1. The delegate is a type-safe function pointer that can reference a method.
 *  2. The delegate can be used to call the method it points to.
 */


/* How the Waiter Works in the Code:
   ---------------------------------
The variable waiter is the key to the dynamic behavior.
It acts as the “middleman” connecting the customer’s order to the right kitchen section.
Whenever the order changes (waiter = restaurant.MainCourseSection), the delegate reroutes the request to a new method dynamically.
*/
