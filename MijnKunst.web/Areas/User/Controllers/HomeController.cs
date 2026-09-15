using Microsoft.AspNetCore.Mvc;
using MijnKunst.Models;
using System.Diagnostics;

namespace MijnKunst.web.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Copyright()
        {
            return View();
        }
    }
}
