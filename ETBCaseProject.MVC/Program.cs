using AutoMapper;
using ETBCaseProject.MVC.Mapping;
using ETBCaseProject.MVC.Validations;
using ETBCaseProject.Repository;
using ETBCaseProject.Services.DependencyResolver;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ETBCaseProject.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddFluentValidation( x=> x.RegisterValidatorsFromAssemblyContaining<CustomerCreateVMValidator>());

            builder.Services.AddDbContext<EtbDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>

                option.MigrationsAssembly(Assembly.GetAssembly(typeof(EtbDbContext)).GetName().Name));
            });
            builder.Services.AddDependencies();




            builder.Services.AddAutoMapper(typeof(MapProfile));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Customer}/{action=Index}/{id?}");

            app.Run();
        }
    }
}