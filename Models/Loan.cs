using System.ComponentModel.DataAnnotations;

namespace AcmeApi.Models
{
        public class Loan
    {
        public int Id { get; set; }
        public string applicantName { get; set; }
        public string applicantPhoneNumber { get; set; }
        public string applicantEmail { get; set; }
        public string loanAmount { get; set; }
        public string loanId { get; set; }
        
    }
}