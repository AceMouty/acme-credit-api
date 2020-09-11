
// Data Object used to read in data from a client
// and enforce the shape of a external Loan
using System.ComponentModel.DataAnnotations;

namespace AcmeApi.DTOs
{
    public class LoanCreateDto
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