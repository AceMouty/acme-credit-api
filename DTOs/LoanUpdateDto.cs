
// Data Object that is used to enforce the shape of a Loan coming from an 
// external client wanting to update a given loan.
using System.ComponentModel.DataAnnotations;

namespace AcmeApi.DTOs
{
     public class LoanUpdateDto
    {
        
        [Required]
        public string applicantName { get; set; }

        [Required]
        public string applicantPhoneNumber { get; set; }

        [Required]
        public string applicantEmail { get; set; }

        [Required]
        public string loanAmount { get; set; }

        [Required]
        public string loanId { get; set; }
    }
}