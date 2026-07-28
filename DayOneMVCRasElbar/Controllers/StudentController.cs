using DayOneMVCRasElbar.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayOneMVCRasElbar.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        public IActionResult GetAllStudents()
        {
            StudentBL studentsBL = new StudentBL();
            var students = studentsBL.GetAllStudents();

            return View("GetAll",students);
        }
        public IActionResult StudentDetails(int id)
        {
            StudentBL studentsBL = new StudentBL();
            var student = studentsBL.Details(id);

            return View("StudentDetails", student);



        }



    }
}
