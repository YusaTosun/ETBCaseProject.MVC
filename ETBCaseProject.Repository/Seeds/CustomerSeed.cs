using ETBCaseProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Repository.Seeds
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer()
                {
                   Id = 1,
                   FullName = "Mehmet Yılmaz",
                   MailAddress="mehmetyilmaz@gmail.com",
                   PhoneNumber="05334567891",
                   BirthDate=DateTime.Now.AddYears(-30),
                   CreatedDate=DateTime.Now,
                },
                 new Customer()
                 {
                     Id = 2,
                     FullName = "Cenk Kılıç",
                     MailAddress = "cenkkilic@gmail.com",
                     PhoneNumber = "05354577891",
                     BirthDate = DateTime.Now.AddYears(-25),
                     CreatedDate = DateTime.Now,
                 },
                  new Customer()
                  {
                      Id = 3,
                      FullName = "Mehmet Yılmaz",
                      MailAddress = "mehmetyilmaz@gmail.com",
                      PhoneNumber = "05334578681",
                      BirthDate = DateTime.Now.AddYears(-40),
                      CreatedDate = DateTime.Now,
                  }
                );
        }
    }
}
