using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

        public int YearsEmployed { get; set; }


        public Employee()
        {
        }

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(int employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
        }
        public Employee(string name, int yearsEmployed)
        {
            Name = name;
            YearsEmployed = yearsEmployed;
        }
        public Employee(int employeeId, string name, int yearsEmployed)
        {
            EmployeeId = employeeId;
            Name = name;
            YearsEmployed = yearsEmployed;
        }

        public Employee(int employeeId, string name, int yearsEmployed, int companyId)
        {
            EmployeeId = employeeId;
            Name = name;
            CompanyId = companyId;
            YearsEmployed = yearsEmployed;
        }


    }
}
