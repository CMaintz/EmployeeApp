using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{           
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
        }
        public Employee(int employeeId, string name, int yearsEmployed, int companyId)
        {
            EmployeeId = employeeId;
            Name = name;
            CompanyId = companyId;
            YearsEmployed = yearsEmployed;
        }

        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 45)]
        public int YearsEmployed { get; set; }

        public int CompanyId { get; set; }

    }
}
