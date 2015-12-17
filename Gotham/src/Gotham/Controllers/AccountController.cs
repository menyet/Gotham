using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Gotham.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<string>() {
                "Account 1",
                "Account 2",
            });
        }

//         public IActionResult About()
//         {
//             ViewData["Message"] = "Your application description page.";
// 
//             return View();
//         }
// 
//         public IActionResult Contact()
//         {
//             ViewData["Message"] = "Your contact page.";
// 
//             return View();
//         }
// 
//         public IActionResult Error()
//         {
//             return View();
//         }
    }
}
