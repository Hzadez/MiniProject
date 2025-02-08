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
    public class MAuthorRepostory : GenericRepostory<Author>, Iauthor
    {
        private readonly AppDbContext _context;

        public MAuthorRepostory()
        {
            _context = new AppDbContext();
        }
        public List<Author> GetAllAuthorsByInclude()
        {
            return _context.Authors.Include(x => x.Books).ToList();
        }

        public Author? GetByIdAuthorsInclude(int id)
        {
            var data = _context.Authors.Include(x => x.Books).FirstOrDefault(x => x.Id == id);
            return data;
        }
    }
}
