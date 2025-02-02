using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Services.Interfaces;

namespace Pb503MiniProject.Services.Implementation
{
    public class BorrowerService : IborrowerService
    {
        public void Commit()
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.SaveChanges();
        }

        public void CreateBorrower(Borrower borrower)
        {
            AppDbContext dbContext = new AppDbContext();
            dbContext.Borrowers.Add(borrower);
            Commit();
        }

        public void DeleteBorrower(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var delete = dbContext.Borrowers.FirstOrDefault(x => x.Id == id);
            dbContext.Remove(delete);
            Commit();
        }

        public List<Borrower> GetAll()
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Borrowers.ToList();
        }

        public Borrower GetbyId(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            return dbContext.Borrowers.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBorrower(int id, Borrower borrower)
        {
            AppDbContext dbContext = new AppDbContext();
            var Update = dbContext.Borrowers.FirstOrDefault(x => x.Id == id);
            dbContext.Borrowers.Remove(Update);
            Commit();
        }
    }
}
