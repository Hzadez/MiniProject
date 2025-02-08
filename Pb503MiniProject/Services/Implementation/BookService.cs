using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Repostory.I;
using Pb503MiniProject.Repostory.Implementation;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class BookService : IbookService
    {
        private readonly Ibook _book;
        public BookService()
        {
            _book = new MBookRepostory();
        }
        public void Commit()
        {
            _book.Commit();
        }

        public void CreateBook(Book book)
        {
            _book.Create(book);
            _book.Commit();
        }

        public void DeleteBook(int id)
        {
            _book.Delete(id);
            _book.Commit();
        }

        public List<Book> GetAll()
        {
            Ibook bookRepository = new MBookRepostory();

            if (bookRepository.GetAll() is null)
            {
                throw new Exception("Book is not found");
            }


            return bookRepository.GetAll();
        }

        public Book GetbyId(int id)
        {
            return _book.GetbyId(id);
        }

        public void UpdateBook(int id, Book book)
        {
            var book1 = _book.GetbyId(id);
            book1.Title = book.Title;
            book1.Description = book.Description;
            Commit();
        }
        public List<Book> FilterBooksbyTitle(string title)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in _book.GetAll()) 
            {
            if (book.Title.ToLower().Contains(book.Title.ToLower()))
                {
                    books.Add(book);
                }
            }
            return books;
        }
    }
}
