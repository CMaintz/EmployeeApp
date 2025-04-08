//using DTO.Model;
using EmployeeDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess.Contexts
{
    internal class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        public EmployeeContext() : base("Employees")
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           /* modelBuilder.Entity<Employee>()
               .HasRequired(e => e.Company) 
               .WithMany(c => c.Employees)  
               .HasForeignKey(e => e.CompanyId);*/
        }
    }
}
