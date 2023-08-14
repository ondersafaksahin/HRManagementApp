using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class CompanyMapping:BaseEntityMapping<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Package).WithMany(x => x.Companies).HasForeignKey(x => x.PackageID);
            base.Configure(builder);
        }
    }
}
