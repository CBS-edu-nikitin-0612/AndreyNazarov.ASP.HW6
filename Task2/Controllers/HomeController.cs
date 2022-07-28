using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Task2.Controllers
{
	public class HomeController : Controller
	{
		private CalcService _calcService;
		public HomeController(CalcService calcService)
		{
			_calcService = calcService;
		}
		public async Task<ActionResult> Index()
		{
			return await Task.Run(() => View(TempData["result"]));
		}

		[HttpPost]
		public async Task<RedirectToActionResult> Sub(int left, int right)
		{
			TempData["result"] = _calcService.Sub(left, right);
			return await Task.Run(() => RedirectToAction("Index"));
		}

		[HttpPost]
		public async Task<ActionResult> Div(int left, int right)
		{
			TempData["result"] = _calcService.Div(left, right);
			return await Task.Run(() => RedirectToAction("Index"));
		}
		[HttpPost]
		public async Task<ActionResult> Mul(int left, int right)
		{
			TempData["result"] = _calcService.Mul(left, right);
			return await Task.Run(() => RedirectToAction("Index"));
		}
		[HttpPost]
		public async Task<ActionResult> Add(int left, int right)
		{
			TempData["result"] = _calcService.Add(left, right);
			return await Task.Run(() => RedirectToAction("Index"));
		}
	}
}
