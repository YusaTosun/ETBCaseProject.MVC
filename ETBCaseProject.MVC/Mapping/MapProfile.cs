using AutoMapper;
using ETBCaseProject.Core.DTOs;
using ETBCaseProject.Core.Models;
using ETBCaseProject.MVC.Models.CustomerViewModels;

namespace ETBCaseProject.MVC.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerListVM>();
            CreateMap<CustomerCreateVM, Customer>();
            CreateMap<CustomerUpdateVM, Customer>();

        }
    }
}
