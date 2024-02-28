using System;

namespace LibraryManagementSystem
{
    public class LMS
    {
        private bool v;

        public LMS(string title, string author, int bookid, bool v)
        {
            Title = title;
            Author = author;
            BookID = bookid;
            this.v = v;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }
        public bool Availability { get; internal set; }
    }

    public class ULMS
    {  
        public ULMS(string name)
        {
            BookID = bookid;
            Uname = name;
        }

        public string Uname { get; set; }
        public int BookID { get; set; }
        public bool Availability { get; internal set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            Console.Write("Enter the number of books you want to add: ");
            int numBooks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("BookID: ");
                int bookid = int.Parse(Console.ReadLine());

                library.AddBook(title, author, bookid);
            }

            // Displaying the books
            DisplayBooks.ShowBooks(library);



            //// search book by title
            //Console.Write("Enter the title of the book you want to search: ");
            //string searchTitle = Console.ReadLine();
            //SearchBook.SearchByTitle(library, searchTitle);

            //// search book by id
            //Console.WriteLine();
            //Console.Write("Enter the id of the book you want to search:r");
            //int searchId = int.Parse(Console.ReadLine());
            //SearchBook.SearchByID(library, searchId);

            //// checking the availability of a book
            //Console.WriteLine();
            //Console.WriteLine("Enter the title of the book you want to check availability for:");
            //string checkAvailabilityTitle = Console.ReadLine();
            //CheckAvailability.CheckBookAvailability(library, checkAvailabilityTitle);

            BookIssue bookIssue = new BookIssue();

            // BookIssue From the Library
            Console.Write("Enter the number of person detail you want to add: ");
            int numPerson = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numPerson; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter details of person {i + 1}:");
                Console.Write("Enter the name of thr person who want to issue the book :");
                string uname = Console.ReadLine();
                Console.Write("Enter the id of the book: ");
                int issueBookId = int.Parse(Console.ReadLine());

                bookIssue.AddUname(uname);
            }

            // Displaying the books
            DisplayUser.ShowUser(bookIssue);



            Console.ReadLine();
        }
    }
}
