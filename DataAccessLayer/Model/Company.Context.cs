namespace DataAccessLayer.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities()
            : base("name=CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmployee>(m => m.Requires("TYPE_EMP").HasValue(1))
            .Map<PartTimeEmployee>(m => m.Requires("TYPE_EMP").HasValue(2));
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
    }
}