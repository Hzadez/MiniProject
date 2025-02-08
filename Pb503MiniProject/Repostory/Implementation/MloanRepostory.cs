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
    public class MloanRepostory : GenericRepostory<Loan>, Iloan
    {
        private readonly AppDbContext _context;
        public MloanRepostory()
        {
            _context = new AppDbContext();
        }

        public List<Loan> GetAllLoan()
        {
            return _context.Loans.Include(x => x.Borrowers).ToList();
        }

        public Loan? GetByIdLoan(int id)
        {
            var data = _context.Loans.Include(x => x.Borrowers).FirstOrDefault(x => x.Id == id);
            return data;
        }
    }
}
