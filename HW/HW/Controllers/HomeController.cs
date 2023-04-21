using HW.Models;
using HW.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Services = Data.Services,
                Teams = Data.Teams,
            };

            return View(homeVM);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
