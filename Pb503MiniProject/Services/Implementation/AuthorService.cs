using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class AuthorService : IauthorService
    {
        public void Commit()
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.SaveChanges();
        }

        public void CreateAuthor(Author author)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.Authors.Add(author);
            Commit();
        }

        public void DeleteAuthor(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var delete = dbContext.Authors.FirstOrDefault(x => x.Id == id);
            dbContext.Remove(delete);
            Commit();
        }

        public List<Author> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Authors.ToList();
        }

        public Author GetbyId(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Authors.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateAuthor(int id, Author author)
        {
            AppDbContext dbContext = new AppDbContext();
            var Update = dbContext.Authors.FirstOrDefault(x => x.Id == id);
            dbContext.Authors.Remove(Update);
            Commit();
        }
    }
}
