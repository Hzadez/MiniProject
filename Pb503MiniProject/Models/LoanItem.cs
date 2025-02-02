using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503MiniProject.Models
{
    public class LoanItem : BaseEntity
    {
        public int LoanId { get; set; }
        public Loan Loans { get; set; }
        public int BookId { get; set; }
        public Book ?Books { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime MustReturnDate { get; set; }
    }
}
