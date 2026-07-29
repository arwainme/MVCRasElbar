using DayOneMVCRasElbar.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayOneMVCRasElbar.Controllers
{
    public class DepartmentController : Controller
    {

        CompanyDbContext _Context = new CompanyDbContext();
        public IActionResult GetDepartments()
        {
            var depts = _Context.Departments.ToList();

            return View("GetDepartments", depts);
        }

    //    public IActionResult Add()
    //    {
    //        return View("Add");
    //    }

    //    public IActionResult AddToDB(string name , string manger , string description)
    //    {

    //        Department deptToDB = new Department();
    //        if (deptFromUser.Name != null && deptFromUser.ManagerName != null && deptFromUser.Description != null)
    //            //{
    //            if (name != null)
    //            {
    //                // Mapping 
    //                //deptToDB.Name = deptFromUser.Name;
    //                //deptToDB.Description = deptFromUser.Description;
    //                //deptToDB.ManagerName = deptFromUser.ManagerName;
    //                //

    //                deptToDB.Name = name;
    //            deptToDB.ManagerName = manger;
    //            deptToDB.Description = description;

    //            _Context.Departments.Add(deptToDB);
    //            _Context.SaveChanges();

          
    //            return View("Add" );



    //}



    }
}
