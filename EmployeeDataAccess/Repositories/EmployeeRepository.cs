using DTO.Model;
using EmployeeDataAccess.Contexts;
using EmployeeDataAccess.Mappers;
using EmployeeDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EmployeeDataAccess.Repositories
{
    public class EmployeeRepository
    {
        public static DTO.Model.Employee getEmployee(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                //Maybe throw exception if not found?
                return EmployeeMapper.Map(context.Employees.Find(id));
            }
        }
        public static void addEmployee(DTO.Model.Employee employee)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                context.Employees.Add(EmployeeMapper.Map(employee));
                context.SaveChanges();
            }
        }

        public static List<DTO.Model.Employee> getAllEmployees()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                List<DTO.Model.Employee> employees = context.Employees.Select(e => EmployeeMapper.Map(e)).ToList();

                /*foreach (var employee in context.Employees)
                {
                    employees.Add(EmployeeMapper.Map(employee));
                }*/
                //return context.Employees.Select(e => EmployeeMapper.Map(e)).ToList();
                return employees;
            }
        }



    }
}
