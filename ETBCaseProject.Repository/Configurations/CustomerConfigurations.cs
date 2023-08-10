using ETBCaseProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETBCaseProject.Repository.Configurations
{
    /// <summary>
    /// Customer sınıfının entity configürasyonları için özelleştirilmiş sınıf 
    /// </summary>
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.MailAddress).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
        }
    }
}
