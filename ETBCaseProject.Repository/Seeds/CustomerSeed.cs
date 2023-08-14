using ETBCaseProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                    Name = "Mehmet",
                    Surname = "Yıldırım",
                    MailAddress = "mehmetyilmaz@gmail.com",
                    PhoneNumber = "05334567891",
                    BirthDate = DateTime.Now.AddYears(-30),
                    CreatedDate = DateTime.Now,
                },
                 new Customer()
                 {
                     Id = 2,
                     Name = "Cenk",
                     Surname = "Kılıç",
                     MailAddress = "cenkkilic@gmail.com",
                     PhoneNumber = "05354577891",
                     BirthDate = DateTime.Now.AddYears(-25),
                     CreatedDate = DateTime.Now,
                 },
                  new Customer()
                  {
                      Id = 3,
                      Name = "Ceren",
                      Surname = "Anaç",
                      MailAddress = "cerenanac@gmail.com",
                      PhoneNumber = "05334578681",
                      BirthDate = DateTime.Now.AddYears(-40),
                      CreatedDate = DateTime.Now,
                  },
                  new Customer()
                  {
                      Id = 4,
                      Name = "Mert",
                      Surname = "Altın",
                      MailAddress = "mertaltin@gmail.com",
                      PhoneNumber = "05334578681",
                      BirthDate = DateTime.Now.AddYears(-40),
                      CreatedDate = DateTime.Now,
                  },
                  new Customer()
                  {
                      Id = 5,
                      Name = "Hüseyin",
                      Surname = "Dağlı",
                      MailAddress = "hüseyindagli@gmail.com",
                      PhoneNumber = "05334578681",
                      BirthDate = DateTime.Now.AddYears(-40),
                      CreatedDate = DateTime.Now,
                  },
                  new Customer()
                  {
                      Id = 6,
                      Name = "Buse",
                      Surname = "Eren",
                      MailAddress = "buseeren@gmail.com",
                      PhoneNumber = "05334578681",
                      BirthDate = DateTime.Now.AddYears(-40),
                      CreatedDate = DateTime.Now,
                  }
                );
        }
    }
}
