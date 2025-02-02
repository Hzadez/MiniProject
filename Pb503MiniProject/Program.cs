using Pb503MiniProject.Models;

namespace Pb503MiniProject
{
    internal class Program
    {
        static List<Author> authors = new List<Author>();
        static List<Book> books = new List<Book>();
        static List<Borrower> borrowers = new List<Borrower>();
        static List<LoanItem> loans = new List<LoanItem>();

        static void Main(string[] args)
        {
            while (true)
            {
               Console.WriteLine("                                                                                                                                                                           Select an action:");
               Console.WriteLine("                                                                                                                                                                           1 - Author actions");
               Console.WriteLine("                                                                                                                                                                           2 - Book actions");
               Console.WriteLine("                                                                                                                                                                           3 - Borrower actions");
               Console.WriteLine("                                                                                                                                                                           4 - BorrowBook");
               Console.WriteLine("                                                                                                                                                                           5 - ReturnBook");
               Console.WriteLine("                                                                                                                                                                           6 - Most borrowed book");
               Console.WriteLine("                                                                                                                                                                           7 - Delayed borrowers list");
               Console.WriteLine("                                                                                                                                                                           8 - Borrowed books by borrower");
               Console.WriteLine("                                                                                                                                                                           9 - Filter books by title");
               Console.WriteLine("                                                                                                                                                                           10 - Filter books by author");
               Console.WriteLine("                                                                                                                                                                           0 - Exit");

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

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":

                        break;
                    case "10":

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
        static void ListAuthors()
        {

        }
        static void CreateAuthor()
        {
            Console.WriteLine("Enter author name:");
            var name = Console.ReadLine();
            authors.Add(new Author { });
            Console.WriteLine("Author created successfully.");

        }
        static void EditAuthor()
        {
            Console.WriteLine("Enter author ID to edit:");
            var id = int.Parse(Console.ReadLine());
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author != null)
            {
                Console.WriteLine("Enter new author name:");
                author.Name = Console.ReadLine();
                Console.WriteLine("Author updated successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }
        static void DeleteAuthor()
        {
            Console.WriteLine("Enter author ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author != null)
            {
                authors.Remove(author);
                Console.WriteLine("Author deleted successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }
        /////////////////////////////////////
        static void ListBooks()
        {

        }
        static void CreateBook()
        {
            Console.WriteLine("Enter book name:");
            var name = Console.ReadLine();
            books.Add(new Book { });
            Console.WriteLine("Book created successfully.");
        }
        static void EditBook()
        {
            Console.WriteLine("Enter book ID to edit:");
            var id = int.Parse(Console.ReadLine());
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                Console.WriteLine("Enter new book name:");
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
            Console.WriteLine("Enter book ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        /////////////////////////////////////
        static void ListBorrower()
        {

        }
        static void CreateBorrower()
        {
            Console.WriteLine("Enter Borrower name:");
            var name = Console.ReadLine();
            borrowers.Add(new Borrower { });
            Console.WriteLine("Borrower created successfully.");
        }
        static void EditBorrower()
        {
            Console.WriteLine("Enter borrower ID to edit:");
            var id = int.Parse(Console.ReadLine());
            var borrower = borrowers.FirstOrDefault(x => x.Id == id);

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
            Console.WriteLine("Enter borrower ID to delete:");
            var id = int.Parse(Console.ReadLine());
            var borrower = borrowers.FirstOrDefault(x => x.Id == id);

            if (borrower != null)
            {
                borrowers.Remove(borrower);
                Console.WriteLine("Borrower deleted successfully.");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }
        /////////////////////////////////////

    }
}


