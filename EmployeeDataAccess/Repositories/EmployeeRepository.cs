using DTO.Model;
using EmployeeDataAccess.Context;
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
        public static void AddEmployee(DTO.Model.Employee employee)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                context.Employees.Add(EmployeeMapper.Map(employee));
                context.SaveChanges();
            }
        }



    }
}
/* using (var context = new EmployeeContext())
            {
                var company = context.Companies.FirstOrDefault(c => c.CompanyId == companyId);

                if (company == null)
                {
                    throw new Exception("Company not found.");
                }

                // Mapper fra DTO til DAL
                var employee = EmployeeMapper.Map(employeeDTO);

                // Tilknyt medarbejderen til den valgte virksomhed
                employee.CompanyId = company.CompanyId;  // Sæt virksomhedens ID på medarbejderen

                // Gem medarbejderen i databasen
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            //car car = context.Cars.Where(c => c.CarId == id).Include(c => c.Guests).FirstOrD
            //foreach  (dto.guest guest in guests) {
            //guest g = context.guests.find(guest.id),
            //car.guests.add(g),
            //context.savechanges
            using (var context = new EmployeeContext())
            {
                var company = context.Companies
                    .Include(c => c.Employees)  // Inkluder medarbejderne
                    .FirstOrDefault(c => c.CompanyId == companyId);

                return company?.Employees.Select(e => EmployeeMapper.MapToDTO(e)).ToList() ?? new List<Employee>();
            }*/