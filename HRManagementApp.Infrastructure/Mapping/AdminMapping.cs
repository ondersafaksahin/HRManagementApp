using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class AdminMapping:BaseEntityMapping<Admin>
    {
        public override void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.ID);
            base.Configure(builder);
        }
    }
}
