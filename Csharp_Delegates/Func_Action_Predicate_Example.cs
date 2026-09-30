using System;

namespace Func_Action_Predicate_LibraryExample
{
    /*
     * Scenario:
            Func: To calculate and return the total fine for late returns.
            Action: To display book issue confirmation.
            Predicate: To check if a book is available in the library.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Func delegate to calculate late return fine
            Func<int, decimal, decimal> calculateFine = (int daysLate, decimal finePerDay) => {
                return Convert.ToDecimal(daysLate * finePerDay);
            };

            //Func<string, string> takeOrder = (string orderName) =>
            //{
            //    return $"Kitchen: Preparing {orderName}";
            //};

            // Action delegate to confirm the book issue
            Action<string, string> issueBook = (string bookTitle, string borrowerName) =>
            {
                Console.WriteLine($"Book '{bookTitle}' has been issued to {borrowerName}.");
            };

            // Predicate delegate to check if a book is available
            Predicate<string> isBookAvailable = (string bookTitle) =>
            {
                string[] availableBooks = { "C# in Depth", "Clean Code", "The Pragmatic Programmer" };

                for (int i = 0; i < availableBooks.Length; i++)
                {
                    if (availableBooks[i].Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            };

            // Example usage
            string bookTitle = "C# in Depth";
            string borrowerName = "John";
            int daysLate = 5;
            decimal finePerDay = 10.00m;

            // Check if the book is available
            if (isBookAvailable(bookTitle))
            {
                // Confirm the book issue using Action delegate
                issueBook(bookTitle, borrowerName);

                // Calculate the total fine using Func delegate
                decimal totalFine = calculateFine(daysLate, finePerDay);
                Console.WriteLine($"Late Return Fine for {daysLate} days: {totalFine:C}");
            }
            else
            {
                Console.WriteLine($"Sorry, the book '{bookTitle}' is not available.");
            }

            Console.ReadLine();
        }
    }
}

