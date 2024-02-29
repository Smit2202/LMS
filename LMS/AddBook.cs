using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<LMS> library;

        public Library()
        {
            library = new List<LMS>();

            library.Add(new LMS("Title_1", "Author_1", 101, true));
            library.Add(new LMS("Title_2", "Author_2", 102, true));
        }

        public void AddBook(string title, string author, int bookid)
        {
            //foreach (var book in library)
            //{
            //    if (book.Title == title && book.Author == author)
            //    {
            //        Console.WriteLine("Book already exists in the library.");
            //        return;
            //    }
            //}

            library.Add(new LMS(title, author, bookid, true));
            
            Console.WriteLine("Book added successfully.");
        }

        //get all books
        public List<LMS> GetBooks()
        {
            return library;
        }
    }
}
