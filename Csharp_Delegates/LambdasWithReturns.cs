using System;

namespace AnonymousMethodsWithReturns
{
    class Program
    {
        // Delegate that returns a string
        delegate string OrderPreparation(string orderDetail);

        // Delegate that returns a bool
        delegate bool CheckAvailability(string order);

        // Delegate that returns void
        delegate void OrderConfirmation(string orderDetail);

        static void Main(string[] args)
        {
            // Anonymous method for preparing an order (returns a string)
            OrderPreparation prepareOrder = delegate (string orderName) // Anonymous method for preparing orders
            {
                return $"Kitchen: Preparing {orderName}";
            };


            //OrderPreparation takeOrder = (string orderName) =>     // => Lambda expression for taking orders
            //{
            //    return $"Waiter: Taking order for {orderName}";
            //};




            // Anonymous method for checking availability using a simple loop (returns a bool)
            CheckAvailability isAvailable = delegate (string orderName)
            {
                string[] availableItems = { "Pasta", "Pizza", "Salad" };

                // Loop through the available items
                for (int i = 0; i < availableItems.Length; i++)
                {
                    if (availableItems[i].Equals(orderName))
                    {
                        return true;  // Order is available
                    }
                }
                return false;  // Order not available
            };

            //CheckAvailability isAvailable =  (string orderName) =>
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


            // Anonymous method for confirming the order (returns void)
            OrderConfirmation confirmOrder = delegate (string orderName) // Anonymous method for confirming orders
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            };


            //OrderConfirmation confirmOrder =  (string orderName) => // Anonymous method for confirming orders
            //{
            //    Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            //};



            // Example order
            string order = "Pasta";

            Console.WriteLine("Checking order availability...");
            if (isAvailable(order))
            {
                // Prepare the order and print the message
                Console.WriteLine(prepareOrder(order));

                // Confirm the order
                confirmOrder(order);
            }
            else
            {
                Console.WriteLine($"Sorry, {order} is not available.");
            }

            Console.WriteLine("\nCustomer places order for Sushi...");
            order = "Sushi";

            if (isAvailable(order))
            {
                Console.WriteLine(prepareOrder(order));
                confirmOrder(order);
            }
            else
            {
                Console.WriteLine($"Sorry, {order} is not available.");
            }

            Console.ReadLine();
        }
    }
}
