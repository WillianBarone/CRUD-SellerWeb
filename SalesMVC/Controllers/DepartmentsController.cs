using Microsoft.AspNetCore.Mvc;
using SalesMVC.Models;

namespace SalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department {Id = 1, Name = "Eletronic"});
            departments.Add(new Department {Id = 2, Name = "Fashion"});
            departments.Add(new Department {Id = 3, Name = "Musical"});

            return View(departments);
        }
    }
}
