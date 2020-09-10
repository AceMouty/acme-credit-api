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