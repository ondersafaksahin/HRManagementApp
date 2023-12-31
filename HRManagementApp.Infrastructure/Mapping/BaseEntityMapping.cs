﻿using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Mapping
{
    public class BaseEntityMapping<T> : IEntityTypeConfiguration<T> where T:class,IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.ModifiedBy).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
