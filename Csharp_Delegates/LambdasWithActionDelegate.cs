using System;

namespace LambdasWithActionDelegate
{
    class Program
    {
        // Custom delegate that returns void (for learning purpose)
        delegate void OrderConfirmation(string orderDetail);

        static void Main(string[] args)
        {
            //1. Action also expects the 16 parameters do't have the any out paramter . Here we wo't expect the any return type 
            // Replaced anonymous method with lambda expression using Action delegate
            Action<string> confirmOrder = (string orderName) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            };
            confirmOrder("Pasta");

            Console.WriteLine("\n--- Using Action with Two Parameters ---");
            // Action with two input parameters
            Action<string, string> action = (string orderName, string orderDetail) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail}");
            };
            action("Pasta", "Extra Cheese");

            Console.WriteLine("\n--- Using Action with Three Parameters ---");
            // Action with three input parameters
            Action<string, string, int> action1 = (string orderName, string orderDetail, int quantity) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail} Quantity: {quantity}");
                Console.WriteLine($"Total Price: {quantity * 100}");
                Console.WriteLine("Order Confirmed");
            };
            action1("Pasta", "Extra Cheese", 2);

            Console.WriteLine("\n--- Using Action with No Parameters ---");
            Action action2 = () =>
            {
                Console.WriteLine("Order Confirmed");
                Console.WriteLine("Please Wait for the order");
            };
            action2();

            Console.ReadLine();
        }
    }
}

/*
 * Explanation:
 * 1. This program demonstrates replacing **anonymous methods** with **lambda expressions (`=>`)** for simplicity.
 * 2. The `Action` delegate is a **built-in delegate in C#** that represents a method with input parameters but no return value.
 * 3. The program shows how to use **Action delegates** with different numbers of input parameters:
 *    - `Action<string>`: Takes one string parameter (e.g., order name).
 *    - `Action<string, string>`: Takes two string parameters (e.g., order name and details).
 *    - `Action<string, string, int>`: Takes three parameters (e.g., order name, details, and quantity).
 * 4. The `Action` delegate can take **up to 16 input parameters** and is defined in the `System` namespace.
 * 5. Using lambda expressions with `Action` delegates makes the code more concise and readable compared to custom delegates.
 */
