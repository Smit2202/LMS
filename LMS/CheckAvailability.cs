using System;

namespace LibraryManagementSystem
{
    public class CheckAvailability
    {
        // Function to check the availability of a book in the library
        public static void CheckBookAvailability(Library library, string title)
        {
            var books = library.GetBooks();
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine($"Book '{title}' is {(book.Availability ? "available" : "not available")} in the library.");
                    return;
                }
            }
            Console.WriteLine($"Book '{title}' is not found in the library.");
        }
    }
}
