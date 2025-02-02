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
            _book = new Mbook();
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
            return _book.GetAll();
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
    }
}
