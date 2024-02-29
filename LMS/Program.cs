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
            Availability = v;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }
        public bool Availability { get; internal set; }
    }

    public class ULMS
    {  
        public ULMS(string name, string bookname)
        {
            BookID = bookname;
            Uname = name;
            
        }

        public string Uname { get; set; }
        public string BookID { get; set; }
        public bool Availability { get; internal set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool Task = false;

            Library library = new Library();

            while (!Task)
            {
                Console.WriteLine($"{Environment.NewLine}Adding the books = A, {Environment.NewLine}Displaying the books = B, {Environment.NewLine}Search book by title = C, {Environment.NewLine}Search book by id = D, {Environment.NewLine}Checking the availability of a book = E, {Environment.NewLine}Exit = F {Environment.NewLine}BookIssue From the Library = G {Environment.NewLine}");


                char Uinput = '\0';
                bool isWantValid = false;

                List<char> nameList = new List<char> {'a','b','c','d','e','f','g','h','A','B','C','D','E','F','G'};

                while (!isWantValid)
                {
                    Console.Write("Enter What you Want to do : ");
                    try
                    {
                        Uinput = Convert.ToChar(Console.ReadLine());
                        if (!nameList.Contains(Uinput)) throw new Exception();
                        isWantValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid value." );
                    }
                }

                BookIssue bookIssue = new BookIssue();

                switch (Char.ToLower(Uinput))
                {
                    case 'a':                        
                        int numBooks = 0;
                        bool isNumValid = false;
                        while (!isNumValid)
                        {
                            Console.Write("Enter the number of books you want to add:  ");
                            try
                            {
                                numBooks = Int32.Parse(Console.ReadLine());
                                if (numBooks == 0) throw new Exception();
                                isNumValid = true;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid entry. Please enter a valid value.");
                            }
                        }

                        for (int i = 0; i < numBooks; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Enter details for Book {i + 1}:");
                            Console.Write("Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Author: ");
                            string author = Console.ReadLine();
                            int bookid = 0;
                            bool isBookIdValid = false;
                            while (!isBookIdValid)
                            {
                                Console.Write("BookID: ");
                                try
                                {
                                    bookid = Int32.Parse(Console.ReadLine());
                                    if (bookid == 0) throw new Exception();
                                    isBookIdValid = true;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid entry. Please enter a valid value.");
                                }
                            }

                            library.AddBook(title, author, bookid);
                        }
                        break;
                    case 'b':
                        DisplayBooks.ShowBooks(library);
                        break;
                    case 'c':
                        Console.Write("Enter the title of the book you want to search: ");
                        string searchTitle = Console.ReadLine();
                        SearchBook.SearchByTitle(library, searchTitle);
                        break;
                    case 'd':
                        Console.WriteLine();                        
                        int searchId = 0;
                        bool issBookIdValid = false;
                        while (!issBookIdValid)
                        {
                            Console.Write("Enter the id of the book you want to search: ");
                            try
                            {
                                searchId = Int32.Parse(Console.ReadLine());
                                if (searchId == 0) throw new Exception();
                                issBookIdValid = true;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid entry. Please enter a valid value.");
                            }
                        }                        
                        break;
                    case 'e':
                        Console.WriteLine();
                        Console.WriteLine("Enter the title of the book you want to check availability for:");
                        string checkAvailabilityTitle = Console.ReadLine();
                        CheckAvailability.CheckBookAvailability(library, checkAvailabilityTitle);
                        break;
                    case 'g':


                        // BookIssue From the Library                        
                        int numPerson = 0;
                        bool isnumValid = false;
                        while (!isnumValid)
                        {
                            Console.Write("Enter the number of person detail you want to add: ");
                            try
                            {
                                numPerson = Int32.Parse(Console.ReadLine());
                                if (numPerson == 0) throw new Exception();
                                isnumValid = true;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid entry. Please enter a valid value.");
                            }
                        }


                        for (int i = 0; i < numPerson; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Enter details of person {i + 1}:");
                            Console.Write("Enter the name of thr person who want to issue the book :");
                            string uname = Console.ReadLine();
                            Console.Write("Enter the name of the book: ");
                            string NAME = Console.ReadLine();

                            bool bookAvailable = CheckAvailability.CheckBookAvailability(library, NAME);
                            if (bookAvailable)
                            {
                                bookIssue.AddUname(uname, NAME);
                            }
                            else
                            {
                                Console.WriteLine("Book is not available");
                            }
                        }

                        // Displaying the books
                        DisplayUser.ShowUser(bookIssue);

                        
                        break;
                    case 'f':
                        Task = true;
                        break;
                }
            } 
        }
    }
}
