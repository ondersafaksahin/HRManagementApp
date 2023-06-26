using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class LeaveMapping:BaseEntityMapping<Leave>
    {
        public override void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Employee).WithMany(x => x.Leaves).HasForeignKey(x => x.EmployeeID);
            base.Configure(builder);
        }
    }
}
