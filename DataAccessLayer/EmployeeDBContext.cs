using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shared.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class EmployeeDBContext : DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmployee>(m => m.Requires("TYPE_EMP").HasValue(1))
            .Map<PartTimeEmployee>(m => m.Requires("TYPE_EMP").HasValue(2));
        }
    }
}