using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Company() { }

        public Company(int companyId, string name, List<Employee> employees)
        {
            CompanyId = companyId;
            Name = name;
            Employees = employees;
        }

        public String DisplayDetails()
        {
           return $"Name: {Name} (ID: {CompanyId})" +
                    $"\nHeadcount: {Employees.Count}";
        }
    }

}
