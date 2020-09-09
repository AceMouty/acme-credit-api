using System.Collections.Generic;
using AcmeApi.Data;
using AcmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmeApi.Controllers
{   

    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {

        private readonly ILoanRepo _repository;

        public LoansController(ILoanRepo loanRepo){
            _repository = loanRepo;
        }

        
        // GET /api/loans
        [HttpGet]
        public ActionResult <IEnumerable<Loan>> GetAllLoans()
        {    
            var loans = _repository.GetAllLoans();
            return Ok(loans);
        } 

        // GET /api/loans/{loanId}
        [HttpGet("{loanId}")] 
        public ActionResult <Loan> GetLoanById(string loanId)
        {
            var loan = _repository.GetLoanById(loanId);
            return Ok(loan);
        }
    }
}