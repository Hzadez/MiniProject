using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pb503MiniProject.Models;
using Pb503MiniProject.Repostory.I;

namespace Pb503MiniProject.Repostory.Implementation
{
    public class MborrowerRepostory : GenericRepostory<Borrower>, Iborrower
    {
    }
}
