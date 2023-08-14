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
    public class EmployeeMapping:BaseEntityMapping<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Company).WithMany(x => x.Employees).HasForeignKey(x => x.CompanyID);
            builder.HasOne(x => x.Shift).WithMany(x => x.Employees).HasForeignKey(x => x.ShiftID);
            builder.Property(x => x.Salary).HasColumnType("money");
            base.Configure(builder);
        }
    }
}
