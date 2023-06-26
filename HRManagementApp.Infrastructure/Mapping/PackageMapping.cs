using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class PackageMapping:BaseEntityMapping<Package>
    {
        public override void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Price).HasColumnType("money");
            base.Configure(builder);
        }
    }
}
