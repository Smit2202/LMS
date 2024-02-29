using System;
using System.Collections.Generic;


namespace LibraryManagementSystem
{
	public class BookIssue
	{
		public List<ULMS> bookIssue;

		public BookIssue()
		{
			
			bookIssue = new List<ULMS>();
		}

	



        public void AddUname(string name, string bookname)
		{
			
          
                bookIssue.Add(new ULMS(name, bookname));
                Console.WriteLine("person added successfully.");





            
        }

		//get all books
		public List<ULMS> getUname()
		{
			return bookIssue;
		}
	}
}