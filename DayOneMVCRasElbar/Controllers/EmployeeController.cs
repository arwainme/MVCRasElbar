using DayOneMVCRasElbar.Models;
using DayOneMVCRasElbar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DayOneMVCRasElbar.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext _context = new CompanyDbContext();

        public IActionResult GetAll()
        {
            var employees = _context.Employees.ToList();
            // select * from Employees

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
        // render view with model data

        public IActionResult Details(int id)
        {
            var emp = _context.Employees.FirstOrDefault(x => x.Id == id);
            if(emp == null)
            {
                return NotFound();
            }

            return View("Details", emp);


        }


        public IActionResult DetailsVM(int id)
        {
            EmployeeNameDeptname empFromVm = new EmployeeNameDeptname();

            var empFromDB = _context.Employees
                .Include(x=>x.Department)
                .FirstOrDefault(x => x.Id == id);

            empFromVm.EmpName = empFromDB.Name;

            empFromVm.DeptName = empFromDB.Department.Name;

            empFromVm.Color = "red";
            return View("Index", empFromVm);



        }


        public IActionResult Add()
        {
            return View("Add");
        }
        public IActionResult SaveAdd(Employee emFromUser)
        {
            Employee EmpToDB = new Employee();

            EmpToDB.Name = emFromUser.Name;
            EmpToDB.Salary = emFromUser.Salary;
            EmpToDB.Address = emFromUser.Address;
            _context.Employees.Add(EmpToDB);
            _context.SaveChanges();


            return View("NewADD" , EmpToDB);
        }















        //public IActionResult GetById(int id)
        //{
        //    Employee employee = _context.Employees.Include(x => x.Department).FirstOrDefault(e => e.Id == id);

        //    EmployeeDepartment empVm = new EmployeeDepartment();

        //    empVm.DeptName = employee.Department.Name;
        //    empVm.EmpName = employee.Name;

        //    return View("GetById", empVm);
        //}

    }
}
