using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.BLL;

namespace WebGUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*   EmployeeBLL employeeBLL= new EmployeeBLL();
               CompanyBLL companyBLL = new CompanyBLL();
               ViewBag.Employees = employeeBLL.getAllEmployees();
               ViewBag.Companies = companyBLL.getAllCompanies();

             @model List<DTO.Model.Employee>

   @foreach (var p in Model)
   {
       @Html.Action("ShowEmployee", "Home", p)
   }

   @model List<DTO.Model.Company>

   @foreach (var p in Model)
   {
       @Html.Action("ShowCompany", "Home", p)
   }*/
            return View();
        }
    }
}