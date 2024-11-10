using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN6
{
    public class Library
    {
        private Book[] books;
        private int bookCount;

        public Library(int capacity)
        {
            books = new Book[capacity]; 
            bookCount = 0;  
        }

        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = book; 
                bookCount++;  
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }

        public void RemoveBook(string title)
        {
            bool bookFound = false;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Title == title)
                {
                    for (int j = i; j < bookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }

                    books[bookCount - 1] = null;
                    bookCount--;
                    bookFound = true;
                    break;
                }
            }

            if (!bookFound)
            {
                Console.WriteLine($"No book found");
            }
        }

        public void FindBook(string title)
        {
            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Title == title)
                {
                    Console.WriteLine($"{books[i].Title} by {books[i].Author}, published in {books[i].Year}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found");
            }
        }

        public void PrintBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                for (int i = 0; i < bookCount; i++)
                {
                    Console.WriteLine($"{books[i].Title} by {books[i].Author}, published in {books[i].Year}");
                }
            }
        }

        public int Count
        {
            get { return bookCount; }
        }
    }
}

