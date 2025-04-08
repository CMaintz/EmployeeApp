using DTO.Model;

using EmployeeDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class EmployeeBLL
    {
        public Employee getEmployee(int id)
        {
            if (id < 0) throw new IndexOutOfRangeException();
            return EmployeeRepository.getEmployee(id);
        }
        public void addEmployee(Employee employee)
        {
            //TODO: valider employee?
            EmployeeRepository.addEmployee(employee);
        }
        public void editEmployee(Employee employee)
        {
            //TODO
        }

        public void deleteCompany(Company company)
        {
            //TODO
        }

    }
}
