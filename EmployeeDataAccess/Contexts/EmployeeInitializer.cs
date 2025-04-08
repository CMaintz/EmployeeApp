using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDataAccess.Model;

namespace EmployeeDataAccess.Context
{
    internal class EmployeeInitializer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {

            /* Company c1 = new Company(1, "Systematic");
             Company c2 = new Company(2, "EAAA");





             Employee e1 = new Employee(1, "Olsen", 1);
             Employee e2 = new Employee(2, "Hansen", 1);
             Employee e3 = new Employee(3, "Jensen", 2);
             Employee e4 = new Employee(4, "Maintz", 2);

             c1.Employees.Add(e1);
             c1.Employees.Add(e2);
             c2.Employees.Add(e3);
             c2.Employees.Add(e4);

             context.Companies.Add(c1);
             context.Companies.Add(c2);

             context.Employees.Add(e1);
             context.Employees.Add(e2);
             context.Employees.Add(e3);
             context.Employees.Add(e4);*/

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
