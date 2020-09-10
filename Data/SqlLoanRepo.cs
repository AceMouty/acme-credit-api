using System.Collections.Generic;
using System.Linq;
using AcmeApi.Models;

namespace AcmeApi.Data
{
    public class SqlLoanRepo : ILoanRepo
    {
        private readonly LoanContext _context;
        public SqlLoanRepo(LoanContext context)
        {
            _context = context;
        }
        public IEnumerable<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan GetLoanById(string loanId)
        {
            return _context.Loans.FirstOrDefault( loan => loan.loanId == loanId);
        }
    }
}