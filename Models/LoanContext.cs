
// A context that is used to interact with the DB and build out tables
// and seed that DB with data.
using AcmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeApi.Data
{
    public class LoanContext: DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> opt) : base(opt)
        {
        
        }

        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoanConfiguration());
        }
    }
}