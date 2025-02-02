using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503MiniProject.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public List<Book>Books{ get; set; }
        public int BookId { get; set; }

    }
}
