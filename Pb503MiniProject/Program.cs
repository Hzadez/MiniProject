using System.Collections.Generic;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Implementation;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("                                                                                                                                                                         Select an action:");
                Console.WriteLine("                                                                                                                                                                         1 - Author actions");
                Console.WriteLine("                                                                                                                                                                         2 - Book actions");
                Console.WriteLine("                                                                                                                                                                         3 - Borrower actions");
                Console.WriteLine("                                                                                                                                                                         4 - BorrowBook");
                Console.WriteLine("                                                                                                                                                                         5 - ReturnBook");
                Console.WriteLine("                                                                                                                                                                         6 - Most borrowed book");
                Console.WriteLine("                                                                                                                                                                         7 - Delayed borrowers list");
                Console.WriteLine("                                                                                                                                                                         8 - Borrowed books by borrower");
                Console.WriteLine("                                                                                                                                                                         9 - Filter books by title");
                Console.WriteLine("                                                                                                                                                                         10 - Filter books by author");
                Console.WriteLine("                                                                                                                                                                         0 - Exit");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        AuthorActions();
                        break;
                    case "2":
                        BookActions();
                        break;
                    case "3":
                        BorrowerActions();
                        break;
                    case "4":
                        BorrowBook();
                        break;
                    case "5":
                        ReturnBook();
                        break;
                    case "6":
                        MostBorrowedBook();
                        break;
                    case "7":
                        DelayedBorrowersList();
                        break;
                    case "8":
                        BorrowedBooksbyBorrower();
                        break;
                    case "9":
                        FilterBooksbyTitle();
                        break;
                    case "10":
                        FilterBooksbyAuthor();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid action.");
                        break;
                        static void AuthorActions()
                        {
                            Console.WriteLine("1 - List all authors");
                            Console.WriteLine("2 - Create author");
                            Console.WriteLine("3 - Edit author");
                            Console.WriteLine("4 - Delete author");
                            Console.WriteLine("0 - Exit");

                            var action = Console.ReadLine();
                            switch (action)
                            {
                                case "1":
                                    ListAuthors();
                                    break;
                                case "2":
                                    CreateAuthor();
                                    break;
                                case "3":
                                    EditAuthor();
                                    break;
                                case "4":
                                    DeleteAuthor();
                                    break;
                                case "0":
                                    return;
                                default:
                                    Console.WriteLine("Invalid action.");
                                    break;
                            }
                        }
                        static void BookActions()
                        {
                            Console.WriteLine("1 - List all books");
                            Console.WriteLine("2 - Create book");
                            Console.WriteLine("3 - Edit book");
                            Console.WriteLine("4 - Delete book");
                            Console.WriteLine("0 - Exit");

                            var action = Console.ReadLine();
                            switch (action)
                            {
                                case "1":
                                    ListBooks();
                                    break;
                                case "2":
                                    CreateBook();
                                    break;
                                case "3":
                                    EditBook();
                                    break;
                                case "4":
                                    DeleteBook();
                                    break;
                                case "0":
                                    return;
                                default:
                                    Console.WriteLine("Invalid action.");
                                    break;
                            }


                        }
                        static void BorrowerActions()
                        {
                            Console.WriteLine("1 - List all borrowers");
                            Console.WriteLine("2 - Create borrower");
                            Console.WriteLine("3 - Edit borrower");
                            Console.WriteLine("4 - Delete borrower");
                            Console.WriteLine("0 - Exit");

                            var action = Console.ReadLine();
                            switch (action)
                            {
                                case "1":
                                    ListBorrower();
                                    break;
                                case "2":
                                    CreateBorrower();
                                    break;
                                case "3":
                                    EditBorrower();
                                    break;
                                case "4":
                                    DeleteBorrower();
                                    break;
                                case "0":
                                    return;
                                default:
                                    Console.WriteLine("Invalid action.");
                                    break;
                            }
                        }

                }

            }
        }
        /////////////////////////////////////
        static void FilterBooksbyAuthor()
        {


        }
        static void FilterBooksbyTitle()
        {


        }
        static void BorrowedBooksbyBorrower()
        {


        }
        static void DelayedBorrowersList()
        {


        }
        static void MostBorrowedBook()
        {


        }
        static void ReturnBook()
        {


        }
        static void BorrowBook()
        { 
        

        }
        /////////////////////////////////////
        static void ListAuthors()
        {

        }
        static void CreateAuthor()
        {
             IauthorService _authorService = new AuthorService();
            Console.WriteLine("Enter author name:");
            var name = Console.ReadLine();
            _authorService.CreateAuthor(new Author
            {
                Name = name
            });
            Console.WriteLine("Author created successfully.");

        }
        static void EditAuthor()
        {
            Author author = new Author();

            IauthorService _authorService = new AuthorService();
            Console.WriteLine("Enter author ID to edit:");
            var id = int.Parse(Console.ReadLine());
            
            if (author != null)
            {
                Console.WriteLine("Enter new author name:");
                author.Name = Console.ReadLine();
                _authorService.UpdateAuthor(id, author);
                Console.WriteLine("Author updated successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }
        static void DeleteAuthor()
        {
            IauthorService _authorService = new AuthorService();
            Console.WriteLine("Enter author ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var author = _authorService.GetbyId(id);

            if (author != null)
            {
                _authorService.DeleteAuthor(id);
                Console.WriteLine("Author deleted successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }
        ///////////////////////////////////
        static void ListBooks()
        {

        }
        static void CreateBook()
        {
            IbookService _bookService = new BookService();
            Console.WriteLine("Enter book title:"); 
            var Title = Console.ReadLine();
            Console.WriteLine("Enter book description:");
            var Description = Console.ReadLine();
            _bookService.CreateBook(new Book{Title= Title, Description = Description});
            Console.WriteLine("Book created successfully.");
        }
        static void EditBook()
        {
            IbookService _bookService = new BookService();
            Console.WriteLine("Enter book ID to edit:");
            var id = int.Parse(Console.ReadLine());
            var book = _bookService.GetbyId(id);

            if (book != null)
            {
                Console.WriteLine("Enter new book title:");
                book.Title = Console.ReadLine();
                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        static void DeleteBook()
        {
            IbookService _bookService = new BookService();
            Console.WriteLine("Enter book ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var book = _bookService.GetbyId(id);

            if (book != null)
            {
                _bookService.DeleteBook(id);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        ///////////////////////////////////
        static void ListBorrower()
        {

        }
        static void CreateBorrower()
        {
            IborrowerService _borrrowerService = new BorrowerService();
            Console.WriteLine("Enter Borrower name:");
            var name = Console.ReadLine();
            _borrrowerService.CreateBorrower(new Borrower {Name=name});
            Console.WriteLine("Borrower created successfully.");
        }
        static void EditBorrower()
        {
            IborrowerService _borrrowerService = new BorrowerService();
            Console.WriteLine("Enter borrower ID to edit:");
            var id = int.Parse(Console.ReadLine());
            var borrower = _borrrowerService.GetbyId(id);

            if (borrower != null)
            {
                Console.WriteLine("Enter new borrower name:");
                borrower.Name = Console.ReadLine();
                Console.WriteLine("Borrower updated successfully.");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }
        static void DeleteBorrower()
        {
            IborrowerService _borrrowerService = new BorrowerService();
            Console.WriteLine("Enter borrower ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var borrower = _borrrowerService.GetbyId(id);

            if (borrower != null)
            {
                _borrrowerService.DeleteBorrower(id);
                Console.WriteLine("Borrower deleted successfully.");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }
        ///////////////////////////////////

    }
}


