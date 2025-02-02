using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503MiniProject.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }
        public List<Author>Authors { get; set; }
        public int AuthorId { get; set; }
    }
}
