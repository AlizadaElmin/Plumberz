using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
            .Property(x => x.Name)
            .HasMaxLength(16)
            .IsRequired();
        builder
         .Property(x => x.Surname)
         .HasMaxLength(32)
         .IsRequired();
        builder
            .Property(x => x.ImageUrl)
            .HasMaxLength(255);
        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.DepartmentId);
    }
}
