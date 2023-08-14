using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Repository.Repositories;
using ETBCaseProject.Repository.UnitOfWorks;
using ETBCaseProject.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ETBCaseProject.Services.DependencyResolver
{
    /// <summary>
    /// Program.cs sınıfını temiz tutmak için oluşturulmuş IServiceCollection extension sınıfı
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
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
