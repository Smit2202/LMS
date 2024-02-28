using System;
using System.Linq;

namespace LibraryManagementSystem
{
    public class SearchBook
    {
        // Function to search for a book by title in the library
        public static void SearchByTitle(Library library, string title)
        {
            var foundBooks = library.GetBooks().Where(book => book.Title.ToLower().Contains(title.ToLower())).ToList();
            if (foundBooks.Count > 0)
            {
                Console.WriteLine($"Books found with title '{title}':");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine($"No books found with title '{title}'.");
            }


        }

        public static void SearchByID(Library library, int id)
        {
            
            foreach (var book in library.GetBooks())
            {
                
                if (book.BookID == id)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{book.BookID} {book.Title} by {book.Author}");
                }
            }
        }
    }
}
