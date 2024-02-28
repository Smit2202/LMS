using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class DisplayUser
    {
        public static void ShowUser(BookIssue bookIssue)
        {
            Console.WriteLine();
            Console.WriteLine("User details:");

            foreach (var book in bookIssue.getUname())
            {

                Console.WriteLine($"{book.Uname} {book.BookID}");

            }

            Console.WriteLine();



        }


    }
}
