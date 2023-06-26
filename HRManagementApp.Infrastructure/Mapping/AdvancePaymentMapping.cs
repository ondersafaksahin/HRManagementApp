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
    public class AdvancePaymentMapping:BaseEntityMapping<AdvancePayment>
    {
        public override void Configure(EntityTypeBuilder<AdvancePayment> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Employee).WithMany(x => x.AdvancePayments).HasForeignKey(x => x.EmployeeID);
            builder.Property(x => x.Amount).HasColumnType("money");
            base.Configure(builder);
        }
    }
}
