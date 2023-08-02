using BookLib;
using System;
using System.Collections.Generic;
namespace Assignment20
{

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            char opt;
            do
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by Book ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter Book ID: ");
                            int bookId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();

                            Book book = new Book(bookId, title, author, genre);
                            library.AddBook(book);
                            Console.WriteLine("Book added successfully.");
                            break;
                        }
                    case 2:
                        {
                            library.ViewAllBooks();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter Book ID to search: ");
                            int searchId = int.Parse(Console.ReadLine());
                            library.SearchBookById(searchId);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter Title to search: ");
                            string searchTitle = Console.ReadLine();
                            library.SearchBookByTitle(searchTitle);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exiting the program. Goodbye!");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                        }
                }

                Console.WriteLine("\nPress y to continue...");
                opt = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (opt =='y');
        }
    }

}