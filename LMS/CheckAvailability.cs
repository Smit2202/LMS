using System;

namespace LibraryManagementSystem
{
    public class CheckAvailability
    {
        // Function to check the availability of a book in the library
        public static bool CheckBookAvailability(Library library, string title)
        {
            
            var books = library.GetBooks();
            foreach (var book in books)
            {
                if (book.Title == title)
                {

                    //if (book.Availability)
                    //{
                    //    Console.WriteLine($"Book '{title}' is available");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"Book '{title}' is not available");
                    //}
                    return true;
                }
            }
            Console.WriteLine($"Book '{title}' is not found in the library.");
            return false;
        }
    }
}
