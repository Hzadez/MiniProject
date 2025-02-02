using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class LoanItemService : IloanitemService
    {
        public void Commit()
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.SaveChanges();
        }

        public void CreateLoanItem(LoanItem loanItem)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.LoanItems.Add(loanItem);
            Commit();
        }

        public void DeleteLoanItem(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var delete = dbContext.LoanItems.FirstOrDefault(x => x.Id == id);
            dbContext.Remove(delete);
            Commit();
        }

        public List<LoanItem> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.LoanItems.ToList();
        }

        public LoanItem GetbyId(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.LoanItems.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateLoanItem(int id, LoanItem loanItem)
        {
            AppDbContext dbContext = new AppDbContext();
            var Update = dbContext.LoanItems.FirstOrDefault(x => x.Id == id);
            dbContext.LoanItems.Remove(Update);
            Commit();
        }
    }
}
