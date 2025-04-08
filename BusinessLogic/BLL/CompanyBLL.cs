using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using EmployeeDataAccess.Repositories;

namespace BusinessLogic.BLL
{
    public class CompanyBLL
    {
        public void AddEmployeeToCompany(Employee employeeDTO, int companyId)
        {
            CompanyRepository.addEmployeeToCompany(companyId, employeeDTO.EmployeeId);
        }

        // Få alle medarbejdere for en virksomhed (DTO version)
        public List<Employee> GetEmployeesByCompany(int companyId)
        {
            return CompanyRepository.getCompanyEmployees(companyId);
        }
        public Company GetCompany(int companyId)
        {
            return CompanyRepository.getCompany(companyId);
        }
    }

}
