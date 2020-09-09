using System.Collections.Generic;
using AcmeApi.Models;

namespace AcmeApi.Data
{
    public interface ILoanRepo
    {
        // Get all loans
        IEnumerable<Loan> GetAllLoans();

        // Get a loan by a Loan ID
        Loan GetLoanById(string id);

    }
}