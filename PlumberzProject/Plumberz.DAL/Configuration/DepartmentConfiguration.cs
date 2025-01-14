using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .Property(x => x.Name)
                .HasMaxLength(64)
                .IsRequired();
            builder
                .HasMany(x => x.Employees)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId);
        }
    }
}
