using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class DisplayBooks
    {
        public static void ShowBooks(Library library)
        {
            Console.WriteLine();
            Console.WriteLine("Books in the library:");

            foreach (var book in library.GetBooks())
            {
                
                Console.WriteLine($"{book.BookID} {book.Title} by {book.Author}");

            }

            Console.WriteLine();



        }


    }
}
