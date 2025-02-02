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
    public class LoanService : IloanService
    {
        private readonly Iloan _loan;
        public LoanService()
        {
            _loan = new Mloan();
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void CreateLoan(Loan loan)
        {
            _loan.Create(loan);
            _loan.Commit();
        }

        public void DeleteLoan(int id)
        {
            _loan.Delete(id);
            _loan.Commit();
        }

        public List<Loan> GetAll()
        {
            return _loan.GetAll();
        }

        public Loan GetbyId(int id)
        {
            return _loan.GetbyId(id);
        }

        public void UpdateLoan(int id, Loan loan)
        {
            var loan1 = _loan.GetbyId(id);
            loan1.Borrowers = loan.Borrowers;
            Commit();
        }
    }
}
