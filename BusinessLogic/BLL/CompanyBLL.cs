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
        public void addEmployeeToCompany(int companyId, Employee employee)
        {
            CompanyRepository.addEmployeeToCompany(companyId, employee.EmployeeId);
        }

        // Få alle medarbejdere for en virksomhed (DTO version)
        public List<Employee> getEmployeesByCompany(int companyId)
        {
            return CompanyRepository.getCompanyEmployees(companyId);
        }

        public Company getCompany(int companyId)
        {
            return CompanyRepository.getCompany(companyId);
        }

        public void addCompany(Company company) {
            CompanyRepository.addCompany(company);
        }

        public void deleteCompany(Company company)
        {
            //TODO
        }
        public void editCompany(Company company)
        {
            //TODO
        }
    }

}
