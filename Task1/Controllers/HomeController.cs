using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private Data _data;
        public HomeController(Data data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            return View(_data);
        }
    }
}
