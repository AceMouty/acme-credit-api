using AcmeApi.Models;
using AcmeApi.DTOs;
using AutoMapper;

namespace AcmeApi.Profiles
{
    public class LoansProfile: Profile
    {
        public LoansProfile()
        {
            // When creating maps we pass in the source data first and then the target data format,
            // these are a one way translation
            //       <Source, Target>
            CreateMap<Loan, LoanReadDto>();
            CreateMap<LoanCreateDto, Loan>();
            CreateMap<LoanUpdateDto, Loan>();
        }
    }
}