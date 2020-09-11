
// Controller to handle all requests coming in for /api/loans
using System.Collections.Generic;
using AcmeApi.Data;
using AcmeApi.DTOs;
using AcmeApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcmeApi.Controllers
{   

    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        
        // Field used to access our data layer / DB
        private readonly ILoanRepo _repository;

        // Field used to access our Automapper
        private readonly IMapper _mapper;

        public LoansController(ILoanRepo loanRepo, IMapper mapper){
            _repository = loanRepo;
            _mapper = mapper;
        }

        
        // GET /api/loans
        [HttpGet]
        public ActionResult <IEnumerable<LoanReadDto>> GetAllLoans()
        {    
            // Get all of our loans from the DB and convert them to a DTO and send out the DTO
            var loans = _repository.GetAllLoans();
            var mappedLoans = _mapper.Map<IEnumerable<LoanReadDto>>(loans);
            var payLoad = new Dictionary<string, IEnumerable<LoanReadDto>>(){{"loans", mappedLoans}};
            return Ok(payLoad);
        } 

        // GET /api/loans/{loanId}
        [HttpGet("{loanId}", Name="GetLoanById")] 
        public ActionResult <LoanReadDto> GetLoanById(string loanId)
        {

            // Get a loan by ID, but first we will check to make sure that resource exists
            // if it does we will map it to a DTO and send out the DTO
            var loan = _repository.GetLoanById(loanId);
            if(loan == null)
            {
                return NotFound();
            }

            var mappedLoan = _mapper.Map<LoanReadDto>(loan);
            return Ok(mappedLoan);
        }

        // POST /api/loans
        [HttpPost]
        public ActionResult <LoanReadDto> CreateLoan(LoanCreateDto loanCreateDto)
        {
            // Use automapper to convert our DTO into a loan model
            var loanModel = _mapper.Map<Loan>(loanCreateDto);
            _repository.CreateLoan(loanModel);
            _repository.saveChanges();
            
            // Map the model that was saved to the DB
            var loanReadDto = _mapper.Map<LoanReadDto>(loanModel);

            // Return a 201 that also provides the resource that has created it.
            return CreatedAtRoute(nameof(GetLoanById), new {loanId = loanReadDto.loanId}, loanReadDto);
        }

        // PUT /api/loans/{loanId}
        [HttpPut("{loanId}")]
        public ActionResult UpdateLoan(string loanId, LoanUpdateDto loanUpdateDto)
        {
            // Check to see if the loan that is sent in for an update actually exists,
            // if it does not return not found, if it does exists move on.
            var loanFromRepo = _repository.GetLoanById(loanId);
            if(loanFromRepo == null)
            {
                return NotFound();
            }

            // take data from updateDto and apply to the model from the repo
            // and then convert the model to a read DTO
            _mapper.Map(loanUpdateDto, loanFromRepo);
            _repository.saveChanges();

            var updatedLoan = _mapper.Map<LoanReadDto>(loanFromRepo);

            // Return the updated data in the form of a DTO
            return Ok(updatedLoan);
        }
    }
}