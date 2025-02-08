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
    public class MLoanitemRepostory : GenericRepostory<LoanItem>, Iloanitem
    {
        private readonly AppDbContext _context;

        public MLoanitemRepostory()
        {
            _context = new AppDbContext();
        }

        public List<LoanItem> GetAllLoanItem()
        {
            return _context.LoanItems.Include(x => x.Loans).Include(x => x.Books).ToList();

        }

        public LoanItem GetByIdLoanItem(int id)
        {
            var data = _context.LoanItems.Include(x => x.Loans).Include(x => x.Books).FirstOrDefault(x => x.Id == id);
            return data;
        }
    }
}
