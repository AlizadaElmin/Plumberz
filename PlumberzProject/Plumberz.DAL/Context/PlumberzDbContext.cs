using Microsoft.EntityFrameworkCore;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Context;

public class PlumberzDbContext:DbContext
{
    public PlumberzDbContext(DbContextOptions opt):base(opt)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlumberzDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
