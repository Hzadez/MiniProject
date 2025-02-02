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
    public class LoanItemService : IloanitemService
    {
        private readonly Iloanitem _loanitem;
        public LoanItemService()
        {
            _loanitem = new Mloanitem();
        }

        public void Commit()
        {
            _loanitem.Commit();
        }

        public void CreateLoanItem(LoanItem loanItem)
        {
            _loanitem.Create(loanItem);
            _loanitem.Commit();
        }

        public void DeleteLoanItem(int id)
        {
            _loanitem.Delete(id);
            _loanitem.Commit();
        }

        public List<LoanItem> GetAll()
        {
            return _loanitem.GetAll();
        }

        public LoanItem GetbyId(int id)
        {
            return _loanitem.GetbyId(id);
        }

        public void UpdateLoanItem(int id, LoanItem loanItem)
        {
            var loanitem1 = _loanitem.GetbyId(id);
            loanitem1.Loans = loanItem.Loans;
            Commit();
        }
    }
}
