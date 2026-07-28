using DayOneMVCRasElbar.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayOneMVCRasElbar.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext _context = new CompanyDbContext();

        public IActionResult GetAll()
        {
            var employees = _context.Employees.ToList();
            //color - temp - 

            #region ViewData
            ViewData["color"] = "red";
            ViewData["temp"] = 30;
            ViewData["Branches"] = new List<string>
            {
                "Cairo",
                "Alex",
                "Giza"
            };
            #endregion

            #region ViewBag

            ViewBag.Color = "green";

            ViewBag.Temp = 30;
            ViewBag.Branches = new List<string>
            {
                "iiii",
                "Alex",
                "Giza"
            };

            #endregion


            return View("GetAll", employees);
        }
    }
}
