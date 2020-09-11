
// Loan interface that acts as a contract specifing methods that
// we should have in our Data Access Layer for LoanRepo and also our Mock Repo
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

        // Create a new loan in the DB
        void CreateLoan(Loan newLoan);

        // Used to save changes to our models / DB
        bool saveChanges();

    }
}