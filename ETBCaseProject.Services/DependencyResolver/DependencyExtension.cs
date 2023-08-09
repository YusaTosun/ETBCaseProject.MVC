using AutoMapper;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Repository.Repositories;
using ETBCaseProject.Repository.UnitOfWorks;
using ETBCaseProject.Services.Mapping;
using ETBCaseProject.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ETBCaseProject.Services.DependencyResolver
{
    /// <summary>
    /// Program.cs sınıfını temiz tutmak için oluşturulmuş IServiceCollection sxtension sınıfı
    /// </summary>
    public static class DependencyExtension
    {
        /// <summary>
        /// Program.cs sınıfını temiz tutmak için oluşturulmuş IServiceCollection Extension methodu
        /// </summary>
        /// <param name="services"></param>
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new MapProfile());
            });

            var mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
