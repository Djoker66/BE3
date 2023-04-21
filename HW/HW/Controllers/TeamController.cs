using HW.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Teams);
        }

        public IActionResult Detail(int id)
        {
            Team tm = Data.Teams.Find(x => x.Id == id);

            return View(tm);
        }
    }
}
