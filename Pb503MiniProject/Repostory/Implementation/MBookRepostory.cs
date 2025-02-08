using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pb503MiniProject.Models;
using Pb503MiniProject.Repostory.I;

namespace Pb503MiniProject.Repostory.Implementation
{
    public class MBookRepostory : GenericRepostory<Book>, Ibook
    {
       

        public List<Book> GetAllByInclude()
        {
            return _appDbContext.Books.Include(x => x.Authors).ToList();
        }

        public Book? GetByIdInclude(int id)
        {
            var data = _appDbContext.Books.Include(x => x.Authors).FirstOrDefault(x => x.Id == id);
            return data;
        }
    }
}
