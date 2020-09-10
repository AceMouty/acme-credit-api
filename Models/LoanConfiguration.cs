using AcmeApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmeApi.Data
{
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasData(
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
            );
        }
    }
}