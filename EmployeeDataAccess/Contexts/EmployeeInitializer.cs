using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDataAccess.Model;

namespace EmployeeDataAccess.Contexts
{
    internal class EmployeeInitializer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            context.Companies.Add(new Model.Company(1, "Systematic"));
            context.Companies.Add(new Model.Company(2, "EAAA"));

            context.Employees.Add(new Model.Employee(1, "Olsen", 5, 1));
            context.Employees.Add(new Model.Employee(2, "Hansen", 8, 1));
            context.Employees.Add(new Model.Employee(3, "Jensen", 11, 2));
            context.Employees.Add(new Model.Employee(4, "Maintz", 2, 2));
            context.SaveChanges();
        }

        //make sure EntityFramework.SqlServer.dll is included in bin folder
        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
