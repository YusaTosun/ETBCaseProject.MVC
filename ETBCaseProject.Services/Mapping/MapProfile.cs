using AutoMapper;
using ETBCaseProject.Core.DTOs;
using ETBCaseProject.Core.Models;

namespace ETBCaseProject.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
