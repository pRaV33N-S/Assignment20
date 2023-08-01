
using BookLib;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Library lib = new Library();
            Console.WriteLine("Welcome to the Library");
            Console.WriteLine("The Options\n1. Add a Book\n2. View All the Books\n3. Search Book By Id\n4. Search Book By Title");
            Console.WriteLine("Choose an Option");

        repeat:
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Book Genre: ");
                        string genre = Console.ReadLine();

                        Book newBook = new Book(bookId, title, author, genre);
                        lib.AddBook(newBook);
                        break;
                    }
                case 2:
                    {
                        lib.ViewAllBooks();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        lib.SearchBookById(searchId);
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();
                        lib.SearchBookByTitle(searchTitle);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Option!!!\nChoose the right one");
                        goto repeat;
                    }
            }

            Console.WriteLine("Press 1 to Continue");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
                goto repeat;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}