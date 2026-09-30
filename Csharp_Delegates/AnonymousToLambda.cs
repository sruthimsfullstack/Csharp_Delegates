using System;

namespace AnonymousToLambda
{
    // Define a delegate for restaurant tasks
    delegate void RestaurantTask(string taskDetail);
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous method for taking orders
            //RestaurantTask takeOrder = delegate (string orderName)
            //{
            //    Console.WriteLine("Waiter: Taking order for " + orderName);
            //};

            RestaurantTask takeOrder = (string orderName) =>       // => Lambda expression for taking orders
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };



            // Anonymous method for preparing food
            //RestaurantTask prepareFood = delegate (string orderName)
            //{
            //    Console.WriteLine("Kitchen: Preparing " + orderName);
            //};

            RestaurantTask prepareFood = (string orderName) =>    // => Lambda expression for preparing food
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };

            // Anonymous method for serving food
            //RestaurantTask serveFood = delegate (string orderName)
            //{
            //    Console.WriteLine("Waiter: Serving " + orderName);
            //};

            RestaurantTask serveFood = (string orderName) =>  // => Lambda expression for serving food
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };

            // Example order
            string order = "Pasta";

            // Perform restaurant tasks
            takeOrder(order);
            prepareFood(order);
            serveFood(order);

            Console.ReadLine();
        }
    }
}


/*
 * Explanation:
 * ----------------
 * 1. This program demonstrates replacing **anonymous methods** with **lambda expressions (`=>`)** for simplicity.
 * 2. The **`RestaurantTask` delegate** is used to perform tasks like taking orders, preparing food, and serving food.
 * 3. Each task is defined using a **lambda expression**, making the code concise and easier to read.
 * 4. The program simulates a restaurant workflow: the waiter takes the order, the kitchen prepares it, and the waiter serves it.
 * 5. The **lambda operator (`=>`)** separates the parameters from the task logic, providing a more streamlined syntax.
 */
