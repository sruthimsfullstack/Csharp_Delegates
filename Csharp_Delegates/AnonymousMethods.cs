using System;

namespace AnonymousMethods
{

    // Define a delegate for restaurant tasks
    delegate void RestaurantTask(string taskDetail);

    delegate string OrderConfirmationMessage(string input);
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous method for taking orders
            RestaurantTask takeOrder = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };
            string order = "Pasta";
            // Perform restaurant task
            takeOrder(order);

            // Anonymous method for preparing food
            RestaurantTask prepareFood = delegate (string orderName)
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };
            // Perform restaurant task
            prepareFood(order);

            // Anonymous method for serving food
            RestaurantTask serveFood = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };
            // Perform restaurant task
            serveFood(order);


            OrderConfirmationMessage orderConfirmationMessageDelegage = delegate (string orderName)
            {
                return "You ordered the " + orderName;
            };
            string status = orderConfirmationMessageDelegage("Pasta");
            Console.WriteLine(status);


            Console.ReadLine();
        }
    }
}


/*
 *  Explanation:
 *  
// This code demonstrates the use of anonymous methods in C#.
// An anonymous method is a method without a name, defined using the 'delegate' keyword.
// Here, we define a delegate named 'RestaurantTask' that takes a string parameter and returns void.

// Inside the Main method, we create three anonymous methods assigned to the 'RestaurantTask' delegate:
// 1. 'takeOrder' - simulates taking an order by printing a message to the console.
// 2. 'prepareFood' - simulates preparing food by printing a message to the console.
// 3. 'serveFood' - simulates serving food by printing a message to the console.

// We then define a string variable 'order' with the value "Pasta" to represent an example order.

// Finally, we call each of the anonymous methods in sequence, passing the 'order' variable as an argument.
// This simulates the process of taking an order, preparing the food, and serving it.

// The Console.ReadLine() at the end keeps the console window open until the user presses Enter.
 * 
 * 
 * 
 * 
 * 
 */
