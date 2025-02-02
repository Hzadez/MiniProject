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
    public class AuthorService : IauthorService
    {
        private readonly Iauthor _author;

        public AuthorService()
        {
            _author = new Mauthor();
        }

        public void Commit()
        {
            _author.Commit();
        }

        public void CreateAuthor(Author author)
        {
            _author.Create(author);
            _author.Commit();  
        }

        public void DeleteAuthor(int id)
        {
            _author.Delete(id);
            _author.Commit();
        }

        public List<Author> GetAll()
        {
            return _author.GetAll();
        }

        public Author GetbyId(int id)
        {
            return _author.GetbyId(id);
        }

        public void UpdateAuthor(int id, Author author)
        {
            var author1 = _author.GetbyId(id);
            author1.Name = author.Name;
            Commit();
        }
    }
}
