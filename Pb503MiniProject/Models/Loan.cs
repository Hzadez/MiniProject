using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503MiniProject.Models
{
    public class Loan : BaseEntity
    {
        public int BorrowerId { get; set; }
        public Borrower ?Borrowers { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime MustReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<LoanItem> LoanItems { get; set; }
    }
}
