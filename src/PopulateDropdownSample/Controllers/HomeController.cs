using System.Web.Mvc;
using PopulateDropdownSample.Models;

namespace PopulateDropdownSample.Controllers
{
    public class HomeController : Controller
    {
         public ActionResult Index()
         {
             return View();
         }

        [HttpPost]
        public ActionResult Index(HomeModel model)
        {
            TempData["Success"] = "Yay you posted and your selection stayed.";
            return View(model);
        }
    }
}