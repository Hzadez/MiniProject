using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Services.Interfaces
{
    public interface IbookService
    {
        void CreateBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(int id,Book book);
        Book GetbyId(int id);
        List<Book> GetAll();
        void Commit();
    }
}
