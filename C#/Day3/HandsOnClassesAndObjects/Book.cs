using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Book
    {
        public int BookId;
        public string BookName;
        public string Language;
        public int Price;
        public string Author;
        public string Publisher;
    }
    class BookRepository
    {
        public Book[] books = new Book[5];
        public int idx = 0;
        public void AddBook(Book book)
        {
            if (idx <= books.Length)
            {
                books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("Book is Full");
            }
        }
        public Book[] GetBookByName(string name)
        {
            Book[] book_name = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.BookName == name)
                    {
                        book_name[idx] = book;
                        idx++;
                    }
                }
            }
            return book_name;
        }
        public Book[] GetBookByAuthor(string author)
        {
            Book[] book_author = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Author == author)
                    {
                        book_author[idx] = book;
                        idx++;
                    }
                }
            }
            return book_author;
        }
        public Book[] GetBooksByPublisher(string publisher)
        {
            Book[] book_publisher = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Publisher == publisher)
                    {
                        book_publisher[idx] = book;
                        idx++;
                    }
                }
            }
            return book_publisher;
        }
        public Book[] GetAllBook()
        {
            return books;
        }
    }


    class Book_Main
    {
        static void Main()
        {
            BookRepository bookRepository = new BookRepository();
            do
            {
                Console.WriteLine("1.Add Books");
                Console.WriteLine("2.Get Books By Name");
                Console.WriteLine("3.Get Books By Author");
                Console.WriteLine("4.Get All Books");
                Console.WriteLine("Enter U r Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter Name");
                            book.BookName = Console.ReadLine();
                            Console.WriteLine("Enter the book language:");
                            book.Language = Console.ReadLine();
                            Console.WriteLine("Enter Price:");
                            book.Price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Auther Name:");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter the Publisher Name:");
                            book.Publisher = Console.ReadLine();
                            book.BookId = new Random().Next();
                            bookRepository.AddBook(book);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Book Name:");
                            string bookName = Console.ReadLine();
                            Book[] book = bookRepository.GetBookByName(bookName);
                            foreach (Book books in book)
                            {
                                if (books != null)
                                {
                                    Console.WriteLine($"Id:{books.BookId} Book Name:{books.BookName} Book Language:{books.Language} Price:{books.Price} Author:{books.Author} Publisher:{books.Publisher}");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Author Name:");
                            string bookAuthor = Console.ReadLine();
                            Book[] book = bookRepository.GetBookByAuthor(bookAuthor);
                            foreach (Book books in book)
                            {
                                if (books != null)
                                {
                                    Console.WriteLine($"Id:{books.BookId} Book Name:{books.BookName} Book Language:{books.Language} Price:{books.Price} Author:{books.Author} Publisher:{books.Publisher}");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        {

                            Book[] book = bookRepository.GetAllBook();
                            foreach (Book books in book)
                            {
                                if (books != null)
                                {
                                    Console.WriteLine($"Id:{books.BookId} Book Name:{books.BookName} Book Language:{books.Language} Price:{books.Price} Author:{books.Author} Publisher:{books.Publisher}");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;


                }
            } while (true);
        }
    }
}