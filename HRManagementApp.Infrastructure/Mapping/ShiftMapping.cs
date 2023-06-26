using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class ShiftMapping:BaseEntityMapping<Shift>
    {
        public override void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Company).WithMany(x => x.Shifts).HasForeignKey(x => x.CompanyID);
            base.Configure(builder);
        }
    }
}
