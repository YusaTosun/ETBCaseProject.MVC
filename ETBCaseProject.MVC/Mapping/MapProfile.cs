using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.MVC.Models.CustomerViewModels;

namespace ETBCaseProject.MVC.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerListVM>();
            CreateMap<Customer, CustomerDetailsVM>();
            CreateMap<CustomerCreateVM, Customer>();
            CreateMap<CustomerUpdateVM, Customer>().ReverseMap();

        }
    }
}
