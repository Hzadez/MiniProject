using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;

namespace Pb503MiniProject.Services.Interfaces
{
    public interface IloanitemService
    {
        void CreateLoanItem(LoanItem loanItem);
        void DeleteLoanItem(int id);
        void UpdateLoanItem(int id, LoanItem loanItem);
        LoanItem GetbyId(int id);
        List<LoanItem> GetAll();
        void Commit();
    }
}
