using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController:Controller
    {
        [Route("Admin")]
        public IActionResult Index(){
            return View();
        }
    }
}