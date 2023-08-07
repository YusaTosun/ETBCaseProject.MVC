using ETBCaseProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Repository.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.FullName).IsRequired();
            builder.Property(x=>x.MailAddress).IsRequired();
            builder.Property(x=>x.PhoneNumber).IsRequired();
        }
    }
}
