﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using EmployeeDataAccess.Context;
using EmployeeDataAccess.Mappers;
using EmployeeDataAccess.Model;

namespace EmployeeDataAccess.Repositories
{
    public class CompanyRepository
    {
        public static DTO.Model.Company getCompany(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return CompanyMapper.Map(context.Companies.Find(id));
            }
        }

        public static List<DTO.Model.Employee> getCompanyEmployees(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return CompanyMapper.Map(context.Companies.Find(id)).Employees;
            }
        }

        public static void addCompany(DTO.Model.Company company)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                //TODO: throw if not found?
                context.Companies.Add(CompanyMapper.Map(company));
                context.SaveChanges();
            }

        }

        public static void addEmployeeToCompany(int companyId, DTO.Model.Employee employee)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
              //  Company company = context.Companies.Find(c => c.CompanyId == companyId);
            }
        }
        public static void addEmployeeToCompany(int companyId, int employeeId)
        {
            using (var context = new EmployeeContext())
            {
                var company = context.Companies.Include("Employees").FirstOrDefault(c => c.CompanyId == companyId);
                var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);

                if (company != null && employee != null)
                {
                    company.Employees.Add(employee);
                   // employee.Company = company; //dunno if needed
                    employee.CompanyId = companyId;//dunno if needed
                    context.SaveChanges();
                }
            }
        }
        public static void addEmployeeCompany(int companyId, List<DTO.Model.Employee> employees)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                Model.Company company = context.Companies.Where(c => c.CompanyId == companyId).FirstOrDefault();
                foreach (DTO.Model.Employee employee in employees)
                {
                    Model.Employee e = context.Employees.Find(employee.EmployeeId);
                    company.Employees.Add(e);
                }
                context.SaveChanges();
            }
        }
    }
}
