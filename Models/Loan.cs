
// Code representation of what a Loan Model / Table / Resource will look like
using System.ComponentModel.DataAnnotations;

namespace AcmeApi.Models
{
        public class Loan
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string applicantName { get; set; }

        [Required]
        [MaxLength(250)]
        public string applicantPhoneNumber { get; set; }

        [Required]
        [MaxLength(250)]
        public string applicantEmail { get; set; }

        [Required]
        [MaxLength(250)]
        public string loanAmount { get; set; }

        [Required]
        [MaxLength(300)]
        public string loanId { get; set; }
        
    }
}