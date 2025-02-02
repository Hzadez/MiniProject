using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Services.Interfaces
{
    public interface IborrowerService
    {
        void CreateBorrower(Borrower borrower);
        void DeleteBorrower(int id);
        void UpdateBorrower(int id, Borrower borrower);
        Borrower GetbyId(int id);
        List<Borrower> GetAll();
        void Commit();
    }
}
