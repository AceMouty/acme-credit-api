
// This file is used to hold MOCK data for simple testing with an API client
using System.Collections.Generic;
using AcmeApi.Models;

namespace AcmeApi.Data
{
    public class MockLoanRepo : ILoanRepo
    {
        public void CreateLoan(Loan newLoan)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Loan> GetAllLoans()
        {
            var loans = new List<Loan>
            {
              new Loan
              { 
                    Id=1,
                    applicantName="John Doe",
                    applicantEmail="JohnDoe@gmail.com",
                    applicantPhoneNumber="000-867-5309",
                    loanAmount="34,000.00",
                    loanId="924e075f-4058-49fb-98f4-11283a1c2ad2"
              },
              new Loan
              { 
                Id=2,
                applicantName="Jane Doe",
                applicantEmail="JaneDoe@gmail.com",
                applicantPhoneNumber="000-867-5310",
                loanAmount="80,000.00",
                loanId="0d7f34f6-f9ef-4077-b1f1-925a7a0bc884"
              },
              new Loan
              {
                Id=3,
                applicantName="Jimmy Doe",
                applicantEmail="JimmyDoe@gmail.com",
                applicantPhoneNumber="000-867-5311",
                loanAmount="200.00",
                loanId="71da68a7-c1e4-4497-9fb4-29b2bd8acfca"
              }
            };

            return loans;
        }

        public Loan GetLoanById(string id)
        {
           return new Loan {Id=1, applicantName="John Doe", applicantEmail="JohnDoe@gmail.com", applicantPhoneNumber="000-867-5309", loanAmount="34,000.00", loanId="924e075f-4058-49fb-98f4-11283a1c2ad2"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}