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
    public class BorrowerService : IborrowerService
    {
        private readonly Iborrower _borrower;
        public BorrowerService()
        {
            _borrower = new MborrowerRepostory();
        }
        public void Commit()
        {
            _borrower.Commit();
        }

        public void CreateBorrower(Borrower borrower)
        {
            _borrower.Create(borrower);
            _borrower.Commit();
        }

        public void DeleteBorrower(int id)
        {
            _borrower.Delete(id);
            _borrower.Commit();
        }

        public List<Borrower> GetAll()
        {
            return _borrower.GetAll();
        }

        public Borrower GetbyId(int id)
        {
            return _borrower.GetbyId(id);
        }

        public void UpdateBorrower(int id, Borrower borrower)
        {
            var borrower1 = _borrower.GetbyId(id);
            borrower1.Name = borrower.Name;
            borrower1.Email = borrower.Email;
            Commit();
        }
    }
}
