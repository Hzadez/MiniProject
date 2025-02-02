using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pb503MiniProject.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book>Books  { get; set; }
        public DbSet<Author>Authors  { get; set; }
        public DbSet<Borrower>Borrowers  { get; set; }
        public DbSet<Loan>Loans  { get; set; } 
        public DbSet<LoanItem>LoanItems  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEYNAL\\SQLEXPRESS;Database=Pb503MiniProject;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
