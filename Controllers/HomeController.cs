using Microsoft.AspNetCore.Mvc;
using ActionToViewEx.Models;
namespace ActionToViewEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ProductID = 121;
            ViewBag.ProductName = "Mouse";
            ViewBag.Price = 450;
            ViewBag.MfgName = "Logitech";
            //    return View();
            return RedirectToAction("about");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult GetViewData()
        {
            ViewData["EmpID"] = 123;
            ViewData["EmpName"] = "Sunil";
            ViewData["DeptName"] = "Computer";
            ViewData["Salary"] = 45000;
            //return View();
            return RedirectToAction("ShowViewData");
        }

        public IActionResult ShowViewData()
        {
            return View();
        }


        public IActionResult GetTempData()
        {
            TempData["CustomerID"] = 123;
            TempData["CustomerName"] = "Manish";
            TempData["Address"] = "Nigadi Pune";
            TempData["CreditLimit"] = 45000;
            //   return View();
            return RedirectToAction("ShowTempData");
        }

        public IActionResult ShowTempData()
        {
            return View();
        }

        public IActionResult GetModel()
        {
            //Emp e = new Emp();
            Product p = new Product();
            return View(p);
        }
    }
}
