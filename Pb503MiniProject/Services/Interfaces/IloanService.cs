using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Services.Interfaces
{
    public interface IloanService
    {
        void CreateLoan(Loan loan);
        void DeleteLoan(int id);
        void UpdateLoan(int id, Loan loan);
        Loan GetbyId(int id);
        List<Loan> GetAll();
        void Commit();
    }
}
