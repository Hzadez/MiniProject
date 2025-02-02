using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Services.Interfaces
{
    public interface IauthorService
    {
        void CreateAuthor(Author author);
        void DeleteAuthor(int id);
        void UpdateAuthor(int id, Author author);
        Author GetbyId(int id);
        List<Author> GetAll();
        void Commit();
    }
}
