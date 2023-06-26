using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class ManagerMapping:BaseEntityMapping<Manager>
    {
        public override void Configure(EntityTypeBuilder<Manager> builder)
        {
            base.Configure(builder);
        }
    }
}
