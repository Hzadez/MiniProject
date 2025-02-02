using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class LoanService : IloanService
    {
        public void Commit()
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.SaveChanges();
        }

        public void CreateLoan(Loan loan)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.Loans.Add(loan);
            Commit();
        }

        public void DeleteLoan(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var delete = dbContext.Loans.FirstOrDefault(x => x.Id == id);
            dbContext.Remove(delete);
            Commit();
        }

        public List<Loan> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Loans.ToList();
        }

        public Loan GetbyId(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Loans.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateLoan(int id, Loan loan)
        {
            AppDbContext dbContext = new AppDbContext();
            var Update = dbContext.Loans.FirstOrDefault(x => x.Id == id);
            dbContext. Loans.Remove(Update);
            Commit();
        }
    }
}
