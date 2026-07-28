using Microsoft.AspNetCore.Mvc;

namespace DayOneMVCRasElbar.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
