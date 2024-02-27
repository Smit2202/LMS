using System;

namespace LibraryManagementSystem
{
    public class LMS
    {
        private bool v;

        public LMS(string title, string author, bool v)
        {
            Title = title;
            Author = author;
            this.v = v;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public bool Availability { get; internal set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            Console.WriteLine("Enter the number of books you want to add:");
            int numBooks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();

                library.AddBook(title, author);
            }

            // Displaying the books
            DisplayBooks.ShowBooks(library);



            // search book by title
            Console.WriteLine("Enter the title of the book you want to search:");
            string searchTitle = Console.ReadLine();
            SearchBook.SearchByTitle(library, searchTitle);

            // checking the availability of a book
            Console.WriteLine("Enter the title of the book you want to check availability for:");
            string checkAvailabilityTitle = Console.ReadLine();
            CheckAvailability.CheckBookAvailability(library, checkAvailabilityTitle);
        }
    }
}
