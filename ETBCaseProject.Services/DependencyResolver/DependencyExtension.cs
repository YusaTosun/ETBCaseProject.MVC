using AutoMapper;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Repository.Repositories;
using ETBCaseProject.Repository.UnitOfWorks;
using ETBCaseProject.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Services.DependencyResolver
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IMapper,Mapper>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped(typeof(IService<>),typeof(Service<>));
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

        }
    }
}
