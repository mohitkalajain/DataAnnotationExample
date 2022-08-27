using DataAnnotationExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotationExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee EmployeeModel)
        {
            string Response = "";
            if (ModelState.IsValid)
            {
                Response = "Employee Data Saved Successfully";
            }
            else
            {
                Response =ModelState.ToString();
            }
            ViewBag.Message = Response;
            return View();
        }
    }
}
