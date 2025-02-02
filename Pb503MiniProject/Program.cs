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
                Console.WriteLine("Select an action:");
                Console.WriteLine("1 - Author actions");
                Console.WriteLine("2 - Book actions");
                Console.WriteLine("3 - Borrower actions");
                Console.WriteLine("4 - BorrowBook");
                Console.WriteLine("5 - ReturnBook");
                Console.WriteLine("6 - Most borrowed book");
                Console.WriteLine("7 - Delayed borrowers list");
                Console.WriteLine("8 - Borrowed books by borrower");
                Console.WriteLine("9 - Filter books by title");
                Console.WriteLine("10 - Filter books by author");
                Console.WriteLine("0 - Exit");

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

                                    break;
                                case "2":

                                    break;
                                case "3":

                                    break;
                                case "4":

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

                        }
                        static void BorrowerActions()
                        {
                            Console.WriteLine("1 - List all borrowers");
                            Console.WriteLine("2 - Create borrower");
                            Console.WriteLine("3 - Edit borrower");
                            Console.WriteLine("4 - Delete borrower");
                            Console.WriteLine("0 - Exit");  

                        }

                }

            }
        }
    }
}


