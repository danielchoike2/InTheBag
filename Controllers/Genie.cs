using Microsoft.AspNetCore.Mvc;

namespace InTheBag.Controllers
{
    public class Genie : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        /* [HttpPost]
         public IActionResult Create(string GenieName, int Age, int WishesGranted)
         {
             if (WishesGranted > 5000 || Age > 1000)
                 return View("ExperiencedGenie");
             else
                 return View("Novice");
         } */

        [HttpPost]
        public IActionResult Create(string GenieName)
        {
            int numGranted = Int32.Parse(Request.Form["WishesGranted"]);
            int Years = Int32.Parse(Request.Form["Age"]);

            if (numGranted > 5000 || Years > 1000)
                return View("ExperiencedGenie");
            else
            {
                return View("Novice");
            }
        }
    
    
    }
}
