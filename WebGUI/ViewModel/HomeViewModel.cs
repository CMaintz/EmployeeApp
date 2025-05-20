using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGUI.ViewModel
{
    public class HomeViewModel
    {
        public List<DTO.Model.Employee> Employees { get; set; }
        public List<DTO.Model.Company> Companies { get; set; }
    }
}