using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class BookService : IbookService
    {
        public void Commit()
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.Books.Add(book);
           Commit();
        }

        public void DeleteBook(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var delete = dbContext.Books.FirstOrDefault(x => x.Id == id);
            dbContext.Remove(delete);
            Commit();
        }

        public List<Book> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Books.ToList();
        }

        public Book GetbyId(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBook(int id, Book book)
        {
            AppDbContext dbContext = new AppDbContext();
            var Update = dbContext.Books.FirstOrDefault(x => x.Id == id);
            dbContext.Books.Remove(Update);
            Commit();
        }
    }
}
