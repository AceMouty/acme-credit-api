using AcmeApi.Models;
using AcmeApi.DTOs;
using AutoMapper;

namespace AcmeApi.Profiles
{
    public class LoansProfile: Profile
    {
        public LoansProfile()
        {
            CreateMap<Loan, LoanReadDto>();
        }
    }
}