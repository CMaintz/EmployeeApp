using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.BLL;
using WebGUI.ViewModel;

namespace WebGUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
              EmployeeBLL employeeBLL= new EmployeeBLL();
               CompanyBLL companyBLL = new CompanyBLL();
     
            var model = new HomeViewModel
            {
                Employees = employeeBLL.getAllEmployees(),
                Companies = companyBLL.getAllCompanies()
            };
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult ShowEmployee(DTO.Model.Employee employee)
        {
            return PartialView(employee);
        }

        [ChildActionOnly]
        public ActionResult ShowCompany(DTO.Model.Company company)
        {
            return PartialView(company);
        }

    }

}
