using System.Collections.Generic;
using Pb503MiniProject.Models;
using Pb503MiniProject.Repostory.Implementation;
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
                      //BorrowBook();
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
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        FilterBooksbyTitle(title);      
                    break;
                    case "10":
                        Console.Write("Enter author name: ");
                        var authorId = int.Parse(Console.ReadLine());
                        //FilterBooksByAuthor(authorId);
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
        static void PrintBooks()
        {
            List<Book> books = new List<Book>();
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }
            Console.WriteLine("\nFiltered Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.Title} (Published: {book.PublishedYear})");
            }
        }
        static List<Book> FilterBooksbyTitle(string title) { IbookService bookService = new BookService();
         return bookService.FilterBooksbyTitle(title); }
        //static List<Book> FilterBooksByAuthor(int id) { IbookService bookService = new BookService(); 
        //return bookService.GetAll().Where(b => b.Authors.Any(a => a.Id.ToList())); }
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
        static void BorrowBook(IloanService loanService, IbookService bookService, IborrowerService borrowerService)
        {
                List<LoanItem> selectedBooks = new List<LoanItem>();
                Borrower selectedBorrower = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Available books:");
                var books = bookService.GetAll();
                var unavailableBookIds = loanService.GetAll().Where(x => x.ReturnDate == null).SelectMany(x => x.LoanItems.Select(li => li.BookId)).ToHashSet();
                foreach (var book in books)
                {
                    string status = unavailableBookIds.Contains(book.Id) ? "Not Available" : "Available";
                    Console.WriteLine($"[{book.Id}] {book.Title} - {status}");
                }

                Console.Write("\nEnter Book ID to borrow (or 0 to continue): ");
                if (!int.TryParse(Console.ReadLine(), out int bookId) || bookId == 0)
                    break;

                if (unavailableBookIds.Contains(bookId))
                {
                    Console.WriteLine("This book is not available.");
                    continue;
                }

                var selectedBook = books.FirstOrDefault(b => b.Id == bookId);
                if (selectedBook != null)
                {
                    selectedBooks.Add(new LoanItem { BookId = selectedBook.Id });
                    Console.WriteLine($"Added: {selectedBook.Title}");
                }
            }

            if (!selectedBooks.Any())
            {
                Console.WriteLine("No books selected. Operation canceled.");
                return;
            }

            while (selectedBorrower == null)
            {
                Console.Clear();
                Console.WriteLine("Select a Borrower:");

                var borrowers = borrowerService.GetAll();
                foreach (var borrower in borrowers)
                {
                    Console.WriteLine($"[{borrower.Id}] {borrower.Name}");
                }

                Console.Write("\nEnter Borrower ID: ");
                if (int.TryParse(Console.ReadLine(), out int borrowerId))
                {
                    selectedBorrower = borrowers.FirstOrDefault(b => b.Id == borrowerId);
                }
            }

            Console.WriteLine("\nConfirm loan? (Y/N)");
            if (Console.ReadLine()?.Trim().ToLower() != "y")
            {
                Console.WriteLine("Loan canceled.");
                return;
            }
        }
        /////////////////////////////////////
        static void ListAuthors()
        {
            IauthorService _authorService = new AuthorService();
            foreach (var author in _authorService.GetAll())
            {
                Console.WriteLine($"Id : {author.Id} -- Name : {author.Name}");
            }
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
            IbookService _bookService = new BookService();
            foreach (var book in _bookService.GetAll())
            {
                Console.WriteLine($"Id : {book.Id} -- Title : {book.Title} -- Description : {book.Description}");
            }
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
            Book book = new Book();
            IbookService _bookService = new BookService();
            Console.WriteLine("Enter book ID to edit:");
            var id = int.Parse(Console.ReadLine());
           

            if (book != null)
            {
                Console.WriteLine("Enter new book title:");
                book.Title = Console.ReadLine();
                Console.WriteLine("Enter book description:");
                book.Description = Console.ReadLine();
                _bookService.UpdateBook(id,book);
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
            IborrowerService _borrrowerService = new BorrowerService();
            foreach (var borrower in _borrrowerService.GetAll())
            {
                Console.WriteLine($"Id : {borrower.Id} -- Name : {borrower.Name} -- Email : {borrower.Email}");
            }
        }
        static void CreateBorrower()
        {
            IborrowerService _borrrowerService = new BorrowerService();
            Console.WriteLine("Enter Borrower name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Borrower email:");
            var email = Console.ReadLine();
            _borrrowerService.CreateBorrower(new Borrower {Name=name,Email=email});
            Console.WriteLine("Borrower created successfully.");
        }
        static void EditBorrower()
        {
            Borrower borrower = new Borrower();
            IborrowerService _borrrowerService = new BorrowerService();
            Console.WriteLine("Enter borrower ID to edit:");
            var id = int.Parse(Console.ReadLine());
            

            if (borrower != null)
            {
                Console.WriteLine("Enter new borrower name:");
                borrower.Name = Console.ReadLine();
                Console.WriteLine("Enter book Email:");
                borrower.Email = Console.ReadLine();
                _borrrowerService.UpdateBorrower(id, borrower);
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


